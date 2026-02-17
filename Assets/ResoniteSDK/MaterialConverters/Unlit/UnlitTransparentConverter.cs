using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MaterialConverter(false, "Unlit/Transparent", "Unlit/Transparent Cutout")]
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
        data.TintColor = Color.white.ToColorX_Auto();

        data.Texture = context.GetTextureAuto(material.mainTexture);
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
        }

        return data;
    }
}
