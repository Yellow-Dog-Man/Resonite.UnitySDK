using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, 
    "Unlit/Transparent", 
    "Unlit/Transparent Cutout",
    "Unlit/Texture",
    "Unlit/Color"
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
        if (material.shader.name == "Unlit/Color")
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
                break;

            case "Unlit/Transparent Cutout":
                data.BlendMode = BlendMode.Cutout;
                data.AlphaCutoff = material.GetFloat("_Cutoff");
                break;

            case "Unlit/Texture":
            case "Unlit/Color":
                data.BlendMode = BlendMode.Opaque;
                break;
        }

        return data;
    }
}
