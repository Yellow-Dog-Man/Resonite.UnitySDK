using System;
using FrooxEngine;
using UnityEngine;
using UnityEditor;

namespace ResoniteSDK {
    public class LilToonXiexeConverter
    {
        private struct MainTextureData
        {
            public readonly Texture Texture;
            public readonly Color Color;
            public readonly Vector2 Scale;
            public readonly Vector2 Offset;

            public MainTextureData(Texture texture, Color color, Vector2 scale, Vector2 offset)
            {
                Texture = texture;
                Color = color;
                Scale = scale;
                Offset = offset;
            }
        }

        private struct EmissionMapData
        {
            public readonly Texture Texture;
            public readonly Vector2 Scale;
            public readonly Vector2 Offset;
            public readonly int UV;

            public EmissionMapData(Texture texture, Vector2 scale, Vector2 offset, int uv)
            {
                Texture = texture;
                Scale = scale;
                Offset = offset;
                UV = uv;
            }
        }

        private readonly XiexeToonMaterial Xiexe;
        private readonly UnityEngine.Material Material;
        private readonly IConversionContext Context;
        private readonly LilToonAssetCache AssetCache;

        public LilToonXiexeConverter(XiexeToonMaterial Xiexe, UnityEngine.Material Material, IConversionContext Context, LilToonAssetCache AssetCache)
        {
            this.Xiexe = Xiexe;
            this.Material = Material;
            this.Context = Context;
            this.AssetCache = AssetCache;
        }

        public IAssetProvider<FrooxEngine.Material> UpdateConversion()
        {
            var mainTexture = GetMainTexture();
            UpdateMainTexture(mainTexture);
            UpdateRenderSettings();
            UpdateNormal();
            UpdateEmission(mainTexture.Texture, mainTexture.Scale, mainTexture.Offset);
            UpdateMatcap();
            UpdateOcclusion();
            UpdateOutline();
            UpdateShadowRamp();
            Xiexe.ShadowRim = Color.white.ToColorX_sRGB();

            return Xiexe;
        }

        private MainTextureData GetMainTexture()
        {
            var defaultData = new MainTextureData(
                Material.mainTexture,
                Material.GetColor("_Color"),
                Material.mainTextureScale,
                Material.mainTextureOffset);

            var shouldBakeMain = Material.GetVector("_MainTexHSVG") != new Vector4(0, 1, 1, 1)
                || Material.GetFloat("_MainGradationStrength") != 0;
            
            // Non-UV0 2nd/3rd textures cannot be preserved in a single UV0 bake.
            // Null layer textures still bake as white, matching lilToon's editor baker.
            var shouldBakeMain2nd = Material.GetFloat("_UseMain2ndTex") != 0
                && (Material.GetTexture("_Main2ndTex") == null
                    || Material.GetFloat("_Main2ndTex_UVMode") == 0);
            var shouldBakeMain3rd = Material.GetFloat("_UseMain3rdTex") != 0
                && (Material.GetTexture("_Main3rdTex") == null
                    || Material.GetFloat("_Main3rdTex_UVMode") == 0);

            var shouldBakeAlpha = Material.GetFloat("_AlphaMaskMode") != 0
                && Material.GetTexture("_AlphaMask") != null;
            var shouldBakeMainColor = shouldBakeMain || shouldBakeMain2nd || shouldBakeMain3rd;

            if (!shouldBakeMainColor && !shouldBakeAlpha)
            {
                return defaultData;
            }

            var bakeHash = GetMainTextureBakeHash(shouldBakeMain, shouldBakeMain2nd, shouldBakeMain3rd, shouldBakeAlpha);
            if (AssetCache.MainTexture != null && AssetCache.MainTextureBakeHash == bakeHash)
            {
                return new MainTextureData(AssetCache.MainTexture,
                    shouldBakeMainColor ? Color.white : defaultData.Color,
                    Vector2.one,
                    Vector2.zero);
            }

            var bakerShader = UnityEngine.Shader.Find("Hidden/ltsother_baker");
            if (bakerShader == null)
            {
                UnityEngine.Debug.LogWarning("Could not find lilToon main texture baker shader Hidden/ltsother_baker.");
                return defaultData;
            }

            UnityEngine.Texture2D bakedTexture = null;
            UnityEngine.Material bakerMaterial = null;

            try
            {
                bakerMaterial = new UnityEngine.Material(bakerShader);
                bakerMaterial.CopyPropertiesFromMaterial(Material);

                if (!shouldBakeMain2nd)
                {
                    bakerMaterial.SetFloat("_UseMain2ndTex", 0);
                }
                if (!shouldBakeMain3rd)
                {
                    bakerMaterial.SetFloat("_UseMain3rdTex", 0);
                }

                var sourceTexture2D = Material.mainTexture ?? UnityEngine.Texture2D.whiteTexture;
                if (shouldBakeMainColor)
                {
                    bakedTexture = BakeMaterialToTexture(sourceTexture2D, bakerMaterial);
                    bakedTexture.name = $"{Material.name}_MainTex_Baked";
                }

                if (shouldBakeAlpha)
                {
                    var alphaSourceTexture = sourceTexture2D;
                    bakerMaterial.EnableKeyword("_ALPHAMASK");
                    if (bakedTexture != null)
                    {
                        bakerMaterial.SetTexture("_MainTex", alphaSourceTexture);
                        bakerMaterial.SetColor("_Color", Color.white);
                        bakerMaterial.SetTextureScale("_MainTex", Vector2.one);
                        bakerMaterial.SetTextureOffset("_MainTex", Vector2.zero);
                        bakerMaterial.SetFloat("_UseMain2ndTex", 0);
                        bakerMaterial.SetFloat("_UseMain3rdTex", 0);
                        alphaSourceTexture = bakedTexture;
                    }

                    var alphaBakedTexture = BakeMaterialToTexture(alphaSourceTexture, bakerMaterial);
                    alphaBakedTexture.name = $"{Material.name}_MainTex_Baked";
                    if (bakedTexture != null)
                    {
                        UnityEngine.Object.DestroyImmediate(bakedTexture);
                    }
                    bakedTexture = alphaBakedTexture;
                }
            }
            catch (Exception exception)
            {
                if (bakedTexture != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakedTexture);
                }

                UnityEngine.Debug.LogWarning($"Could not bake lilToon main texture. {exception.Message}");
                return defaultData;
            }
            finally
            {
                if (bakerMaterial != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakerMaterial);
                }
            }

