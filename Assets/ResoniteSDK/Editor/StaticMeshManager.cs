using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class StaticMeshManager
{
    public const string STATICS_ROOT_NAME = "__StaticMeshes";

    public Transform Root
    {
        get
        {
            EnsureRoot();

            return _root;
        }
    }

    Transform _root;

    [Serializable]
    struct StaticMeshData
    {
        public ResRef<FrooxEngine.MeshRenderer> renderer;
    }

    [SerializeField]
    Dictionary<UnityEngine.Mesh, StaticMeshData> _staticMeshes = new Dictionary<Mesh, StaticMeshData>();

    public void EnsureRoot()
    {
        if (_root != null)
            return;

        var roots = SceneManager.GetActiveScene().GetRootGameObjects();

        _root = roots.FirstOrDefault(r => r.name == STATICS_ROOT_NAME)?.transform;

        if (_root == null)
            _root = (new GameObject(STATICS_ROOT_NAME)).transform; // Create new root
    }

    public void NotifyOfStaticMesh(UnityEngine.Mesh combinedMesh, int materialStartIndex, UnityEngine.Material[] materials,
        IConversionContext context)
    {
        if(!_staticMeshes.TryGetValue(combinedMesh, out var data))
        {
            var go = new GameObject(combinedMesh.name);
            go.transform.parent = Root;

            data.renderer = go.AddResoniteComponent<FrooxEngine.MeshRenderer>();
            data.renderer.Binding.Mesh = context.GetMesh(combinedMesh);

            _staticMeshes.Add(combinedMesh, data);
        }

        var binding = data.renderer.Binding;

        // Ensure the binding has expected number of materials to match the submeshes
        while (binding.Materials.Count < combinedMesh.subMeshCount)
            binding.Materials.Add();

        while (binding.Materials.Count > combinedMesh.subMeshCount)
            binding.Materials.RemoveAt(binding.Materials.Count - 1);

        // Assign all the materials of this batch
        for (int i = 0; i < materials.Length; i++)
            binding.Materials[materialStartIndex + i] = context.GetMaterial(materials[i]);
    }
}
