using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ResoniteLink;
using System;
using System.Threading.Tasks;
using Unity.VisualScripting;

[Serializable]
public class SceneConverter
{
    [SerializeField]
    Dictionary<Transform, Slot> _transformMap = new Dictionary<Transform, Slot>();

    int _idPool;
    string _idPrefix;

    int _messageIndex;

    public string AllocateId() => $"Unity_{_idPrefix}_{_idPool++:X}";

    public void Convert(IEnumerable<Transform> roots, LinkInterface link)
    {
        // First update all component conversions
        foreach (var root in roots)
            UpdateComponentConversions(root);

        var messages = new List<DataModelOperation>();

        foreach(var root in roots)
            ConvertHierarchy(root, messages);

        Task.Run(async () =>
        {
            var response = await link.RunDataModelOperationBatch(messages);

            if(!response.Success)
            {
                Debug.LogError($"Data model batch operation failed: {response.ErrorInfo}");
                return;
            }

            foreach (var subResponse in response.Responses)
                if (!subResponse.Success)
                    Debug.LogError($"Operation failed for {subResponse.SourceMessageID}: {subResponse.ErrorInfo}");
        });
    }

    void UpdateComponentConversions(Transform root)
    {
        var components = root.GetComponents<UnityEngine.Component>();
        var converterMap = new Dictionary<UnityEngine.Component, ResoniteComponentConverter>();

        // First get all the converters
        foreach(var component in components)
            if(component is ResoniteComponentConverter converter)
            {
                // Check if the target still exists
                if (converter.Target == null)
                    UnityEngine.Object.DestroyImmediate(converter);
                else
                    converterMap.Add(converter.Target, converter);
            }

        foreach(var component in root.GetComponents<UnityEngine.Component>())
        {
            // Converters don't need to be converted - they're the ones doing the conversions!
            if (component is ResoniteComponentConverter)
                continue;

            if(!converterMap.TryGetValue(component, out var converter))
            {
                // There's no converter for this. Check if one is supported
                var converterType = ComponentConverterRepository.TryGetConverter(component.GetType());

                // There's no coverter for this, so just ignore it
                if (converterType == null)
                    continue;

                // Create a new converter instance
                converter = (ResoniteComponentConverter)root.gameObject.AddComponent(converterType);
                converter.Initialize(component);

                converterMap.Add(component, converter);
            }

            // Update the conversion. This should handle both cases when it was freshly added
            // As well as when this is an existing one and we're updating components
            converter.UpdateConversion();
        }

        // Process children recursively
        for (int i = 0; i < root.childCount; i++)
        {
            var child = root.GetChild(i);
            UpdateComponentConversions(child);
        }
    }

    void ConvertHierarchy(Transform root, List<DataModelOperation> messages)
    {
        Convert(root, messages);
        ConvertComponents(root);

        // Process children recursively
        for (int i = 0; i < root.childCount; i++)
        {
            var child = root.GetChild(i);
            ConvertHierarchy(child, messages);
        }
    }

    void Convert(Transform transform, List<DataModelOperation> messages)
    {
        AddUpdateSlotData message;

        if (!_transformMap.TryGetValue(transform, out var slot))
        {
            slot = new Slot();

            slot.ID = AllocateId();

            slot.Parent = new Reference() { ID = AllocateId() };

            slot.Position = new Field_float3() { ID = AllocateId() };
            slot.Rotation = new Field_floatQ() { ID = AllocateId() };
            slot.Scale = new Field_float3() { ID = AllocateId() };
            slot.Name = new Field_string() { ID = AllocateId() };
            slot.Tag = new Field_string() { ID = AllocateId() };
            slot.IsActive = new Field_bool() { ID = AllocateId() };

            _transformMap.Add(transform, slot);

            message = new AddSlot();
            message.MessageID = $"AddSlot_{transform.name}_{_messageIndex++}";
        }
        else
        {
            message = new UpdateSlot();
            message.MessageID = $"UpdateSlot_{transform.name}_{_messageIndex++}";
        }

        GatherTransformData(transform, slot);
        
        message.Data = slot;

        messages.Add(message);
    }

    void GatherTransformData(Transform transform, Slot data)
    {
        if (transform.parent == null)
            data.Parent.TargetID = "Root";
        else
            data.Parent.TargetID = _transformMap[transform.parent].ID;

        data.Position.Value = transform.localPosition.ToResoniteLink();
        data.Rotation.Value = transform.localRotation.ToResoniteLink();
        data.Scale.Value = transform.localScale.ToResoniteLink();

        data.Name.Value = transform.name;

        if (transform.tag == "Untagged")
            data.Tag.Value = null;
        else
            data.Tag.Value = transform.tag;

        data.IsActive.Value = transform.gameObject.activeSelf;
    }

    void ConvertComponents(Transform transform)
    {
         
    }
}
