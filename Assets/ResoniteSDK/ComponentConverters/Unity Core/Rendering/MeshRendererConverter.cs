using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace FrooxEngine
{
    public partial class MeshRenderer
    { 
        public void SetFrom(UnityEngine.MeshRenderer renderer, IConversionContext context)
        {
            // There's no base to set these from, so we can't use the shared one?
            persistent = true;
            Enabled = renderer.enabled;

            switch(renderer.shadowCastingMode)
            {
                case UnityEngine.Rendering.ShadowCastingMode.On:
                    ShadowCastMode = Renderite.Shared.ShadowCastMode.On;
                    break;

                case UnityEngine.Rendering.ShadowCastingMode.Off:
                    ShadowCastMode = Renderite.Shared.ShadowCastMode.Off;
                    break;

                case UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly:
                    ShadowCastMode = Renderite.Shared.ShadowCastMode.ShadowOnly;
                    break;

                case UnityEngine.Rendering.ShadowCastingMode.TwoSided:
                    ShadowCastMode = Renderite.Shared.ShadowCastMode.DoubleSided;
                    break;
            }

            switch(renderer.motionVectorGenerationMode)
            {
                case MotionVectorGenerationMode.Object:
                    MotionVectorMode = Renderite.Shared.MotionVectorMode.Object;
                    break;

                case MotionVectorGenerationMode.Camera:
                    MotionVectorMode = Renderite.Shared.MotionVectorMode.Camera;
                    break;

                case MotionVectorGenerationMode.ForceNoMotion:
                    MotionVectorMode = Renderite.Shared.MotionVectorMode.NoMotion;
                    break;
            }

            SortingOrder = renderer.sortingOrder;

            // We need to get the matching mesh filter for this to get the mesh data
            var meshFilter = renderer.transform.GetComponent<MeshFilter>();

            if (meshFilter == null)
                Mesh = null;
            else
                Mesh = context.GetMesh(meshFilter.sharedMesh);

            // Convert materials!
            if (Materials == null)
                Materials = new List<IAssetProvider<Material>>();

            var sourceMaterials = renderer.sharedMaterials;

            for(int i = 0; i < sourceMaterials.Length; i++)
            {
                var converted = context.GetMaterial(sourceMaterials[i]);

                if (Materials.Count == i)
                    Materials.Add(converted);
                else
                    Materials[i] = converted;
            }

            // Remove excess material slots
            while (Materials.Count > sourceMaterials.Length)
                Materials.RemoveAt(Materials.Count - 1);
        }
    }
}

public class MeshRendererConverter : ResoniteSingleComponentConverter<MeshRenderer, FrooxEngine.MeshRendererWrapper>
{
    protected override void UpdateConversion(MeshRenderer target, IConversionContext context)
    {
        Binding.Data.SetFrom(target, context);
    }
}