            if (bakedTexture == null)
            {
                return defaultData;
            }

            if (AssetCache.MainTexture != null && AssetCache.MainTexture != bakedTexture && !EditorUtility.IsPersistent(AssetCache.MainTexture))
            {
                UnityEngine.Object.DestroyImmediate(AssetCache.MainTexture);
            }

            AssetCache.MainTexture = bakedTexture;
            AssetCache.MainTextureBakeHash = bakeHash;
            return new MainTextureData(bakedTexture,
                shouldBakeMainColor ? Color.white : defaultData.Color,
                Vector2.one,
                Vector2.zero);
        }

        private void UpdateMainTexture(MainTextureData mainTextureData)
        {
            Xiexe.MainTexture = Context.GetITexture2D(mainTextureData.Texture);
            Xiexe.MainTextureScale = mainTextureData.Scale;
            Xiexe.MainTextureOffset = mainTextureData.Offset;
            Xiexe.Color = mainTextureData.Color.ToColorX_sRGB();
            Xiexe.Saturation = 1;
        }

        private void UpdateRenderSettings()
        {
            Xiexe.BlendMode = GetBlendMode();
            Xiexe.AlphaClip = Material.GetFloat("_Cutoff");
            Xiexe.ZWrite = Material.GetFloat("_ZWrite") > 0 ? ZWrite.On : ZWrite.Off;
            Xiexe.Culling = (Culling)(UnityEngine.Rendering.CullMode)Material.GetFloat("_Cull");
            Xiexe.ColorMask = (ColorMask)Material.GetFloat("_ColorMask");
            Xiexe.RenderQueue = Material.renderQueue;
        }

        private BlendMode GetBlendMode()
        {
            var shaderName = Material.shader.name;

            if (ContainsAfterLastSeparator(shaderName, "Multi") && Material.HasProperty("_TransparentMode"))
            {
                switch ((int)Material.GetFloat("_TransparentMode"))
                {
                    case 0: // Opaque
                        return BlendMode.Opaque;
                    case 1: // Cutout
                    case 5: // FurCutout
                        return BlendMode.Cutout;
                    case 2: // Transparent
                    case 3: // Refraction
                    case 4: // Fur
                        return BlendMode.Alpha;
                    case 6: // Gem
                        return BlendMode.Additive;
                }
            }

            if (ContainsAfterLastSeparator(shaderName, "Refraction"))
            {
                return BlendMode.Alpha;
            }

            if (ContainsAfterLastSeparator(shaderName, "Cutout"))
            {
                return BlendMode.Cutout;
            }

            if (ContainsAfterLastSeparator(shaderName, "Transparent") ||
                ContainsAfterLastSeparator(shaderName, "Overlay") ||
                IsLilToonFurShaderName(shaderName))
            {
                return BlendMode.Alpha;
            }

            if (ContainsAfterLastSeparator(shaderName, "Gem"))
            {
                return BlendMode.Additive;
            }

            return BlendMode.Opaque;
        }

        private static bool IsLilToonFurShaderName(string shaderName)
        {
            if (ContainsAfterLastSeparator(shaderName, "Fur"))
            {
                return true;
            }

            var separatorIndex = shaderName.LastIndexOf('/');
            if (separatorIndex == -1 || separatorIndex + 1 == shaderName.Length)
            {
                return false;
            }

            var partIndex = shaderName.LastIndexOf("/[Optional] FurOnly/");
            return partIndex != -1 && partIndex + 19 == separatorIndex;
        }

        private static bool ContainsAfterLastSeparator(string shaderName, string subName)
        {
            var separatorIndex = shaderName.LastIndexOf('/');
            if (separatorIndex == -1 || separatorIndex + 1 == shaderName.Length)
            {
                return false;
            }

            return shaderName.IndexOf(subName, separatorIndex + 1) != -1;
        }
    
        private void UpdateNormal()
        {
            // TODO: If 2nd normal map support is added, bake into a single normal map
            if (Material.GetFloat("_UseBumpMap") != 0)
            {
                Xiexe.NormalMap = Context.GetITexture2D(Material.GetTexture("_BumpMap"));
                Xiexe.NormalMapOffset = Material.GetTextureOffset("_BumpMap");
                Xiexe.NormalMapScale = Material.GetTextureScale("_BumpMap");
                Xiexe.NormalScale = Material.GetFloat("_BumpScale");
                Xiexe.NormalUV = 0;
                return;
            }
            if (Material.GetFloat("_UseBump2ndMap") != 0)
            {
                // TODO: _Bump2ndScaleMask is not supported, so the 2nd normal map's strength may differ from lilToon. Consider baking if this causes issues.
                Xiexe.NormalMap = Context.GetITexture2D(Material.GetTexture("_Bump2ndMap"));
                Xiexe.NormalMapOffset = Material.GetTextureOffset("_Bump2ndMap");
                Xiexe.NormalMapScale = Material.GetTextureScale("_Bump2ndMap");
                Xiexe.NormalScale = Material.GetFloat("_Bump2ndScale");
                Xiexe.NormalUV = (int)Material.GetFloat("_Bump2ndMap_UVMode");
                return;
            }
            Xiexe.NormalMap = null;
        }

        private void UpdateEmission(Texture mainTexture, Vector2 mainTextureScale, Vector2 mainTextureOffset)
        {
            if (Material.GetFloat("_UseEmission") == 0)
            {
                Xiexe.EmissionMap = null;
                return;
            }

            var emissionColor = Material.GetColor("_EmissionColor");
            var emissionAlpha = emissionColor.a;
            // lilToon uses color alpha as blend strength; Xiexe emission ignores alpha.
            emissionColor *= Mathf.Clamp01(Material.GetFloat("_EmissionBlend")) * emissionAlpha;
            emissionColor.a = emissionAlpha;
            var emissionFluorescence = Mathf.Clamp01(Material.GetFloat("_EmissionFluorescence"));
            if (emissionFluorescence > 0)
            {
                // lilToon multiplies fluorescence emission by a lighting-dependent
                // invLighting value. Xiexe emission is static, so use the maximum-ish
                // value of lilToon's curve as a conservative approximation.
                var fluorescenceScale = Mathf.Lerp(1, 0.375f, emissionFluorescence);
                emissionColor.r *= fluorescenceScale;
                emissionColor.g *= fluorescenceScale;
                emissionColor.b *= fluorescenceScale;
            }
            Xiexe.EmissionColor = emissionColor.ToColorX_Linear();

            var emissionMap = GetEmissionMap(mainTexture, mainTextureScale, mainTextureOffset);
            Xiexe.EmissionMap = Context.GetITexture2D(emissionMap.Texture, OpacifyProcessor);
            Xiexe.EmissionMapScale = emissionMap.Scale;
            Xiexe.EmissionMapOffset = emissionMap.Offset;
            Xiexe.EmissionUV = emissionMap.UV;
        }

        private EmissionMapData GetEmissionMap(Texture mainTexture, Vector2 mainTextureScale, Vector2 mainTextureOffset)
        {
            var bakeHash = GetEmissionMapBakeHash(
                mainTexture,
                mainTextureScale,
                mainTextureOffset);
            if (AssetCache.EmissionMap != null && AssetCache.EmissionMapBakeHash == bakeHash)
            {
                return new EmissionMapData(AssetCache.EmissionMap, Vector2.one, Vector2.zero, 0);
            }

            var emissionMap = Material.GetTexture("_EmissionMap");
            var emissionBlendMask = Material.GetTexture("_EmissionBlendMask");
            var emissionMapUV = (int)Material.GetFloat("_EmissionMap_UVMode");
            var emissionMainStrength = Material.GetFloat("_EmissionMainStrength");

            var hasEmissionMap = emissionMap != null;
            var hasEmissionBlendMask = emissionBlendMask != null;
            var usesMainTextureAsEmission = emissionMainStrength > 0 && mainTexture != null;

            var fallbackData = hasEmissionMap
                ? new EmissionMapData(
                    emissionMap,
                    Material.GetTextureScale("_EmissionMap"),
                    Material.GetTextureOffset("_EmissionMap"),
                    emissionMapUV)
                : new EmissionMapData(
                    emissionBlendMask ?? mainTexture ?? UnityEngine.Texture2D.whiteTexture,
                    Vector2.one,
                    Vector2.zero,
                    0);

            if (!hasEmissionMap && !hasEmissionBlendMask && !usesMainTextureAsEmission)
            {
                return fallbackData;
            }

            // If the emission map is not UV0, baking will cause issues, so do not bake.
            if (hasEmissionMap && emissionMapUV != 0)
            {
                return fallbackData;
            }

            var bakerShader = UnityEngine.Shader.Find("Hidden/ltsother_baker");
            if (bakerShader == null)
            {
                UnityEngine.Debug.LogWarning("Could not find lilToon texture baker shader Hidden/ltsother_baker.");
                return fallbackData;
            }

            UnityEngine.Texture2D bakedTexture = null;
            UnityEngine.Material bakerMaterial = null;

            try
            {
                bakerMaterial = new UnityEngine.Material(bakerShader);
                bakerMaterial.SetColor("_Color", Color.white);
                if (hasEmissionMap)
                {
                    bakerMaterial.SetTexture("_MainTex", emissionMap);
                    bakerMaterial.SetTextureScale("_MainTex", Material.GetTextureScale("_EmissionMap"));
                    bakerMaterial.SetTextureOffset("_MainTex", Material.GetTextureOffset("_EmissionMap"));
                }
                else
                {
                    bakerMaterial.SetTexture("_MainTex", UnityEngine.Texture2D.whiteTexture);
                }
                if (hasEmissionBlendMask)
                {
                    bakerMaterial.SetFloat("_UseMain2ndTex", 1);
                    bakerMaterial.SetColor("_Color2nd", Color.white);
                    bakerMaterial.SetTexture("_Main2ndTex", emissionBlendMask);
                    bakerMaterial.SetTextureScale("_Main2ndTex", Material.GetTextureScale("_EmissionBlendMask"));
                    bakerMaterial.SetTextureOffset("_Main2ndTex", Material.GetTextureOffset("_EmissionBlendMask"));
                    bakerMaterial.SetFloat("_Main2ndTexBlendMode", 3);  // Multiply
                }
                if (usesMainTextureAsEmission)
                {
                    bakerMaterial.SetFloat("_UseMain3rdTex", 1);
                    bakerMaterial.SetColor("_Color3rd", new Color(1, 1, 1, Mathf.Clamp01(emissionMainStrength)));
                    bakerMaterial.SetTexture("_Main3rdTex", mainTexture);
                    bakerMaterial.SetTextureScale("_Main3rdTex", mainTextureScale);
                    bakerMaterial.SetTextureOffset("_Main3rdTex", mainTextureOffset);
                    bakerMaterial.SetFloat("_Main3rdTexBlendMode", 3);  // Multiply
                }

                var sourceTexture2D = emissionMap as UnityEngine.Texture2D
                    ?? emissionBlendMask as UnityEngine.Texture2D
                    ?? mainTexture as UnityEngine.Texture2D
                    ?? UnityEngine.Texture2D.whiteTexture;
                bakedTexture = BakeMaterialToTexture(sourceTexture2D, bakerMaterial);
                bakedTexture.name = $"{Material.name}_EmissionMap_Baked";
                bakedTexture.wrapMode = sourceTexture2D.wrapMode;
                bakedTexture.filterMode = sourceTexture2D.filterMode;
                bakedTexture.anisoLevel = sourceTexture2D.anisoLevel;
            }
            catch (Exception exception)
            {
                if (bakedTexture != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakedTexture);
                }

                UnityEngine.Debug.LogWarning($"Could not bake lilToon emission map. {exception.Message}");
                return fallbackData;
            }
            finally
            {
                if (bakerMaterial != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakerMaterial);
                }
            }

            if (AssetCache.EmissionMap != null && AssetCache.EmissionMap != bakedTexture && !EditorUtility.IsPersistent(AssetCache.EmissionMap))
            {
                UnityEngine.Object.DestroyImmediate(AssetCache.EmissionMap);
            }

            AssetCache.EmissionMap = bakedTexture;
            AssetCache.EmissionMapBakeHash = bakeHash;
            return new EmissionMapData(bakedTexture, Vector2.one, Vector2.zero, 0);
        }

        private void UpdateMatcap()
        {
            // Xiexe only supports additive MatCap and has no equivalent to lilToon's
            // _MatCapBlendMask. Applying unsupported modes or an unmasked MatCap changes
            // the look, so only convert additive, unmasked MatCap.
            if (Material.GetFloat("_UseMatCap") == 0 ||
                Material.GetFloat("_MatCapBlendMode") != 1 ||
                Material.GetTexture("_MatCapBlendMask") != null)
            {
                Xiexe.Matcap = null;
                return;
            }

            Xiexe.Matcap = Context.GetITexture2D(Material.GetTexture("_MatCapTex"), OpacifyProcessor);
            var matcapColor = Material.GetColor("_MatCapColor");
            var alpha = matcapColor.a;
            matcapColor *= Material.GetFloat("_MatCapBlend") * alpha;
            matcapColor.a = alpha;
            Xiexe.MatcapTint = matcapColor.ToColorX_sRGB();
        }

        private static readonly AssetMessagePostProcessor OpacifyProcessor = TexturePostProcessing.ProcessPixels(Opacify);

        private static ResoniteLink.color Opacify(ResoniteLink.color c)
        {
            return new ResoniteLink.color()
            {
                r = c.r * c.a,
                g = c.g * c.a,
                b = c.b * c.a,
                a = c.a,
            };
        }

        private void UpdateOcclusion()
        {
            if (Material.GetFloat("_UseShadow") == 0)
            {
                Xiexe.OcclusionMap = null;
                return;
            }

            Xiexe.OcclusionMap = Context.GetITexture2D(Material.GetTexture("_ShadowBorderMask"));
            Xiexe.OcclusionMapScale = Material.GetTextureScale("_ShadowBorderMask");
            Xiexe.OcclusionMapOffset = Material.GetTextureOffset("_ShadowBorderMask");

            var shadowColor = Material.GetColor("_ShadowColor");
            var occlusionColor = Color.Lerp(Color.white, shadowColor, Material.GetFloat("_ShadowStrength"));
            Xiexe.OcclusionColor = occlusionColor.ToColorX_Auto();
        }

        private void UpdateOutline()
        {
            if (Material.GetFloat("_UseOutline") == 0 && !Material.shader.name.Contains("Outline", StringComparison.OrdinalIgnoreCase))
            {
                Xiexe.Outline = XiexeToonMaterial.OutlineStyle.None;
                return;
            }

            Xiexe.Outline = Material.GetFloat("_OutlineEnableLighting") > 0
                ? XiexeToonMaterial.OutlineStyle.Lit
                : XiexeToonMaterial.OutlineStyle.Emissive;
            Xiexe.OutlineWidth = Material.GetFloat("_OutlineWidth");
            Xiexe.OutlineColor = Material.GetColor("_OutlineColor").ToColorX_Auto();
            Xiexe.OutlineAlbedoTint = Material.GetFloat("_OutlineLitApplyTex") > 0;
            Xiexe.OutlineMask = Context.GetITexture2D(Material.GetTexture("_OutlineWidthMask"));
        }
    
        private void UpdateShadowRamp()
        {
            if (Material.GetFloat("_UseShadow") == 0)
            {
                Xiexe.ShadowRamp = null;
                return;
            }

            // XiexeToon's null ShadowRampMask behaves differently from lilToon's null
            // _ShadowStrengthMask, which means no shadow strength mask. Preserve that with white.
            if (Material.GetTexture("_ShadowStrengthMask") == null)
            {
                Xiexe.ShadowRampMask = Context.GetITexture2D(UnityEngine.Texture2D.whiteTexture);
                Xiexe.ShadowRampMaskScale = Vector2.one;
                Xiexe.ShadowRampMaskOffset = Vector2.zero;
            }
            else
            {
                Xiexe.ShadowRampMask = Context.GetITexture2D(Material.GetTexture("_ShadowStrengthMask"));
                Xiexe.ShadowRampMaskScale = Material.GetTextureScale("_ShadowStrengthMask");
                Xiexe.ShadowRampMaskOffset = Material.GetTextureOffset("_ShadowStrengthMask");
            }

            var shadowRamp = GetShadowRamp();
            Xiexe.ShadowRamp = Context.GetITexture2D(shadowRamp);
        }

        private UnityEngine.Texture2D GetShadowRamp()
        {
            var bakeHash = GetShadowRampBakeHash();
            if (AssetCache.ShadowRampTexture != null && AssetCache.ShadowRampBakeHash == bakeHash)
            {
                return AssetCache.ShadowRampTexture;
            }

            var bakerShader = UnityEngine.Shader.Find("Hidden/ltsother_bakeramp");
            if (bakerShader == null)
            {
                UnityEngine.Debug.LogWarning("Could not find lilToon shadow ramp baker shader Hidden/ltsother_bakeramp.");
                return null;
            }

            UnityEngine.Material bakerMaterial = null;
            UnityEngine.Texture2D bakedRamp = null;
            UnityEngine.RenderTexture renderTexture = null;
            var currentRenderTexture = UnityEngine.RenderTexture.active;

            try
            {
                const int width = 256;
                const int height = 256;
                const int sourceHeight = 1;
                // Avoid assigning source.shader on Material Variants. Copy the saved values
                // into a normal baker material that already uses Hidden/ltsother_bakeramp.
                bakerMaterial = new UnityEngine.Material(bakerShader);
                bakerMaterial.CopyPropertiesFromMaterial(Material);

                // Bake lilToon's horizontal shadow ramp into the first row.
                renderTexture = UnityEngine.RenderTexture.GetTemporary(width, sourceHeight, 0, UnityEngine.RenderTextureFormat.Default, UnityEngine.RenderTextureReadWrite.Default);
                UnityEngine.RenderTexture.active = renderTexture;
                Graphics.Blit(null, renderTexture, bakerMaterial);

                bakedRamp = new UnityEngine.Texture2D(width, height, TextureFormat.RGBA32, false)
                {
                    name = "LilToonConverter baked shadow ramp",
                    wrapMode = TextureWrapMode.Clamp,
                };
                bakedRamp.ReadPixels(new Rect(0, 0, width, sourceHeight), 0, 0);

                // Expand the horizontal ramp vertically so Xiexe's ShadowRampMask can sample it.
                var sourcePixels = bakedRamp.GetPixels(0, 0, width, 1);
                var gradientPixels = new Color[width * height];

                for (var y = 0; y < height; y++)
                {
                    var mask = height > 1 ? y / (height - 1f) : 1f;
                    for (var x = 0; x < width; x++)
                    {
                        var color = Color.Lerp(Color.white, sourcePixels[x], mask);
                        gradientPixels[x + y * width] = color;
                    }
                }

                bakedRamp.SetPixels(gradientPixels);
                bakedRamp.Apply();
            }
            catch (Exception exception)
            {
                if (bakedRamp != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakedRamp);
                }

                UnityEngine.Debug.LogWarning($"Could not bake lilToon shadow ramp. {exception.Message}");
                return null;
            }
            finally
            {
                UnityEngine.RenderTexture.active = currentRenderTexture;
                if (renderTexture != null)
                {
                    UnityEngine.RenderTexture.ReleaseTemporary(renderTexture);
                }

                if (bakerMaterial != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakerMaterial);
                }
            }

            if (AssetCache.ShadowRampTexture != null && AssetCache.ShadowRampTexture != bakedRamp && !EditorUtility.IsPersistent(AssetCache.ShadowRampTexture))
            {
                UnityEngine.Object.DestroyImmediate(AssetCache.ShadowRampTexture);
            }

            AssetCache.ShadowRampTexture = bakedRamp;
            AssetCache.ShadowRampBakeHash = bakeHash;
            return bakedRamp;
        }

        private Hash128 GetMainTextureBakeHash(bool shouldBakeMain, bool shouldBakeMain2nd, bool shouldBakeMain3rd, bool shouldBakeAlpha)
        {
            var hash = new LilToonAssetCache.BakeHash();
            hash.Add(shouldBakeMain);
            hash.Add(shouldBakeMain2nd);
            hash.Add(shouldBakeMain3rd);
            hash.Add(shouldBakeAlpha);
            hash.Add(Material.mainTexture);

            if (shouldBakeMain || shouldBakeMain2nd || shouldBakeMain3rd)
            {
                hash.Add(Material.mainTextureScale);
                hash.Add(Material.mainTextureOffset);
                hash.Add(Material.GetColor("_Color"));
                hash.Add(Material.GetVector("_MainTexHSVG"));
                hash.Add(Material.GetFloat("_MainGradationStrength"));
                hash.Add(Material.GetTexture("_MainGradationTex"));
                hash.Add(Material.GetTextureScale("_MainGradationTex"));
                hash.Add(Material.GetTextureOffset("_MainGradationTex"));
                hash.Add(Material.GetTexture("_MainColorAdjustMask"));
                hash.Add(Material.GetTextureScale("_MainColorAdjustMask"));
                hash.Add(Material.GetTextureOffset("_MainColorAdjustMask"));
            }

            if (shouldBakeMain2nd)
            {
                AddMainLayerBakeHash(ref hash, "2nd");
            }
            if (shouldBakeMain3rd)
            {
                AddMainLayerBakeHash(ref hash, "3rd");
            }
            if (shouldBakeAlpha)
            {
                hash.Add(Material.GetFloat("_AlphaMaskMode"));
                hash.Add(Material.GetTexture("_AlphaMask"));
                hash.Add(Material.GetTextureScale("_AlphaMask"));
                hash.Add(Material.GetTextureOffset("_AlphaMask"));
                hash.Add(Material.GetFloat("_AlphaMaskScale"));
                hash.Add(Material.GetFloat("_AlphaMaskValue"));
            }
            return hash.Value;
        }

        private void AddMainLayerBakeHash(ref LilToonAssetCache.BakeHash hash, string suffix)
        {
            var prefix = $"_Main{suffix}";
            hash.Add(Material.GetFloat($"_UseMain{suffix}Tex"));
            hash.Add(Material.GetColor($"_Color{suffix}"));
            hash.Add(Material.GetTexture($"{prefix}Tex"));
            hash.Add(Material.GetTextureScale($"{prefix}Tex"));
            hash.Add(Material.GetTextureOffset($"{prefix}Tex"));
            hash.Add(Material.GetFloat($"{prefix}Tex_UVMode"));
            hash.Add(Material.GetFloat($"{prefix}TexAngle"));
            hash.Add(Material.GetVector($"{prefix}TexDecalAnimation"));
            hash.Add(Material.GetVector($"{prefix}TexDecalSubParam"));
            hash.Add(Material.GetFloat($"{prefix}TexIsDecal"));
            hash.Add(Material.GetFloat($"{prefix}TexIsLeftOnly"));
            hash.Add(Material.GetFloat($"{prefix}TexIsRightOnly"));
            hash.Add(Material.GetFloat($"{prefix}TexShouldCopy"));
            hash.Add(Material.GetFloat($"{prefix}TexShouldFlipMirror"));
            hash.Add(Material.GetFloat($"{prefix}TexShouldFlipCopy"));
            hash.Add(Material.GetFloat($"{prefix}TexIsMSDF"));
            hash.Add(Material.GetTexture($"{prefix}BlendMask"));
            hash.Add(Material.GetTextureScale($"{prefix}BlendMask"));
            hash.Add(Material.GetTextureOffset($"{prefix}BlendMask"));
            hash.Add(Material.GetFloat($"{prefix}TexBlendMode"));
        }

        private Hash128 GetEmissionMapBakeHash(
            Texture mainTexture,
            Vector2 mainTextureScale,
            Vector2 mainTextureOffset)
        {
            var emissionMap = Material.GetTexture("_EmissionMap");
            var emissionBlendMask = Material.GetTexture("_EmissionBlendMask");
            var usesMainTextureAsEmission = Material.GetFloat("_EmissionMainStrength") > 0 && mainTexture != null;
            var hash = new LilToonAssetCache.BakeHash();
            hash.Add(emissionMap != null);
            hash.Add(emissionBlendMask != null);
            hash.Add(usesMainTextureAsEmission);
            if (emissionMap != null)
            {
                hash.Add(Material.GetTexture("_EmissionMap"));
                hash.Add(Material.GetTextureScale("_EmissionMap"));
                hash.Add(Material.GetTextureOffset("_EmissionMap"));
                hash.Add(Material.GetFloat("_EmissionMap_UVMode"));
            }
            if (emissionBlendMask != null)
            {
                hash.Add(Material.GetTexture("_EmissionBlendMask"));
                hash.Add(Material.GetTextureScale("_EmissionBlendMask"));
                hash.Add(Material.GetTextureOffset("_EmissionBlendMask"));
            }
            if (usesMainTextureAsEmission)
            {
                hash.Add(Material.GetFloat("_EmissionMainStrength"));
                hash.Add(mainTexture);
                hash.Add(mainTextureScale);
                hash.Add(mainTextureOffset);
            }
            return hash.Value;
        }

        private Hash128 GetShadowRampBakeHash()
        {
            var hash = new LilToonAssetCache.BakeHash();
            hash.Add(Material.GetFloat("_ShadowStrength"));
            hash.Add(Material.GetColor("_ShadowColor"));
            hash.Add(Material.GetFloat("_ShadowBorder"));
            hash.Add(Material.GetFloat("_ShadowBlur"));
            hash.Add(Material.GetColor("_Shadow2ndColor"));
            hash.Add(Material.GetFloat("_Shadow2ndBorder"));
            hash.Add(Material.GetFloat("_Shadow2ndBlur"));
            hash.Add(Material.GetColor("_Shadow3rdColor"));
            hash.Add(Material.GetFloat("_Shadow3rdBorder"));
            hash.Add(Material.GetFloat("_Shadow3rdBlur"));
            hash.Add(Material.GetColor("_ShadowBorderColor"));
            hash.Add(Material.GetFloat("_ShadowBorderRange"));
            return hash.Value;
        }

        private static UnityEngine.Texture2D BakeMaterialToTexture(Texture sourceTexture, UnityEngine.Material material)
        {
            UnityEngine.RenderTexture renderTexture = null;
            UnityEngine.Texture2D bakedTexture = null;
            var currentRenderTexture = UnityEngine.RenderTexture.active;

            try
            {
                renderTexture = UnityEngine.RenderTexture.GetTemporary(sourceTexture.width, sourceTexture.height);
                Graphics.Blit(sourceTexture, renderTexture, material);
                UnityEngine.RenderTexture.active = renderTexture;

                bakedTexture = new UnityEngine.Texture2D(sourceTexture.width, sourceTexture.height);
                bakedTexture.ReadPixels(new Rect(0, 0, sourceTexture.width, sourceTexture.height), 0, 0);
                bakedTexture.Apply();

                return bakedTexture;
            }
            catch
            {
                if (bakedTexture != null)
                {
                    UnityEngine.Object.DestroyImmediate(bakedTexture);
                }

                throw;
            }
            finally
            {
                UnityEngine.RenderTexture.active = currentRenderTexture;
                if (renderTexture != null)
                {
                    UnityEngine.RenderTexture.ReleaseTemporary(renderTexture);
                }
            }
        }

    }
}