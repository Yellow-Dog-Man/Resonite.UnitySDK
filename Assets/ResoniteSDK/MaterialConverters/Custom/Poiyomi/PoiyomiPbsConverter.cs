using FrooxEngine;
using UnityEngine;

// This converter is a prototype meant to convert materials using
// the Poiyomi Toon family of shaders into a Resonite PBS Material.
//
// Poiyomi Toon shaders are freely available under the MIT license.
// Documentation and download links are available at https://www.poiyomi.com/
//
// However, this converter only uses the material's named properties.
// So neither the Poiyomi Toon shaders nor its source code
// need to be available in the Unity project for the converter to work.

public class PoiyomiPbsConverter
{
    private FrooxEngine.PBS_Metallic Pbs;

    private UnityEngine.Material Material;
    private IConversionContext Context;

    public PoiyomiPbsConverter(FrooxEngine.PBS_Metallic Pbs, UnityEngine.Material Material, IConversionContext Context)
    {
        this.Pbs = Pbs;
        this.Material = Material;
        this.Context = Context;
    }

    public IAssetProvider<FrooxEngine.Material> UpdateConversion()
    {
        UpdateRenderingSettings();
        UpdateMainTexture();
        UpdateEmission();
        UpdateNormal();
        UpdateHeight();
        UpdateOcclusion();
        UpdateDetail();
        UpdateMetallicSmoothness();
        return Pbs;
    }

    private void UpdateRenderingSettings()
    {
        Pbs.BlendMode = PoiyomiBlendModeComputer.FromPoiyomi(Material);
        Pbs.AlphaCutoff = Material.GetFloat("_Cutoff");
        Pbs.OffsetFactor = Material.GetFloat("_OffsetFactor");
        Pbs.OffsetUnits = Material.GetFloat("_OffsetUnits");
        Pbs.RenderQueue = Material.renderQueue;
    }

    private void UpdateMainTexture()
    {
        Pbs.AlbedoColor = Material.color.ToColorX_sRGB();
        Pbs.AlbedoTexture = Context.GetITexture2D(Material.mainTexture);
        Pbs.TextureOffset = Material.mainTextureOffset;
        Pbs.TextureScale = Material.mainTextureScale;
    }

    private void UpdateEmission()
    {
        if (Material.GetFloat("_EnableEmission") > 0)
        {
            Color emissiveColor = Material.GetColor("_EmissionColor");
            emissiveColor *= Material.GetFloat("_EmissionStrength");
            Pbs.EmissiveColor = emissiveColor.ToColorX_Auto();
            Pbs.EmissiveMap = Context.GetITexture2D(Material.GetTexture("_EmissionMap"));
            return;
        }
        if (Pbs.EmissiveMap != null)
        {
            Pbs.EmissiveMap = null;
            Pbs.EmissiveColor = Color.black.ToColorX_sRGB();
        }
    }

    private void UpdateNormal()
    {
        Pbs.NormalMap = Context.GetITexture2D(Material.GetTexture("_BumpMap"));
        Pbs.NormalScale = Material.GetFloat("_BumpScale");
    }

    private void UpdateHeight()
    {
        if (Material.GetFloat("_VertexManipulationsEnabled") == 0)
        {
            if (Pbs.HeightMap != null)
            {
                Pbs.HeightMap = null;
                Pbs.HeightScale = 0;
            }
            return;
        }

        Pbs.HeightMap = Context.GetITexture2D(Material.GetTexture("_VertexManipulationHeightMask"));
        Pbs.HeightScale = - Material.GetFloat("_VertexManipulationHeight");
    }

    private void UpdateOcclusion()
    {
        Pbs.OcclusionMap = Context.GetITexture2D(Material.GetTexture("_LightingAOMaps"));
    }

    private void UpdateDetail()
    {
        if (Material.GetFloat("_DetailEnabled") == 0)
        {
            Pbs.DetailAlbedoTexture = null;
            Pbs.DetailNormalMap = null;
            return;
        }
        Pbs.DetailAlbedoTexture = Context.GetITexture2D(Material.GetTexture("_DetailTex"));
        Pbs.DetailTextureOffset = Material.GetTextureOffset("_DetailTex");
        Pbs.DetailTextureScale = Material.GetTextureScale("_DetailTex");
        Pbs.DetailNormalMap = Context.GetITexture2D(Material.GetTexture("_DetailNormalMap"));
        Pbs.DetailNormalScale = Material.GetFloat("_DetailNormalMapScale");
    }

    private void UpdateMetallicSmoothness()
    {
        if (Material.GetFloat("_MochieBRDF") > 0)
        {
            Pbs.MetallicMap = Context.GetITexture2D(Material.GetTexture("_MochieMetallicMaps"));
            Pbs.Metallic = Material.GetFloat("_MochieMetallicMultiplier");
            Pbs.Smoothness = Material.GetFloat("_MochieRoughnessMultiplier");
            return;
        }

        if (Pbs.MetallicMap != null)
        {
            Pbs.MetallicMap = null;
            Pbs.Metallic = 0;
            Pbs.Smoothness = 0;
        }
    }
}
