using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class SkinnedMeshRenderer
    {
        public void SetFrom(UnityEngine.SkinnedMeshRenderer renderer, IConversionContext context)
        {
            // This will assign all the shared stuff for the MeshRenderer
            // Shadow casting, materials and so on, EXCEPT the mesh and skinned data
            base.SetFrom((UnityEngine.Renderer)renderer, context);

            var mesh = renderer.sharedMesh;

            // SkinnedMeshRenderer doesn't use mesh filter, we just get it directly
            Mesh = context.GetMesh(mesh);

            // If the mesh isn't assigned, we can't actually calculate these properly
            if (mesh == null)
                return;

            // Blendshapes
            var blendshapeCount = mesh.blendShapeCount;

            if (BlendShapeWeights == null)
                BlendShapeWeights = new List<float>();

            for(int b = 0; b < blendshapeCount; b++)
            {
                var endFrameWeight = mesh.GetBlendShapeFrameWeight(b, mesh.GetBlendShapeFrameCount(b) - 1);

                // Resonite uses normalized blendshape frame weight range between 0...1
                // We need to scale the weight to the actual frame of the mesh, otherwise the strength will be wrong
                var weight = renderer.GetBlendShapeWeight(b) / endFrameWeight;

                if (BlendShapeWeights.Count == b)
                    BlendShapeWeights.Add(weight);
                else
                    BlendShapeWeights[b] = weight;
            }

            while (BlendShapeWeights.Count > blendshapeCount)
                BlendShapeWeights.RemoveAt(BlendShapeWeights.Count - 1);

            // Bones
            if(Bones == null)
                Bones = new List<Slot>();

            for(int b = 0; b < renderer.bones.Length; b++)
            {
                var bone = renderer.bones[b];
                var slot = bone.GetSlot();

                if (Bones.Count == b)
                    Bones.Add(slot);
                else
                    Bones[b] = slot;
            }

            while (Bones.Count > renderer.bones.Length)
                Bones.RemoveAt(Bones.Count - 1);
        }
    }
}

public class SkinnedMeshRendererConverter : ResoniteSingleComponentConverter<SkinnedMeshRenderer, FrooxEngine.SkinnedMeshRendererWrapper>
{
    protected override void UpdateConversion(SkinnedMeshRenderer target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }
}
