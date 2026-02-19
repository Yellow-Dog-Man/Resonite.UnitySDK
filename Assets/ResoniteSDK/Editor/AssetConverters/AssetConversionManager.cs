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

    Dictionary<UnityEngine.Mesh, StaticMeshWrapper> _meshes = new Dictionary<UnityEngine.Mesh, StaticMeshWrapper>();
    Dictionary<UnityEngine.Texture2D, StaticTexture2DWrapper> _textures = new Dictionary<UnityEngine.Texture2D, StaticTexture2DWrapper>();
    Dictionary<UnityEngine.Cubemap, StaticCubemapWrapper> _cubemaps = new Dictionary<UnityEngine.Cubemap, StaticCubemapWrapper>();

    Dictionary<UnityEngine.Material, ResoniteMaterialConverter> _materials = new Dictionary<UnityEngine.Material, ResoniteMaterialConverter>();
    Dictionary<UnityEngine.Material, FrooxEngine.IAssetProvider<FrooxEngine.Material>> _cachedMaterials = new Dictionary<UnityEngine.Material, IAssetProvider<FrooxEngine.Material>>();

    Queue<AssetConversionJob> _conversions = new Queue<AssetConversionJob>();

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
    }

    public IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh) =>
        GetAsset<StaticMesh, StaticMeshWrapper, UnityEngine.Mesh, FrooxEngine.Mesh>(
            mesh, mesh.name, _meshes, (provider) => new MeshConversionJob(mesh, provider));

    public IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D mesh) =>
        GetAsset<StaticTexture2D, StaticTexture2DWrapper, UnityEngine.Texture2D, FrooxEngine.Texture2D>(
            mesh, mesh.name, _textures, (provider) => new Texture2DConversionJob(mesh, provider));

    public IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap mesh) =>
        GetAsset<StaticCubemap, StaticCubemapWrapper, UnityEngine.Cubemap, FrooxEngine.Cubemap>(
            mesh, mesh.name, _cubemaps, (provider) => new CubemapConversionJob(mesh, provider));

    TProvider GetAsset<TProvider, TWrapper, TUnity, TResonite>(TUnity unity, 
        string name, Dictionary<TUnity, TWrapper> assets,
        Func<TWrapper, AssetConversionJob> conversionJobGenerator)
        where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
        where TWrapper : ResoniteComponent<TProvider>
        where TResonite : FrooxEngine.IAsset
    {
        if(!assets.TryGetValue(unity, out var wrapper))
        {
            // Provider doesn't exist yet, we need to create one and schedule conversion
            var root = new GameObject($"{typeof(TResonite).Name} - {name}");
            root.transform.parent = AssetsRoot;

            wrapper = root.AddComponent<TWrapper>();

            wrapper.Data.Enabled = true;
            wrapper.Data.persistent = true;

            assets.Add(unity, wrapper);

            // Create & enqueue conversion job
            var job = conversionJobGenerator(wrapper);

            _conversions.Enqueue(job);
        }

        return wrapper.Data;
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
        while(_conversions.Count > 0)
        {
            var job = _conversions.Dequeue();
            job.Convert(this, link); 
        }
    }
}
