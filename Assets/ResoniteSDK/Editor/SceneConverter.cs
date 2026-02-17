using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class SceneConverter : IConversionContext
{
    [SerializeField]
    Dictionary<Transform, ResoniteLink.Slot> _transformMap = new Dictionary<Transform, ResoniteLink.Slot>();

    [SerializeField]
    Dictionary<ResoniteComponent, Transform> _existingComponents = new Dictionary<ResoniteComponent, Transform>();

    [SerializeField]
    Dictionary<ResoniteObject, string> _idMap = new Dictionary<ResoniteObject, string>();

    AssetConversionManager _assetConverter;

    int _idPool;
    string _idPrefix;

    int _messageIndex;

    public string AllocateId(ResoniteObject o = null) => $"Unity_{_idPrefix}_{o?.GetType().Name}_{_idPool++:X}";
    public string GetId(ResoniteObject o) => _idMap[o];
    public string GetIdOrAllocate(ResoniteObject o) => GetIdOrAllocate(o, out _);
    public string GetIdOrAllocate(ResoniteObject o, out bool allocated)
    {
        if(!_idMap.TryGetValue(o, out var id))
        {
            id = AllocateId(o);
            _idMap.Add(o, id);

            allocated = true;
        }
        else
            allocated = false;

        return id;
    }
    public void RemoveId(ResoniteObject o) => _idMap.Remove(o);

    public string GetTransformSlotId(Transform transform) => _transformMap[transform].ID;

    public string GetUniqueMessageId(string prefix) => $"{prefix}_{_messageIndex++}";

    #region ASSETS

    public FrooxEngine.IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh)
    {
        if (mesh == null)
            return null;

        return _assetConverter.GetMesh(mesh);
    }
    public IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material)
    {
        if (material == null)
            return null;

        return _assetConverter.GetMaterial(material);
    }

    public void EnsureAssetConverter()
    {
        if (_assetConverter != null)
            return;

        _assetConverter = new AssetConversionManager(this);
    }

    #endregion

    public void Convert(IEnumerable<Transform> roots, LinkInterface link)
    {
        _assetConverter.BeginConversion();

        // First update all component conversions
        foreach (var root in roots)
            UpdateComponentConversions(root);

        var messages = new List<DataModelOperation>();

        foreach(var root in roots)
            ConvertHierarchy(root, messages);

        // Process any removals after all other stuff has been updated.
        // This way any transform that were reparented will be in new safe locations
        ProcessRemovals(messages);

        Task.Run(async () =>
        {
            try
            {
                // For quick debug purposes
                /*var operations = new DataModelOperationBatch();
                operations.Operations = messages.ToList<Message>();
                var json = System.Text.Json.JsonSerializer.Serialize(operations, ResoniteLink.LinkInterface.SerializationOptions);
                Debug.Log(json);*/

                var response = await link.RunDataModelOperationBatch(messages);

                if (!response.Success)
                {
                    Debug.LogError($"Data model batch operation failed: {response.ErrorInfo}");
                    return;
                }

                foreach (var subResponse in response.Responses)
                    if (!subResponse.Success)
                        Debug.LogError($"Operation failed for {subResponse.SourceMessageID}: {subResponse.ErrorInfo}");
            }
            catch(Exception ex)
            {
                Debug.LogError(ex);
            }
        }).Wait();

        _assetConverter.ProcessConversions(link);
    }

    void ProcessRemovals(List<DataModelOperation> messages)
    {
        List<Transform> transformsToRemove = null;

        foreach(var pair in _transformMap)
        {
            // I don't like that Unity does it this way, but this is how it checks if it's destroyed
            if (pair.Key != null)
                continue;

            if(transformsToRemove == null)
                transformsToRemove = new List<Transform>();

            // It's not actually null! It just pretends to be.
            transformsToRemove.Add(pair.Key);

            messages.Add(new RemoveSlot()
            {
                MessageID = GetUniqueMessageId($"RemoveSlot_{pair.Value.Name}"),
                SlotID = pair.Value.ID,
            });
        }

        if (transformsToRemove != null)
            foreach (var remove in transformsToRemove)
                _transformMap.Remove(remove);

        List<ResoniteComponent> componentsToRemove = null;

        // Do the components next
        foreach(var component in _existingComponents)
        {
            if (component.Key != null)
                continue;

            // Check if the transform itself is removed also
            // We need to do this through the dictionary, because we can't access transform on the component itself
            // when it has been removed.
            if (component.Value != null)
            {
                // The transform it exists on still exists, so we need to remove it explicitly
                // Otherwise it will be removed with the transform/slot, so we don't need to send message for it
                messages.Add(component.Key.GenerateRemoval(this));
            }

            // We still need to remove it
            if (componentsToRemove == null)
                componentsToRemove = new List<ResoniteComponent>();

            componentsToRemove.Add(component.Key);

            // Make sure all the ID's are cleaned up too
            component.Key.RemoveIDs(this);
        }

        if(componentsToRemove != null)
            foreach(var remove in componentsToRemove)
                _existingComponents.Remove(remove);
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
            // We might've just destroyed some of the components in previous step when removing converters
            // Skip over these
            if (component == null)
                continue;

            // Converters don't need to be converted - they're the ones doing the conversions!
            if (component is ResoniteComponentConverter)
                continue;

            // Ignore the Resonite components too - they're already converted (or manually attached)!
            if (component is ResoniteComponent)
                continue;

            if(!converterMap.TryGetValue(component, out var converter))
            {
                // There's no converter for this. Check if one is supported
                var converterType = ComponentConverterRepository.TryGetConverter(component.GetType());

                // There's no converter for this, so just ignore it
                if (converterType == null)
                    continue;

                // Create a new converter instance
                converter = (ResoniteComponentConverter)root.gameObject.AddComponent(converterType);
                converter.Initialize(component);

                converterMap.Add(component, converter);
            }

            // Update the conversion. This should handle both cases when it was freshly added
            // As well as when this is an existing one and we're updating components
            converter.UpdateConversion(this);
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
        ConvertComponents(root, messages);

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
            slot = new ResoniteLink.Slot();

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
            message.MessageID = GetUniqueMessageId($"AddSlot_{transform.name})");
        }
        else
        {
            message = new UpdateSlot();
            message.MessageID = GetUniqueMessageId($"UpdateSlot_{transform.name})");
        }

        GatherTransformData(transform, slot);
        
        message.Data = slot;

        messages.Add(message);
    }

    void GatherTransformData(Transform transform, ResoniteLink.Slot data)
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

    void ConvertComponents(Transform transform, List<DataModelOperation> messages)
    {
        var components = transform.GetComponents<ResoniteComponent>();

        foreach (var c in components)
        {
            var data = c.CollectData(this);

            if(_existingComponents.TryAdd(c, c.transform))
            {
                // We just added this component, so we need to generate add component message

                // We must assign the type when we're adding it
                // For updates we skip, since it's no longer necessary
                data.ComponentType = c.TypeName;

                var addComponent = new AddComponent()
                {
                    MessageID = GetUniqueMessageId($"AddComponent_{c.GetType().Name}"),
                    ContainerSlotId = GetTransformSlotId(c.transform),
                    Data = data,
                };

                messages.Add(addComponent);
            }
            else
            {
                var updateComponent = new UpdateComponent()
                {
                    MessageID = GetUniqueMessageId($"UpdateComponent_{c.GetType().Name}"),
                    Data = data
                };

                messages.Add(updateComponent);
            }
        }
    }
}
