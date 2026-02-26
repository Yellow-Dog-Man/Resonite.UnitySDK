using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkinnedMeshRendererHelper
{
    public static void SetFrom(this FrooxEngine.SkinnedMeshRenderer resonite, UnityEngine.SkinnedMeshRenderer unity, IConversionContext context)
    {
        // This will assign all the shared stuff for the MeshRenderer
        // Shadow casting, materials and so on, EXCEPT the mesh and skinned data
        resonite.SetFrom((UnityEngine.Renderer)unity, context);

        var mesh = unity.sharedMesh;

        // SkinnedMeshRenderer doesn't use mesh filter, we just get it directly
        resonite.Mesh = context.GetMesh(mesh);

        // If the mesh isn't assigned, we can't actually calculate these properly
        if (mesh == null)
            return;

        // Blendshapes
        var blendshapeCount = mesh.blendShapeCount;

        for (int b = 0; b < blendshapeCount; b++)
        {
            var endFrameWeight = mesh.GetBlendShapeFrameWeight(b, mesh.GetBlendShapeFrameCount(b) - 1);

            // Resonite uses normalized blendshape frame weight range between 0...1
            // We need to scale the weight to the actual frame of the mesh, otherwise the strength will be wrong
            var weight = unity.GetBlendShapeWeight(b) / endFrameWeight;

            if (resonite.BlendShapeWeights.Count == b)
                resonite.BlendShapeWeights.Add(weight);
            else
                resonite.BlendShapeWeights[b] = weight;
        }

        while (resonite.BlendShapeWeights.Count > blendshapeCount)
            resonite.BlendShapeWeights.RemoveAt(resonite.BlendShapeWeights.Count - 1);

        // Bones
        for (int b = 0; b < unity.bones.Length; b++)
        {
            var bone = unity.bones[b];
            var slot = bone.GetSlot();

            if (resonite.Bones.Count == b)
                resonite.Bones.Add(slot);
            else
                resonite.Bones[b] = slot;
        }

        while (resonite.Bones.Count > unity.bones.Length)
            resonite.Bones.RemoveAt(resonite.Bones.Count - 1);
    }
}

public class SkinnedMeshRendererConverter : ResoniteSingleComponentConverter<SkinnedMeshRenderer, FrooxEngine.SkinnedMeshRendererWrapper>
{
    protected override void UpdateConversion(SkinnedMeshRenderer target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }
}
