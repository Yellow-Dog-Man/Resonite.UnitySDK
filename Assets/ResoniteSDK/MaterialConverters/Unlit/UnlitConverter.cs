using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, 
    "Unlit/Transparent", 
    "Unlit/Transparent Cutout",
    "Unlit/Texture",
    "Unlit/Color",
    "Particles/Standard Unlit"
    )]
public class UnlitTransparentConverter : ResoniteMaterialConverter
{
    public FrooxEngine.UnlitMaterialWrapper Unlit;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (Unlit == null)
            Unlit = gameObject.AddComponent<FrooxEngine.UnlitMaterialWrapper>();

        var data = Unlit.Data;

        data.RenderQueue = material.renderQueue;

        // Make sure we have proper tint color set
        if (material.shader.name == "Unlit/Color" ||
            material.shader.name == "Particles/Standard Unlit")
            data.TintColor = material.GetColor("_Color").ToColorX_sRGB();
        else
            data.TintColor = Color.white.ToColorX_sRGB();

        data.Texture = context.GetITexture2D(material.mainTexture);
        data.TextureScale = material.mainTextureScale;
        data.TextureOffset = material.mainTextureOffset;

        switch(material.shader.name)
        {
            case "Unlit/Transparent":
                data.BlendMode = BlendMode.Alpha;
                data.Sidedness = Sidedness.Front;
                break;

            case "Unlit/Transparent Cutout":
                data.BlendMode = BlendMode.Cutout;
                data.AlphaCutoff = material.GetFloat("_Cutoff");
                data.Sidedness = Sidedness.Front;
                break;

            case "Unlit/Texture":
            case "Unlit/Color":
                data.BlendMode = BlendMode.Opaque;
                data.Sidedness = Sidedness.Front;
                break;

            case "Particles/Standard Unlit":
                data.UseVertexColors = true;

                var srcBlend = material.GetFloat("_SrcBlend");
                var dstBlend = material.GetFloat("_DstBlend");

                if (Mathf.Approximately(srcBlend, 1) && Mathf.Approximately(dstBlend, 0)) // Opaque
                {
                    if (material.IsKeywordEnabled("_ALPHATEST_ON"))
                        data.BlendMode = BlendMode.Cutout;
                    else
                        data.BlendMode = BlendMode.Opaque;
                }
                else if (Mathf.Approximately(srcBlend, 5) && Mathf.Approximately(dstBlend, 10)) // Fade
                    data.BlendMode = BlendMode.Alpha;
                else if (Mathf.Approximately(srcBlend, 1) && Mathf.Approximately(dstBlend, 10)) // Transparent
                    data.BlendMode = BlendMode.Transparent;
                else if (Mathf.Approximately(srcBlend, 5) && Mathf.Approximately(dstBlend, 1)) // Additive
                    data.BlendMode = BlendMode.Additive;
                else if (Mathf.Approximately(srcBlend, 2) && Mathf.Approximately(dstBlend, 10)) // Modulate
                    data.BlendMode = BlendMode.Multiply;
                else
                    data.BlendMode = BlendMode.Alpha; // Fallback

                var cull = material.GetFloat("_Cull");

                data.Sidedness = Mathf.Approximately(cull, 0) ? Sidedness.Double : Sidedness.Front;

                break;
        }

        return data;
    }
}
