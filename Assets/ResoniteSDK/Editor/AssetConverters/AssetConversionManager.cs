using BepuPhysics.Collidables;
using FrooxEngine;
using FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AssetConversionManager
{
    public SceneConverter Converter { get; private set; }
    public Transform AssetsRoot { get; private set; }

    Dictionary<UnityEngine.Mesh, MeshConverter> _meshes = new Dictionary<UnityEngine.Mesh, MeshConverter>();
    Dictionary<UnityEngine.Texture2D, Texture2DConverter> _textures = new Dictionary<UnityEngine.Texture2D, Texture2DConverter>();
    Dictionary<UnityEngine.Cubemap, CubemapConverter> _cubemaps = new Dictionary<UnityEngine.Cubemap, CubemapConverter>();
    Dictionary<UnityEngine.AudioClip, AudioClipConverter> _audioClips = new Dictionary<UnityEngine.AudioClip, AudioClipConverter>();

    Dictionary<UnityEngine.Material, ResoniteMaterialConverter> _materials = new Dictionary<UnityEngine.Material, ResoniteMaterialConverter>();
    Dictionary<UnityEngine.Material, FrooxEngine.IAssetProvider<FrooxEngine.Material>> _cachedMaterials = new Dictionary<UnityEngine.Material, IAssetProvider<FrooxEngine.Material>>();

    HashSet<AssetConverter> _checkedConverters = new HashSet<AssetConverter>();
    Queue<AssetConverter> _scheduledConversions = new Queue<AssetConverter>();

    public AssetConversionManager(SceneConverter converter)
    {
        Converter = converter;
        AssetsRoot = (new GameObject("Unity Assets")).transform;
    }

    public void BeginConversion()
    {
        // Clear all the cached materials from previous conversion. Unlike other asset types, materials can
        // change between conversions - e.g. their parameters are updated, so we want to re-run the conversion
        // every time.
        _cachedMaterials.Clear();

        // Since we're running a new conversion batch, we need to re-check all the converters again, because the assets
        // might have changed.
        _checkedConverters.Clear();
    }

    public IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh) =>
        GetAsset<StaticMesh, StaticMeshWrapper, UnityEngine.Mesh, FrooxEngine.Mesh, MeshConverter>(
            mesh, _meshes, (m, t) => new MeshConverter(m, t));

    public IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D texture) =>
        GetAsset<StaticTexture2D, StaticTexture2DWrapper, UnityEngine.Texture2D, FrooxEngine.Texture2D, Texture2DConverter>(
            texture, _textures, (m, t) => new Texture2DConverter(m, t));

    public IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap cubemap) =>
        GetAsset<StaticCubemap, StaticCubemapWrapper, UnityEngine.Cubemap, FrooxEngine.Cubemap, CubemapConverter>(
            cubemap, _cubemaps, (m, t) => new CubemapConverter(m, t));

    public IAssetProvider<FrooxEngine.AudioClip> GetAudioClip(UnityEngine.AudioClip audioClip) =>
        GetAsset<StaticAudioClip, StaticAudioClipWrapper, UnityEngine.AudioClip, FrooxEngine.AudioClip, AudioClipConverter>(
            audioClip, _audioClips, (m, t) => new AudioClipConverter(m, t));

    TProvider GetAsset<TProvider, TWrapper, TUnity, TResonite, TConverter>(TUnity unity,
        Dictionary<TUnity, TConverter> converters,
        Func<TUnity, Transform, TConverter> conversionJobGenerator)
        where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
        where TWrapper : ResoniteComponent<TProvider>
        where TResonite : FrooxEngine.IAsset
        where TConverter : AssetConverter<TWrapper, TProvider, TUnity, TResonite>
        where TUnity : UnityEngine.Object
    {
        if (unity == null)
            throw new ArgumentNullException(nameof(unity));

        bool needsToConvert = false;

        if (!converters.TryGetValue(unity, out var converter))
        {
            // There's no active converter for this, so create one
            converter = conversionJobGenerator(unity, AssetsRoot);

            // Since it's brand new it needs to be converted for the first time
            needsToConvert = true;

            converters.Add(unity, converter);
        }
        else if (_checkedConverters.Add(converter) && converter.HasAssetChanged())
        {
            // We haven't checked this conversion yet for updates and the asset has changed
            // so we need to run the conversion again to update the data
            needsToConvert = true;
        }

        if (needsToConvert)
            _scheduledConversions.Enqueue(converter);

        return converter.Provider.Data;
    }

    public IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material)
    {
        // Check if there's already conversion and it's bee updated
        if (_cachedMaterials.TryGetValue(material, out var provider))
            return provider;

        // Check if there's an active converter
        if (!_materials.TryGetValue(material, out var converter))
        {
            // There's no converter! Try to find one
            var converterType = MaterialConverterRepository.TryGetConverter(material);

            if(converterType == null)
            {
                Debug.LogWarning($"Unable to convert material {material}");

                // Set it to null. We still want to cache null converted material so we're not doing
                // this whole search & evaluation every single time this material is requested
                converter = null;
            }
            else
            {
                // Create the conversion
                var root = new GameObject($"Material - {material.name}");
                root.transform.parent = AssetsRoot;

                // Attach the converter itself
                converter = (ResoniteMaterialConverter)root.AddComponent(converterType);

                // We do want to store the converter across conversions - they will update existing material
                // in place in most cases, so we don't want to keep making new ones all the time
                _materials.Add(material, converter);
            }
        }

        // Update the conversion and get the latest material provider
        // This is important, because converter can change the actual material instance depending on the
        // properties provided. The converter can all be null, hence the null check
        provider = converter?.UpdateConversion(material, Converter);

        // Cache it for this run - the same material only needs to be converted/updated once per run
        _cachedMaterials.Add(material, provider);

        return provider;
    }

    public void ProcessConversions(LinkInterface link)
    {
        while(_scheduledConversions.Count > 0)
        {
            var job = _scheduledConversions.Dequeue();
            job.Convert(this, link); 
        }
    }
}
