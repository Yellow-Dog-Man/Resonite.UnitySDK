using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, "Standard")]
public class StandardMaterialConverter : ResoniteMaterialConverter
{
    public FrooxEngine.PBS_MetallicWrapper PBS;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (PBS == null)
            PBS = gameObject.AddComponent<FrooxEngine.PBS_MetallicWrapper>();

        var data = PBS.Data;

        data.RenderQueue = material.renderQueue;

        if (material.IsKeywordEnabled("_ALPHATEST_ON"))
            data.BlendMode = BlendMode.Cutout;
        else if (material.IsKeywordEnabled("_ALPHAPREMULTIPLY_ON"))
            data.BlendMode = BlendMode.Transparent;
        else if (material.IsKeywordEnabled("_ALPHABLEND_ON"))
            data.BlendMode = BlendMode.Alpha;
        else
            data.BlendMode = BlendMode.Opaque;

        data.AlbedoColor = material.GetColor("_Color").ToColorX_Auto();

        data.AlbedoTexture = context.GetTextureAuto(material.GetTexture("_MainTex"));
        data.TextureScale = material.GetTextureScale("_MainTex");
        data.TextureOffset = material.GetTextureOffset("_MainTex");

        data.NormalMap = context.GetTextureAuto(material.GetTexture("_BumpMap"));

        data.AlphaCutoff = material.GetFloat("_Cutoff");
        data.Smoothness = material.GetFloat("_Glossiness");

        data.Metallic = material.GetFloat("_Metallic");

        data.NormalScale = material.GetFloat("_BumpScale");

        data.HeightScale = material.GetFloat("_Parallax");
        data.HeightMap = context.GetTextureAuto(material.GetTexture("_ParallaxMap"));

        data.OcclusionMap = context.GetTextureAuto(material.GetTexture("_OcclusionMap"));

        if(material.IsKeywordEnabled("_EMISSION"))
        {
            data.EmissiveColor = material.GetColor("_EmissionColor").ToColorX_Linear();
            data.EmissiveMap = context.GetTextureAuto(material.GetTexture("_EmissionMap"));
        }
        else
        {
            // There's no actual toggle for emission on the Resonite version, so just set it to black
            data.EmissiveColor = Color.black.ToColorX_Linear();
        }

        return data;
    }
}
