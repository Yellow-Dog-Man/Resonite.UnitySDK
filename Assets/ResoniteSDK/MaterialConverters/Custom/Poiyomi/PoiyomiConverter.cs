using FrooxEngine;
using UnityEngine;

// This converter is a prototype meant to convert materials using
// the Poiyomi Toon family of shaders into a Resonite XiexeToonMaterial.
//
// Poiyomi Toon shaders are freely available under the MIT license.
// Documentation and download links are available at https://www.poiyomi.com/
//
// However, this converter only uses the material's named properties.
// So neither the Poiyomi Toon shaders nor its source code
// need to be available in the Unity project for the converter to work.
[MaterialConverter(true)]
public class PoiyomiConverter : ResoniteMaterialConverter
{
    public FrooxEngine.XiexeToonMaterialWrapper XiexeComponent;

    private FrooxEngine.XiexeToonMaterial Xiexe
    {
        get => XiexeComponent?.Data;
    }

    public static float? EvaluateHeuristicConversion(UnityEngine.Material material)
    {
        if (!material.shader.name.StartsWith(".poiyomi/"))
        {
            return null;
        }
        // TODO: Maybe add more robusts checks, i.e. on the shader's version number or on its "variants"?
        return 1;
    }

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (XiexeComponent == null)
        {
            XiexeComponent = gameObject.AddComponent<FrooxEngine.XiexeToonMaterialWrapper>();
        }

        UpdateRenderingSettings(material, context);
        UpdateMainTexture(material, context);
        UpdateNormal(material, context);
        UpdateMetallicGloss(material, context);
        UpdateEmission(material, context);
        UpdateRim(material, context);
        UpdateSpecular(material, context);
        UpdateMatcap(material, context);
        UpdateOcclusion(material, context);
        UpdateOutline(material, context);
        UpdateShadowRamp(material, context);
        UpdateShadowRim(material, context);
        UpdateThickness(material, context);
        UpdateSubsurface(material, context);

        return Xiexe;
    }

    private void UpdateRenderingSettings(UnityEngine.Material material, IConversionContext context)
    {
        // When should we use ZWrite "Auto", if at all?
        Xiexe.ZWrite = material.GetFloat("_ZWrite") > 0 ? ZWrite.On : ZWrite.Off;
        Xiexe.AlphaClip = material.GetFloat("_Cutoff");
        Xiexe.OffsetFactor = material.GetFloat("_OffsetFactor");
        Xiexe.OffsetUnits = material.GetFloat("_OffsetUnits");
        Xiexe.Culling = (Culling)(UnityEngine.Rendering.CullMode)material.GetFloat("_Cull");
        Xiexe.ColorMask = (ColorMask)material.GetFloat("_ColorMask");
        Xiexe.RenderQueue = material.renderQueue;

        if (material.GetFloat("_AlphaForceOpaque") > 0)
        {
            Xiexe.BlendMode = BlendMode.Opaque;
        }
        else if (
            material.GetFloat("_AlphaToCoverage") > 0 ||
            material.GetFloat("_AlphaDithering") > 0 ||
            material.GetFloat("_AlphaDistanceFade") > 0
        )
        {
            // TODO: Figure out how Poiyomi's advanced alpha parameters work exactly,
            // this is most likely not correct
            Xiexe.BlendMode = BlendMode.Alpha;
        }
        else
        {
            Xiexe.BlendMode = BlendMode.Cutout;
        }
    }

    private void UpdateMainTexture(UnityEngine.Material material, IConversionContext context)
    {
        Xiexe.Color = material.color.ToColorX_sRGB();
        Xiexe.MainTexture = context.GetITexture2D(material.mainTexture);
        Xiexe.MainTextureOffset = material.mainTextureOffset;
        Xiexe.MainTextureScale = material.mainTextureScale;
        Xiexe.AlbedoUV = (int) material.GetFloat("_MainTexUV");
        Xiexe.Saturation = material.GetFloat("_Saturation");
        if (material.GetFloat("_MainVertexColoringEnabled") > 0)
        {
            // Poiyomi uses float weights 0-1 to indicate how much influence
            // the vertex colors have on the coloring of the final render.
            // Xiexe only supports booleans here, so we use a cutoff at 0.5.
            Xiexe.UseVertexColors = material.GetFloat("_MainVertexColoring") >= 0.5;
            if (material.GetFloat("_MainVertexColoringLinearSpace") > 0)
            {
                Xiexe.VertexColorInterpolationSpace = Renderite.Shared.ColorProfile.Linear;
            }
            else if (material.GetFloat("_MainUseVertexColorAlpha") >= 0.5)
            {
                Xiexe.VertexColorInterpolationSpace = Renderite.Shared.ColorProfile.sRGBAlpha;
            }
            else
            {
                Xiexe.VertexColorInterpolationSpace = Renderite.Shared.ColorProfile.sRGB;
            }
        }
        else
        {
            Xiexe.UseVertexColors = false;
        }
    }

    private void UpdateNormal(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateMetallicGloss(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateEmission(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateRim(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateSpecular(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateMatcap(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateOcclusion(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateOutline(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateShadowRamp(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateShadowRim(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateThickness(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
    private void UpdateSubsurface(UnityEngine.Material material, IConversionContext context)
    {
        // TODO
    }
}