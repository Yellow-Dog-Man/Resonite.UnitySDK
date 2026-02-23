using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class SceneConverter : IConversionContext
{
    public string UniqueSessionId => _window.UniqueSessionId;
    public LinkInterface Link => _window.Link;

    // TODO!!! Move this to a dedicated connection manager so the Window is only managing the UI?
    ResoniteLinkWindow _window;

    [SerializeField]
    Dictionary<Transform, ResoniteLink.Slot> _transformMap = new Dictionary<Transform, ResoniteLink.Slot>();

    [SerializeField]
    Dictionary<ResoniteComponent, Transform> _existingComponents = new Dictionary<ResoniteComponent, Transform>();

    [SerializeField]
    HashSet<Transform> _existingSlots = new HashSet<Transform>();

    [SerializeField]
    Dictionary<ResoniteObject, string> _idMap = new Dictionary<ResoniteObject, string>();

    AssetConversionManager _assetConverter;

    int _idPool;
    int _messageIndex;

    public string AllocateId(ResoniteObject o = null)
    {
        if (o is FrooxEngine.Slot)
            throw new ArgumentException($"Cannot allocate ID for a Slot object! This needs to be handled through transforms");

        return $"Unity_{UniqueSessionId}_{o?.GetType().Name}_{_idPool++:X}";
    }

    public string GetId(ResoniteObject o)
    {
        // We need to treat slots differently, because they map to transforms
        if (o is FrooxEngine.Slot slot)
            return GetTransformSlotId(slot.Wrapper.transform);

        return _idMap[o];
    }
    public string GetIdOrAllocate(ResoniteObject o) => GetIdOrAllocate(o, out _);
    public string GetIdOrAllocate(ResoniteObject o, out bool allocated)
    {
        // We need to treat slots differently, because they map to transforms
        if (o is FrooxEngine.Slot slot)
        {
            allocated = false;
            return GetTransformSlotId(slot.Wrapper.transform);
        }

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

    public string GetTransformSlotId(Transform transform) => GetLinkSlot(transform).ID;

    public string GetUniqueMessageId(string prefix) => $"{prefix}_{_messageIndex++}";

    #region ASSETS

    public FrooxEngine.IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh)
    {
        if (mesh == null)
            return null;

        return _assetConverter.GetMesh(mesh);
    }

    public FrooxEngine.IAssetProvider<FrooxEngine.ITexture2D> GetITexture2D(UnityEngine.Texture texture)
    {
        if (texture == null)
            return null;

        switch(texture)
        {
            case UnityEngine.Texture2D texture2D:
                return (FrooxEngine.IAssetProvider<FrooxEngine.ITexture2D>)GetTexture2D(texture2D);

            default:
                Debug.LogWarning($"Unsupported ITexture2D type: {texture.GetType()}");
                return null;
        }
    }

    public FrooxEngine.IAssetProvider<FrooxEngine.ITexture> GetITexture(UnityEngine.Texture texture)
    {
        if (texture == null)
            return null;

        switch (texture)
        {
            case UnityEngine.Texture2D texture2D:
                return (FrooxEngine.IAssetProvider<FrooxEngine.ITexture>)GetTexture2D(texture2D);

            case UnityEngine.Cubemap cubemap:
                return (FrooxEngine.IAssetProvider<FrooxEngine.ITexture>)GetCubemap(cubemap);

            default:
                Debug.LogWarning($"Unsupported ITexture2D type: {texture.GetType()}");
                return null;
        }
    }

    public FrooxEngine.IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D texture)
    {
        if (texture == null)
            return null;

        return _assetConverter.GetTexture2D(texture);
    }

    public FrooxEngine.IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap cubemap)
    {
        if (cubemap == null)
            return null;

        return _assetConverter.GetCubemap(cubemap);
    }

    public IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material)
    {
        if (material == null)
            return null;

        return _assetConverter.GetMaterial(material);
    }

    public IAssetProvider<FrooxEngine.AudioClip> GetAudioClip(UnityEngine.AudioClip audioClip)
    {
        if (audioClip == null)
            return null;

        return _assetConverter.GetAudioClip(audioClip);
    }

    public void EnsureAssetConverter()
    {
        if (_assetConverter != null)
            return;

        _assetConverter = new AssetConversionManager(this);
    }

    #endregion

    public void EnsureInitialized(ResoniteLinkWindow window)
    {
        _window = window;
    }

    public void StartRealtimeMode()
    {
        // We must convert the whole scene first
        ConvertScene();

        // Start listening to events
        ObjectChangeEvents.changesPublished += ObjectChangeEvents_changesPublished;
    }

    public void StopRealtimeMode()
    {
        ObjectChangeEvents.changesPublished -= ObjectChangeEvents_changesPublished;
    }

    public void ConvertScene()
    {
        // Ensure asset converter has been initialized
        EnsureAssetConverter();

        var roots = SceneManager.GetActiveScene().GetRootGameObjects();

        Convert(roots.Select(g => g.transform));
    }

    public void Convert(IEnumerable<Transform> roots)
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

        SendOperationBatch(messages);
    }

    void SendOperationBatch(List<DataModelOperation> messages)
    {
        // Only send messages when there are actually any
        // We still want to run the rest of the function, because there can be any asset conversions scheduled
        if (messages.Count > 0)
        {
            Task.Run(async () =>
            {
                try
                {
                    // For quick debug purposes
                    /*var operations = new DataModelOperationBatch();
                    operations.Operations = messages.ToList<Message>();
                    var json = System.Text.Json.JsonSerializer.Serialize(operations, ResoniteLink.LinkInterface.SerializationOptions);
                    Debug.Log(json);*/

                    var response = await Link.RunDataModelOperationBatch(messages);

                    if (!response.Success)
                    {
                        Debug.LogError($"Data model batch operation failed: {response.ErrorInfo}");
                        return;
                    }

                    foreach (var subResponse in response.Responses)
                        if (!subResponse.Success)
                            Debug.LogError($"Operation failed for {subResponse.SourceMessageID}: {subResponse.ErrorInfo}");
                }
                catch (Exception ex)
                {
                    Debug.LogError(ex);
                }
            }).Wait();
        }

        _assetConverter.ProcessConversions(Link);
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
        var components = new List<UnityEngine.Component>();

        root.GetComponents<UnityEngine.Component>(components);
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

        // Re-fetch the components, because some might've been destroyed in the previous step
        components.Clear();
        root.GetComponents<UnityEngine.Component>(components);

        // Filter out the converters or the converted components, those don't need to be converted!
        components.RemoveAll(c => c is ResoniteComponentConverter || c is ResoniteComponent);

        // Get converters for all the types we have
        var converters = new Dictionary<UnityEngine.Component, ConverterInfo>();

        foreach(var component in components)
        {
            var converter = ComponentConverterRepository.TryGetConverter(component.GetType());

            if (converter == null)
                continue;

            converters.Add(component, converter);
        }

        // Run supression for all converters if present. This will remove any components that should not be converted directly
        foreach (var converter in converters.Values)
            converter.SupressionHandler?.Invoke(root, components);

        // Update/instantiate converters for all the components that we should process
        foreach(var component in components)
        {
            // We might've just destroyed some of the components in previous iterations - e.g. converters
            // can add/remove more components, so skip those just in case
            if (component == null)
                continue;            

            if(!converterMap.TryGetValue(component, out var converter))
            {
                // There's no existing converter for this. Check if one is supported. If not ignore it
                if (!converters.TryGetValue(component, out var converterInfo))
                    continue;

                // Create a new converter instance
                converter = (ResoniteComponentConverter)root.gameObject.AddComponent(converterInfo.Type);
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

        var slot = GetLinkSlot(transform);

        if(_existingSlots.Add(transform))
        {
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

    ResoniteLink.Slot GetLinkSlot(Transform transform)
    {
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
        }

        return slot;
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

    void ObjectChangeEvents_changesPublished(ref ObjectChangeEventStream stream)
    {
        _assetConverter.BeginConversion();

        var processedTransforms = new HashSet<Transform>();
        var transformsWithChangedComponents = new HashSet<Transform>();
        var messages = new List<DataModelOperation>();

        void TransformUpdated(Transform transform)
        {
            if (!processedTransforms.Add(transform))
                return;

            Convert(transform, messages);
        }

        void ComponentUpdated(UnityEngine.Component component)
        {
            // We want to process the transforms as whole, since the combinations of components might require
            // filtering and other things, so we just collect all the transforms that had their components changed
            transformsWithChangedComponents.Add(component.transform);
        }

        void ObjectChanged(UnityEngine.Object o, bool forceComponentUpdate = false)
        {
            switch(o)
            {
                case Transform transform:
                    TransformUpdated(transform);

                    if (forceComponentUpdate)
                        transformsWithChangedComponents.Add(transform);
                    break;

                case GameObject gameObject:
                    ObjectChanged(gameObject.transform, forceComponentUpdate);
                    break;

                case UnityEngine.Component component:
                    ComponentUpdated(component);
                    break; 

                default:
                    Debug.LogWarning($"Unsupported object changed: {o}");
                    break;
            }
        }

        bool gameObjectsDestroyed = false;

        for (int i = 0; i < stream.length; i++)
        {
            switch (stream.GetEventType(i))
            {
                case ObjectChangeKind.ChangeGameObjectOrComponentProperties:
                    stream.GetChangeGameObjectOrComponentPropertiesEvent(i, out var changeObject);
                    ObjectChanged(EditorUtility.InstanceIDToObject(changeObject.instanceId));
                    break;

                case ObjectChangeKind.CreateGameObjectHierarchy:
                    stream.GetCreateGameObjectHierarchyEvent(i, out var createObject);
                    ObjectChanged(EditorUtility.InstanceIDToObject(createObject.instanceId), true);
                    break;

                case ObjectChangeKind.ChangeGameObjectStructure:
                    stream.GetChangeGameObjectStructureEvent(i, out var changeStructure);
                    ObjectChanged(EditorUtility.InstanceIDToObject(changeStructure.instanceId), true);
                    break;

                case ObjectChangeKind.ChangeGameObjectParent:
                    stream.GetChangeGameObjectParentEvent(i, out var changeParent);
                    ObjectChanged(EditorUtility.InstanceIDToObject(changeParent.instanceId));
                    break;

                case ObjectChangeKind.DestroyGameObjectHierarchy:
                    // TODO!!! Should we keep track of the ID's and only target ones that are actually destroyed?
                    // This requires a bunch of extra bookkeeping, and just running the removals is simpler here
                    // but it might not perform the best for large scenes, so we'll have to re-evaluate the approach.
                    gameObjectsDestroyed = true;
                    break;

                case ObjectChangeKind.ChangeAssetObjectProperties:
                    stream.GetChangeAssetObjectPropertiesEvent(i, out var changeAsset);
                    var changedAsset = EditorUtility.InstanceIDToObject(changeAsset.instanceId);

                    // Force an asset update for any assets that have been converted
                    // Ignore everything else - it's not an asset we transferred over yet, so we don't need to bother with it
                    // Once it gets referenced by something, e.g. a component that will ensure conversion happens
                    switch(changedAsset)
                    {
                        case UnityEngine.Mesh mesh:
                            if (_assetConverter.HasMesh(mesh))
                                _assetConverter.GetMesh(mesh);
                            break;

                        case UnityEngine.Texture2D texture2D:
                            if (_assetConverter.HasTexture2D(texture2D))
                                _assetConverter.GetTexture2D(texture2D);
                            break;

                        case UnityEngine.Cubemap cubemap:
                            if (_assetConverter.HasCubemap(cubemap))
                                _assetConverter.GetCubemap(cubemap);
                            break;

                        case UnityEngine.AudioClip audioClip:
                            if (_assetConverter.HasAudioClip(audioClip))
                                _assetConverter.GetAudioClip(audioClip);
                            break;

                        case UnityEngine.Material material:
                            if (_assetConverter.HasMaterial(material))
                                _assetConverter.GetMaterial(material);
                            break;
                    }
                    break;

                default:
                    Debug.Log($"Change: {stream.GetEventType(i)}");
                    break;
            }
        }

        // Update the conversions first
        foreach (var changedComponents in transformsWithChangedComponents)
            UpdateComponentConversions(changedComponents);

        // Convert the actual components
        foreach (var changedComponents in transformsWithChangedComponents)
            ConvertComponents(changedComponents, messages);

        if (gameObjectsDestroyed)
            ProcessRemovals(messages);

        // Convert any updated asset providers
        // We don't need to run the component conversion on these - this should be only the bindings
        if (_assetConverter.HasPendingChanges)
            foreach (var root in _assetConverter.UpdatedAssetProviderRoots)
                ConvertHierarchy(root, messages);

        // If nothing of relevance was changed, just skip
        if (messages.Count == 0 && !_assetConverter.HasPendingChanges)
            return;

        SendOperationBatch(messages);
    }
}
