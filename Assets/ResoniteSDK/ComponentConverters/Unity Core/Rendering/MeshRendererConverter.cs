using Renderite.Shared;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MeshRendererHelper
{
    public static void SetFrom(this FrooxEngine.MeshRenderer resonite, UnityEngine.MeshRenderer unity, IConversionContext context)
    {
        // We need to explicitly cast here to use the shared method for setting from the Renderer itself
        resonite.SetFrom((UnityEngine.Renderer)unity, context);

        // We need to get the matching mesh filter for this to get the mesh data
        var meshFilter = unity.transform.GetComponent<MeshFilter>();

        if (meshFilter == null)
            resonite.Mesh = null;
        else
            resonite.Mesh = context.GetMesh(meshFilter.sharedMesh);
    }

    public static void SetFrom(this FrooxEngine.MeshRenderer resonite, UnityEngine.Renderer unity, IConversionContext context)
    {
        // There's no base to set these from, so we can't use the shared one?
        resonite.persistent = true;
        resonite.Enabled = unity.enabled;

        switch (unity.shadowCastingMode)
        {
            case UnityEngine.Rendering.ShadowCastingMode.On:
                resonite.ShadowCastMode = Renderite.Shared.ShadowCastMode.On;
                break;

            case UnityEngine.Rendering.ShadowCastingMode.Off:
                resonite.ShadowCastMode = Renderite.Shared.ShadowCastMode.Off;
                break;

            case UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly:
                resonite.ShadowCastMode = Renderite.Shared.ShadowCastMode.ShadowOnly;
                break;

            case UnityEngine.Rendering.ShadowCastingMode.TwoSided:
                resonite.ShadowCastMode = Renderite.Shared.ShadowCastMode.DoubleSided;
                break;
        }

        switch (unity.motionVectorGenerationMode)
        {
            case MotionVectorGenerationMode.Object:
                resonite.MotionVectorMode = Renderite.Shared.MotionVectorMode.Object;
                break;

            case MotionVectorGenerationMode.Camera:
                resonite.MotionVectorMode = Renderite.Shared.MotionVectorMode.Camera;
                break;

            case MotionVectorGenerationMode.ForceNoMotion:
                resonite.MotionVectorMode = Renderite.Shared.MotionVectorMode.NoMotion;
                break;
        }

        resonite.SortingOrder = unity.sortingOrder;

        // Convert materials!
        var sourceMaterials = unity.sharedMaterials;

        for (int i = 0; i < sourceMaterials.Length; i++)
        {
            var converted = context.GetMaterial(sourceMaterials[i]);

            if (resonite.Materials.Count == i)
                resonite.Materials.Add(converted);
            else
                resonite.Materials[i] = converted;
        }

        // Remove excess material slots
        while (resonite.Materials.Count > sourceMaterials.Length)
            resonite.Materials.RemoveAt(resonite.Materials.Count - 1);
    }
}

public class MeshRendererConverter : ResoniteSingleComponentConverter<MeshRenderer, FrooxEngine.MeshRendererWrapper>
{
    protected override void UpdateConversion(MeshRenderer target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }
}
