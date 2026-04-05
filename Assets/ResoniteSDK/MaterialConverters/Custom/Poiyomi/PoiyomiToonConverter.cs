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

public class PoiyomiToonConverter
{
    private FrooxEngine.XiexeToonMaterial Xiexe;

    private UnityEngine.Material Material;
    private IConversionContext Context;

    public PoiyomiToonConverter(FrooxEngine.XiexeToonMaterial Xiexe, UnityEngine.Material Material, IConversionContext Context)
    {
        this.Xiexe = Xiexe;
        this.Material = Material;
        this.Context = Context;
    }

    public IAssetProvider<FrooxEngine.Material> UpdateConversion()
    {
        UpdateRenderingSettings();
        UpdateMainTexture();
        UpdateNormal();
        UpdateMetallicGloss();
        UpdateEmission();
        UpdateRim();
        UpdateSpecular();
        UpdateMatcap();
        UpdateOcclusion();
        UpdateOutline();
        UpdateShadowRamp();
        UpdateShadowRim();
        UpdateThickness();
        UpdateSubsurface();

        return Xiexe;
    }

    private void UpdateRenderingSettings()
    {
        Xiexe.BlendMode = PoiyomiBlendModeComputer.FromPoiyomi(Material);
        Xiexe.ZWrite = Material.GetFloat("_ZWrite") > 0 ? ZWrite.On : ZWrite.Off;
        Xiexe.AlphaClip = Material.GetFloat("_Cutoff");
        Xiexe.OffsetFactor = Material.GetFloat("_OffsetFactor");
        Xiexe.OffsetUnits = Material.GetFloat("_OffsetUnits");
        Xiexe.Culling = (Culling)(UnityEngine.Rendering.CullMode)Material.GetFloat("_Cull");
        Xiexe.ColorMask = (ColorMask)Material.GetFloat("_ColorMask");
        Xiexe.RenderQueue = Material.renderQueue;
    }

    private void UpdateMainTexture()
    {
        Xiexe.Color = Material.color.ToColorX_sRGB();
        Xiexe.MainTexture = Context.GetITexture2D(Material.mainTexture);
        Xiexe.MainTextureOffset = Material.mainTextureOffset;
        Xiexe.MainTextureScale = Material.mainTextureScale;
        Xiexe.AlbedoUV = (int)Material.GetFloat("_MainTexUV");

        if (Material.GetFloat("_MainColorAdjustToggle") > 0)
        {
            Xiexe.Saturation = 1 + Material.GetFloat("_Saturation");
        }
        else
        {
            Xiexe.Saturation = 1;
        }

        if (Material.GetFloat("_MainVertexColoringEnabled") > 0)
        {
            // Poiyomi uses float weights 0-1 to indicate how much influence
            // the vertex colors have on the coloring of the final render.
            // Xiexe only supports booleans here, so we use a cutoff at 0.5.
            Xiexe.UseVertexColors = Material.GetFloat("_MainVertexColoring") >= 0.5;
            if (Material.GetFloat("_MainVertexColoringLinearSpace") > 0)
            {
                Xiexe.VertexColorInterpolationSpace = Renderite.Shared.ColorProfile.Linear;
            }
            else if (Material.GetFloat("_MainUseVertexColorAlpha") >= 0.5)
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

    private void UpdateNormal()
    {
        // TODO
    }
    private void UpdateMetallicGloss()
    {
        // TODO
    }
    private void UpdateEmission()
    {
        if (Material.GetFloat("_EnableEmission") > 0)
        {
            Xiexe.EmissionColor = Material.GetColor("_EmissionColor").ToColorX_Auto();
            Xiexe.EmissionMap = Context.GetITexture2D(Material.GetTexture("_EmissionMap"));
            Xiexe.EmissionMapOffset = Material.GetTextureOffset("_EmissionMap");
            Xiexe.EmissionMapScale = Material.GetTextureScale("_EmissionMap");
            Xiexe.EmissionUV = (int)Material.GetFloat("_EmissionMapUV");
            return;
        }
        for (int i = 1; i <= 3; i++)
        {
            if (Material.GetFloat($"_EnableEmission{i}") > 0)
            {
                Xiexe.EmissionColor = Material.GetColor($"_EmissionColor{i}").ToColorX_Auto();
                Xiexe.EmissionMap = Context.GetITexture2D(Material.GetTexture($"_EmissionMap{i}"));
                Xiexe.EmissionMapOffset = Material.GetTextureOffset($"_EmissionMap{i}");
                Xiexe.EmissionMapScale = Material.GetTextureScale($"_EmissionMap{i}");
                Xiexe.EmissionUV = (int)Material.GetFloat($"_EmissionMap{i}UV");
                return;
            }
        }
        if (Xiexe.EmissionMap != null)
        {
            Xiexe.EmissionMap = null;
            Xiexe.EmissionColor = Color.black.ToColorX_sRGB();
        }
    }

    private void UpdateRim()
    {
        // TODO
    }
    private void UpdateSpecular()
    {
        // TODO
    }
    private void UpdateMatcap()
    {
        // TODO
    }
    private void UpdateOcclusion()
    {
        // TODO
    }
    private void UpdateOutline()
    {
        // TODO
    }
    private void UpdateShadowRamp()
    {
        // TODO
    }
    private void UpdateShadowRim()
    {
        // TODO
        Xiexe.ShadowRim = Color.white.ToColorX_sRGB();
    }
    private void UpdateThickness()
    {
        // TODO
    }
    private void UpdateSubsurface()
    {
        // TODO
    }
}
