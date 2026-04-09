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
            Xiexe.MetallicGlossMapOffset = Material.GetTextureOffset("_MochieMetallicMaps");
            Xiexe.MetallicGlossMapScale = Material.GetTextureScale("_MochieMetallicMaps");
            Xiexe.MetallicUV = (int)Material.GetFloat("_MochieMetallicMapsUV");
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
                Xiexe.MetallicGlossMapOffset = Material.GetTextureOffset("_MetallicGlossMap");
                Xiexe.MetallicGlossMapScale = Material.GetTextureScale("_MetallicGlossMap");
                Xiexe.MetallicUV = 0;
                Xiexe.Metallic = Material.GetFloat("_Metallic");
                Xiexe.Reflectivity = Material.GetFloat("_Reflectance");
                if (Material.GetFloat("_ApplySpecular") > 0)
                {
                    Xiexe.SpecularIntensity = 100 * Material.GetFloat("_Smoothness");
                    Xiexe.SpecularArea = 1 - Material.GetFloat("_SpecularBorder");
                }
                else
                {
                    Xiexe.SpecularIntensity = 0;
                }

                if (Material.GetFloat("_ApplyReflection") > 0)
                {
                    Xiexe.Glossiness = Material.GetFloat("_Smoothness");
                }
                else
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
            var emissionMap = Material.GetTexture("_EmissionMap");
            if (emissionMap != null)
            {
                Xiexe.EmissionMap = Context.GetITexture2D(emissionMap);
                Xiexe.EmissionMapOffset = Material.GetTextureOffset("_EmissionMap");
                Xiexe.EmissionMapScale = Material.GetTextureScale("_EmissionMap");
                Xiexe.EmissionUV = (int)Material.GetFloat("_EmissionMapUV");
            }
            else
            {
                // Unlike PBS, Xiexe requires an emission map to have any emission happen,
                // despite specifying a non-black emission color.
                // So we create a procedural white SolidColorTexture to use here.
                Xiexe.EmissionMap = AssetCache.SolidWhiteTexture.Data;
                Xiexe.EmissionMapOffset = new(0, 0);
                Xiexe.EmissionMapScale = new(1, 1);
                Xiexe.EmissionUV = 0;
            }
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
            Xiexe.Matcap = Context.GetITexture2D(OpacifyMatcap(Material.GetTexture("_Matcap")));
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

    private UnityEngine.Texture OpacifyMatcap(UnityEngine.Texture matcap)
    {
        if (matcap == null)
        {
            return matcap;
        }

        if (matcap is not UnityEngine.Texture2D originalMatcap || !matcap.isReadable)
        {
            Debug.LogWarning($"Matcap texture {matcap.name} is not readable; could not convert it to Opaque for Resonite's shader.");
            return matcap;
        }

        var opaqueMatcap = AssetCache.MatcapTexture;
        if (opaqueMatcap == null || opaqueMatcap.width != originalMatcap.width || opaqueMatcap.height != originalMatcap.height)
        {
            if (opaqueMatcap != null)
            {
                UnityEngine.Texture2D.Destroy(opaqueMatcap);
            }
            opaqueMatcap = new(originalMatcap.width, originalMatcap.height, TextureFormat.RGBA32, false)
            {
                name = "PoiyomiConverter opaque matcap texture"
            };
            AssetCache.MatcapTexture = opaqueMatcap;
        }

        var alpha = Material.GetColor("_MatcapColor").a;
        var pixels = originalMatcap.GetPixels32();
        for (int i = 0; i < pixels.Length; i++)
        {
            // Add black background inversely proportional to alpha
            Color p = pixels[i];
            var pa = p.a;
            p = p * pa * alpha;
            p.a = pa;
            pixels[i] = p;
        }
        opaqueMatcap.SetPixels32(pixels);
        opaqueMatcap.Apply();
        return opaqueMatcap;
    }

    private void UpdateOcclusion()
    {
        Xiexe.OcclusionMap = Context.GetITexture2D(Material.GetTexture("_LightingAOMaps"));
        Xiexe.OcclusionMapOffset = Material.GetTextureOffset("_LightingAOMaps");
        Xiexe.OcclusionMapScale = Material.GetTextureScale("_LightingAOMaps");
        Xiexe.OcclusionUV = (int)Material.GetFloat("_LightingAOMapsUV");
        Xiexe.OcclusionColor = Color.black.ToColorX_sRGB();
    }

    private void UpdateOutline()
    {
        if (Material.GetFloat("_EnableOutlines") == 0)
        {
            Xiexe.Outline = XiexeToonMaterial.OutlineStyle.None;
            return;
        }

        if (Material.GetFloat("_OutlineLit") > 0 && Material.GetFloat("_OutlineShadowStrength") >= 0.5)
        {
            Xiexe.Outline = XiexeToonMaterial.OutlineStyle.Lit;
        }
        else if (Material.GetFloat("_OutlineExpansionMode") == 1)
        {
            // Rim light
            Xiexe.Outline = XiexeToonMaterial.OutlineStyle.Lit;
        }
        else
        {
            Xiexe.Outline = XiexeToonMaterial.OutlineStyle.Emissive;
        }

        Xiexe.OutlineWidth = Material.GetFloat("_LineWidth");
        Xiexe.OutlineColor = Material.GetColor("_LineColor").ToColorX_Auto();
        Xiexe.OutlineAlbedoTint = (Material.GetFloat("_OutlineTintMix") >= 0.5);
        Xiexe.OutlineMask = Context.GetITexture2D(Material.GetTexture("_OutlineMask"));
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
                Xiexe.ShadowRamp = Context.GetITexture2D(TintColoredShadowRamp(Material.GetTexture("_ToonRamp")));
                break;
            case PoiyomiLightingMode.MultilayerMath:
                Xiexe.ShadowRamp = Context.GetITexture2D(MultilayerMathShadowRamp());
                break;
            case PoiyomiLightingMode.ShadeMap:
                Xiexe.ShadowRamp = Context.GetITexture2D(ShadeMapShadowRamp());
                break;
            default:
                Xiexe.ShadowRamp = null;
                break;
        }
    }

    private UnityEngine.Texture TintColoredShadowRamp(UnityEngine.Texture ramp)
    {
        if (ramp == null)
        {
            return ramp;
        }

        var color = Material.GetColor("_LightingShadowColor");
        var strength = Material.GetFloat("_ShadowStrength");
        if (color == Color.white && strength >= 1)
        {
            return ramp;
        }
        if (ramp is not UnityEngine.Texture2D originalRamp || !ramp.isReadable)
        {
            Debug.LogWarning($"Shadow ramp texture {ramp.name} is not readable; could not bake shadow tint and strength for Resonite's shader.");
            return ramp;
        }

        var colorizedRamp = AssetCache.ShadowRampTexture;
        if (colorizedRamp == null || colorizedRamp.width != originalRamp.width || colorizedRamp.height != originalRamp.height)
        {
            if (colorizedRamp != null)
            {
                UnityEngine.Texture2D.Destroy(colorizedRamp);
            }
            colorizedRamp = new(originalRamp.width, originalRamp.height, TextureFormat.RGBA32, false)
            {
                name = "PoiyomiConverter colorized shadow ramp"
            };
            AssetCache.ShadowRampTexture = colorizedRamp;
        }

        var pixels = originalRamp.GetPixels32();
        for (int i = 0; i < pixels.Length; i++)
        {
            Color p = pixels[i];
            p = Color.Lerp(p * color, p, p.grayscale);
            pixels[i] = Color.Lerp(Color.white, p, strength);
        }
        colorizedRamp.SetPixels32(pixels);
        colorizedRamp.Apply();
        return colorizedRamp;
    }

    private UnityEngine.Texture MultilayerMathShadowRamp()
    {
        var ramp = AssetCache.ShadowRampTexture;
        if (ramp == null || ramp.width != 512 || ramp.height != 4)
        {
            if (ramp != null)
            {
                UnityEngine.Texture2D.Destroy(ramp);
            }
            ramp = new(512, 4, TextureFormat.RGBA32, false)
            {
                name = "PoiyomiConverter multilayer math ramp"
            };
            AssetCache.ShadowRampTexture = ramp;
        }
        Color32[] pixels = new Color32[512 * 4];
        Color[] layers =
        {
            Material.GetColor("_ShadowColor"),
            Material.GetColor("_Shadow2ndColor"),
            Material.GetColor("_Shadow3rdColor"),
            Material.GetColor("_ShadowBorderColor"),
        };
        float[] borders =
        {
            Material.GetFloat("_ShadowBorder"),
            Material.GetFloat("_Shadow2ndBorder"),
            Material.GetFloat("_Shadow3rdBorder"),
            Material.GetFloat("_ShadowBorderRange"),
        };
        float[] blurs =
        {
            Material.GetFloat("_ShadowBlur"),
            Material.GetFloat("_Shadow2ndBlur"),
            Material.GetFloat("_Shadow3rdBlur"),
        };
        float strength = Material.GetFloat("_ShadowStrength");
        for (int x = 0; x < 512; x++)
        {
            Color pixel = Color.white;
            // =1 before (border - blur), decreases linearly to 0, =0 after (border + blur)
            float influence = 1;
            for (int i = 0; i < 3 && influence > 0; i++)
            {
                Color layer = layers[i];
                float layerInfluence;
                if (blurs[i] == 0)
                {
                    layerInfluence = (x / 511f <= borders[i]) ? 1 : 0;
                }
                else
                {
                    layerInfluence = Mathf.Clamp01((borders[i] + blurs[i] - (x / 511f)) / (2 * blurs[i]));
                }
                if (i == 0)
                {
                    influence = layerInfluence;
                }
                else
                {
                    layerInfluence *= influence;
                }
                if (layer.a > 0 && layerInfluence > 0)
                {
                    pixel = Color.Lerp(pixel, layer, layer.a * layerInfluence);
                }
            }
            if (layers[3].a > 0 && influence > 0)
            {
                float layerInfluence = influence;
                if (blurs[0] == 0)
                {
                    layerInfluence *= (x / 511f >= (1 - borders[3]) * borders[0]) ? 1 : 0;
                }
                else
                {
                    layerInfluence *= Mathf.Clamp01(((x / 511f) - (1 - borders[3]) * (borders[0] - blurs[0])) / (2 * (1 - borders[3]) * blurs[0]));
                }
                if (layerInfluence > 0)
                {
                    pixel = Color.Lerp(pixel, layers[3], layers[3].a * layerInfluence);
                }
            }
            pixel = Color.Lerp(Color.white, pixel, strength);
            pixel.a = 1;
            for (int y = 0; y < 4; y++)
            {
                pixels[512 * y + x] = pixel;
            }
        }
        ramp.SetPixels32(pixels);
        ramp.Apply();
        return ramp;
    }

    private UnityEngine.Texture ShadeMapShadowRamp()
    {
        var ramp = AssetCache.ShadowRampTexture;
        if (ramp == null || ramp.width != 512 || ramp.height != 4)
        {
            if (ramp != null)
            {
                UnityEngine.Texture2D.Destroy(ramp);
            }
            ramp = new(512, 4, TextureFormat.RGBA32, false)
            {
                name = "PoiyomiConverter shade map math ramp"
            };
            AssetCache.ShadowRampTexture = ramp;
        }
        Color32[] pixels = new Color32[512 * 4];
        Color[] layers =
        {
            Material.GetColor("_1st_ShadeColor"),
            Material.GetColor("_2nd_ShadeColor"),
        };
        float[] borders =
        {
            Material.GetFloat("_BaseColor_Step"),
            Material.GetFloat("_ShadeColor_Step")
        };
        float[] blurs =
        {
            Material.GetFloat("_BaseShade_Feather"),
            Material.GetFloat("_1st2nd_Shades_Feather"),
        };
        float strength = Material.GetFloat("_ShadowStrength");
        for (int x = 0; x < 512; x++)
        {
            Color pixel = Color.white;
            // =1 before (border - blur), decreases linearly to 0, =0 after (border + blur)
            float influence = Mathf.Clamp01((borders[0] + blurs[0] - (x / 511f)) / (2 * blurs[0]));
            if (influence > 0)
            {
                pixel = Color.Lerp(pixel, layers[0], influence);
                float influence2 = Mathf.Clamp01((borders[1] + blurs[1] - (x / 511f)) / (2 * blurs[1]));
                pixel = Color.Lerp(pixel, layers[1], influence2);
                pixel = Color.Lerp(Color.white, pixel, strength);
                pixel.a = 1;
            }
            for (int y = 0; y < 4; y++)
            {
                pixels[512 * y + x] = pixel;
            }
        }
        ramp.SetPixels32(pixels);
        ramp.Apply();
        return ramp;
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
            // We might not actually use shadow rim for Poiyomi, in the end.
            // Leaving this around for now, just in case.
            default:
                // TODO: use actual values. For now, using default Xiexe values
                Xiexe.ShadowRim = Color.white.ToColorX_sRGB();
                Xiexe.ShadowRimThreshold = 1;
                Xiexe.ShadowRimRange = 0.7f;
                Xiexe.ShadowRimSharpness = 0.3f;
                break;
        }
    }

    private void UpdateSubsurface()
    {
        if (Material.GetFloat("_SubsurfaceScattering") == 0)
        {
            Xiexe.ThicknessMap = null;
            Xiexe.SubsurfaceColor = Color.black.ToColorX_sRGB();
        }

        Xiexe.ThicknessMap = Context.GetITexture2D(Material.GetTexture("_SSSThicknessMap"));
        Xiexe.ThicknessMapOffset = Material.GetTextureOffset("_SSSThicknessMap");
        Xiexe.ThicknessMapScale = Material.GetTextureScale("_SSSThicknessMap");
        Xiexe.ThicknessUV = (int)Material.GetFloat("_SSSThicknessMapUV");

        Xiexe.SubsurfaceColor = Material.GetColor("_SSSColor").ToColorX_Auto();
        Xiexe.SubsurfaceDistortion = 3 * Material.GetFloat("_SSSDistortion");
        Xiexe.SubsurfacePower = 3 * Material.GetFloat("_SSSStrength");
        Xiexe.SubsurfaceScale = 3 / Material.GetFloat("_SSSSpread");
    }
}
