using BepuPhysics.Collidables;
using FrooxEngine;
using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AssetConversionManager
{
    public SceneConverter Converter { get; private set; }
    public Transform AssetsRoot { get; private set; }

    Dictionary<UnityEngine.Mesh, StaticMeshWrapper> _meshes = new Dictionary<UnityEngine.Mesh, StaticMeshWrapper>();

    Dictionary<UnityEngine.Material, ResoniteMaterialConverter> _materials = new Dictionary<UnityEngine.Material, ResoniteMaterialConverter>();
    Dictionary<UnityEngine.Material, FrooxEngine.IAssetProvider<FrooxEngine.Material>> _cachedMaterials = new Dictionary<UnityEngine.Material, IAssetProvider<FrooxEngine.Material>>();

    Queue<MeshConversionJob> _conversions = new Queue<MeshConversionJob>();

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

    public IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh)
    {
        if (!_meshes.TryGetValue(mesh, out var staticMesh))
        {
            // Provider doesn't exist yet, we need to create one and schedule conversion
            var root = new GameObject($"Mesh - {mesh.name}");
            root.transform.parent = AssetsRoot;

            staticMesh = root.AddComponent<FrooxEngine.StaticMeshWrapper>();

            staticMesh.Data.Enabled = true;
            staticMesh.Data.persistent = true;

            _meshes.Add(mesh, staticMesh);

            // Create & enqueue conversion job
            var job = new MeshConversionJob(mesh, staticMesh);

            _conversions.Enqueue(job);
        }

        return staticMesh.Data;
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
