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

public class PoiyomiXiexeConverter
{
    private FrooxEngine.XiexeToonMaterial Xiexe;
    private UnityEngine.Material Material;
    private IConversionContext Context;
    private PoiyomiAssetCache AssetCache;

    public PoiyomiXiexeConverter(FrooxEngine.XiexeToonMaterial Xiexe, UnityEngine.Material Material, IConversionContext Context, PoiyomiAssetCache AssetCache)
    {
        this.Xiexe = Xiexe;
        this.Material = Material;
        this.Context = Context;
        this.AssetCache = AssetCache;
    }

    public IAssetProvider<FrooxEngine.Material> UpdateConversion()
    {
        UpdateRenderingSettings();
        UpdateMainTexture();
        UpdateNormal();
        UpdateReflections();
        UpdateEmission();
        UpdateRim();
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
        Xiexe.NormalMap = Context.GetITexture2D(Material.GetTexture("_BumpMap"));
        Xiexe.NormalMapOffset = Material.GetTextureOffset("_BumpMap");
        Xiexe.NormalMapScale = Material.GetTextureScale("_BumpMap");
        Xiexe.NormalScale = Material.GetFloat("_BumpScale");
        Xiexe.NormalUV = (int)Material.GetFloat("_BumpMapUV");
    }

    private void UpdateReflections()
    {
        if (Material.GetFloat("_MochieBRDF") > 0)
        {
            Xiexe.MetallicGlossMap = Context.GetITexture2D(Material.GetTexture("_MochieMetallicMaps"));
            Xiexe.Metallic = Material.GetFloat("_MochieMetallicMultiplier");
            Xiexe.Glossiness = Material.GetFloat("_MochieRoughnessMultiplier");
            Xiexe.Reflectivity = Material.GetFloat("_MochieReflectionStrength");
            Xiexe.SpecularIntensity = 100 * Material.GetFloat("_MochieSpecularStrength");
            Xiexe.SpecularArea = 0.5f;
            return;
        }

        if (Material.GetFloat("_StylizedSpecular") > 0)
        {
            if (Material.GetFloat("_StylizedReflectionMode") == 0)
            {
                Xiexe.SpecularIntensity = 100 * Material.GetFloat("_StylizedSpecularStrength");
                Xiexe.SpecularArea = 0.5f;
                if (Xiexe.MetallicGlossMap != null)
                {
                    Xiexe.MetallicGlossMap = null;
                    Xiexe.Metallic = 0;
                    Xiexe.Glossiness = 0;
                    Xiexe.Reflectivity = 1;
                }
                return;
            } 
            if (Material.GetFloat("_StylizedReflectionMode") == 1 &&
                Material.GetFloat("_UseReflection") > 0)
            {            
                // LilToon-style reflections can replace the Poiyomi reflections
                Xiexe.MetallicGlossMap = Context.GetITexture2D(Material.GetTexture("_MetallicGlossMap"));
                Xiexe.Metallic = Material.GetFloat("_Metallic");
                Xiexe.Reflectivity = Material.GetFloat("_Reflectance");
                if (Material.GetFloat("_ApplySpecular") > 0)
                {
                    Xiexe.SpecularIntensity = 100 * Material.GetFloat("_Smoothness");
                    Xiexe.SpecularArea = 1 - Material.GetFloat("_SpecularBorder");                    
                } else
                {
                    Xiexe.SpecularIntensity = 0;
                }

                if (Material.GetFloat("_ApplyReflection") > 0)
                {                
                    Xiexe.Glossiness = Material.GetFloat("_Smoothness");
                } else
                {
                    Xiexe.Glossiness = 0;
                }
                return;
            }
        }

        Xiexe.SpecularIntensity = 0;
        if (Xiexe.MetallicGlossMap != null)
        {
            Xiexe.MetallicGlossMap = null;
            Xiexe.Metallic = 0;
            Xiexe.Glossiness = 0;
            Xiexe.Reflectivity = 1;
        }
    }

    private void UpdateEmission()
    {
        if (Material.GetFloat("_EnableEmission") > 0)
        {
            var color = Material.GetColor("_EmissionColor");
            var alpha = color.a;
            color *= Material.GetFloat("_EmissionStrength");
            color.a = alpha;
            Xiexe.EmissionColor = color.ToColorX_Auto();
            Xiexe.EmissionMap = Context.GetITexture2D(Material.GetTexture("_EmissionMap"));
            Xiexe.EmissionMapOffset = Material.GetTextureOffset("_EmissionMap");
            Xiexe.EmissionMapScale = Material.GetTextureScale("_EmissionMap");
            Xiexe.EmissionUV = (int)Material.GetFloat("_EmissionMapUV");
            return;
        }
        if (Xiexe.EmissionMap != null)
        {
            Xiexe.EmissionMap = null;
            Xiexe.EmissionColor = Color.black.ToColorX_sRGB();
        }
    }

