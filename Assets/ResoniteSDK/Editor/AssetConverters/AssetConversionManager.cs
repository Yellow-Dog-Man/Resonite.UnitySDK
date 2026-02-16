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

    Queue<MeshConversionJob> _conversions = new Queue<MeshConversionJob>();

    public AssetConversionManager(SceneConverter converter)
    {
        Converter = converter;
        AssetsRoot = (new GameObject("Unity Assets")).transform;
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
        // TODO!!! Actual conversion
        var root = new GameObject($"Material - {material.name}");
        root.transform.parent = AssetsRoot;

        var pbs = root.AddComponent<PBS_MetallicWrapper>();

        pbs.Data.AlbedoColor = new ColorX(Color.white);
        pbs.Data.Enabled = true;
        pbs.Data.persistent = true;

        return pbs.Data;
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