    private void UpdateRim()
    {
        // TODO: Figure out what these two do. For now, use Xiexe's default
        Xiexe.RimAttenuationEffect = 1;
        Xiexe.RimThreshold = 0.1f;

        if (Material.GetFloat("_EnableRimLighting") == 0)
        {
            Xiexe.RimColor = Color.black.ToColorX_sRGB();
            Xiexe.RimIntensity = 0;
            return;
        }

        if (Material.GetFloat("_RimStyle") == 0)
        {
            // Poiyomi style
            Xiexe.RimColor = Material.GetColor("_RimLightColor").ToColorX_Auto();
            Xiexe.RimAlbedoTint = Material.GetFloat("_RimBaseColorMix");
            Xiexe.RimIntensity = Material.GetFloat("_RimBrightness");
            // TODO: Figure out if that formula makes sense (it looks close enough)
            Xiexe.RimRange = 1 - (Material.GetFloat("_RimWidth") * Material.GetFloat("_RimSharpness"));
            Xiexe.RimSharpness = 1 - Material.GetFloat("_RimSharpness");
            return;
        }
        else if (Material.GetFloat("_RimStyle") == 1)
        {
            // UTS2 style
            Xiexe.RimColor = Material.GetColor("_RimLightColor").ToColorX_Auto();
            Xiexe.RimAlbedoTint = 0; // No setting
            Xiexe.RimIntensity = 1; // No setting
            if (Material.GetFloat("_RimLight_FeatherOff") > 0)
            {
                Xiexe.RimSharpness = 0;
                Xiexe.RimRange = 0.2f * (1 - Material.GetFloat("_RimLight_Power"));
            }
            else
            {
                Xiexe.RimSharpness = 0.5f;
                Xiexe.RimRange = 1 - (0.8f * Material.GetFloat("_RimLight_Power"));
            }
            return;
        }
        else
        {
            // Liltoon style
            Xiexe.RimColor = Material.GetColor("_RimColor").ToColorX_Auto();
            Xiexe.RimAlbedoTint = Material.GetFloat("_RimMainStrength");
            Xiexe.RimIntensity = 1; // No setting
            // TODO: Figure these two formulas out. For now, use Xiexe's default
            Xiexe.RimSharpness = 0.1f;
            Xiexe.RimRange = 0.7f;
            return;
        }
    }

    private void UpdateMatcap()
    {
        if (Material.GetFloat("_MatcapEnable") > 0)
        {
            Xiexe.Matcap = Context.GetITexture2D(Material.GetTexture("_Matcap"));
            var matcapColor = Material.GetColor("_MatcapColor");
            var alpha = matcapColor.a;
            matcapColor *= Material.GetFloat("_MatcapIntensity");
            matcapColor.a = alpha;
            Xiexe.MatcapTint = matcapColor.ToColorX_Auto();
            return;
        }

        if (Xiexe.Matcap != null)
        {
            Xiexe.Matcap = null;
            Xiexe.MatcapTint = Color.black.ToColorX_sRGB();
        }
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
        if (Material.GetFloat("_ShadingEnabled") == 0)
        {
            Xiexe.ShadowRamp = null;
            return;
        }

        switch ((PoiyomiLightingMode)Material.GetFloat("_LightingMode"))
        {
            case PoiyomiLightingMode.TextureRamp:
                var ramp = Material.GetTexture("_ToonRamp");
                Xiexe.ShadowRamp = Context.GetITexture2D(ramp);
                if (ramp != null && ramp is UnityEngine.Texture2D originalRamp && ramp.isReadable)
                {
                    var color = Material.GetColor("_LightingShadowColor");
                    var strength = Material.GetFloat("_ShadowStrength");
                    if (color != Color.white || strength < 1)
                    {
                        if (AssetCache.ShadowRampTexture == null)
                        {
                            AssetCache.ShadowRampTexture = UnityEngine.Texture2D.Instantiate(originalRamp);
                            AssetCache.ShadowRampTexture.name = "PoiyomiConverter colorized shadow ramp";
                        }
                        var pixels = originalRamp.GetPixels();
                        for (int i = 0; i < pixels.Length; i++)
                        {
                            pixels[i] = pixels[i].grayscale * pixels[i] + (1 - pixels[i].grayscale) * pixels[i] * color;
                            pixels[i] = Color.white - strength * (Color.white - pixels[i]);
                        } 
                        AssetCache.ShadowRampTexture.SetPixels(pixels);
                        AssetCache.ShadowRampTexture.Apply();
                        Xiexe.ShadowRamp = Context.GetITexture2D(AssetCache.ShadowRampTexture);
                    }
                }
                break;
            case PoiyomiLightingMode.MultilayerMath:
            // TODO: Ramp or rim?
            case PoiyomiLightingMode.Wrapped:
            // TODO: Ramp or rim?
            case PoiyomiLightingMode.ShadeMap:
            // TODO: Ramp or rim?
            default:
                Xiexe.ShadowRamp = null;
                break;
        }
    }

    private void UpdateShadowRim()
    {
        if (Material.GetFloat("_ShadingEnabled") == 0)
        {
            // TODO: use actual values. For now, using default Xiexe values
            Xiexe.ShadowRim = Color.white.ToColorX_sRGB();
            Xiexe.ShadowRimThreshold = 1;
            Xiexe.ShadowRimRange = 0.7f;
            Xiexe.ShadowRimSharpness = 0.3f;
            return;
        }

        switch ((PoiyomiLightingMode)Material.GetFloat("_LightingMode"))
        {
            case PoiyomiLightingMode.MultilayerMath:
            // TODO
            case PoiyomiLightingMode.Wrapped:
            // TODO
            case PoiyomiLightingMode.ShadeMap:
            // TODO
            default:
                // TODO: use actual values. For now, using default Xiexe values
                Xiexe.ShadowRim = Color.white.ToColorX_sRGB();
                Xiexe.ShadowRimThreshold = 1;
                Xiexe.ShadowRimRange = 0.7f;
                Xiexe.ShadowRimSharpness = 0.3f;
                break;
        }
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
