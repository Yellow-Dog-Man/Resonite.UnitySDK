using FrooxEngine;
using System.Collections.Generic;
using UnityEngine;

public abstract class StandardBaseConverter<TMaterial> : ResoniteMaterialConverter
    where TMaterial : FrooxEngine.PBS_Material, new()
{
    public ResoniteComponent Container;
    public TMaterial PBS => Container.Data as TMaterial;

    protected static readonly IEnumerable<string> BaseSupportedProperties = new List<string>()
    {
        "_Cutoff",
        "_Color",

        "_BumpMap",
        "_BumpScale",

        "_Parallax",
        "_ParallaxMap",

        "_OcclusionMap",

        "_EmissionColor",
        "_EmissionMap",
    };

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (Container == null)
            gameObject.AddResoniteComponent<TMaterial>(out Container);

        var data = PBS;

        data.RenderQueue = material.renderQueue;

        if (material.IsKeywordEnabled("_ALPHATEST_ON"))
            data.BlendMode = BlendMode.Cutout;
        else if (material.IsKeywordEnabled("_ALPHAPREMULTIPLY_ON"))
            data.BlendMode = BlendMode.Transparent;
        else if (material.IsKeywordEnabled("_ALPHABLEND_ON"))
            data.BlendMode = BlendMode.Alpha;
        else
            data.BlendMode = BlendMode.Opaque;

        data.AlphaCutoff = material.GetFloat("_Cutoff");

        data.AlbedoColor = material.GetColor("_Color").ToColorX_sRGB();
        data.AlbedoTexture = context.GetITexture2D(material.mainTexture);
        data.TextureScale = material.mainTextureScale;
        data.TextureOffset = material.mainTextureOffset;

        data.NormalMap = context.GetITexture2D(material.GetTexture("_BumpMap"));
        data.NormalScale = material.GetFloat("_BumpScale");

        data.HeightScale = material.GetFloat("_Parallax");
        data.HeightMap = context.GetITexture2D(material.GetTexture("_ParallaxMap"));

        data.OcclusionMap = context.GetITexture2D(material.GetTexture("_OcclusionMap"));

        if (material.IsKeywordEnabled("_EMISSION"))
        {
            data.EmissiveColor = material.GetColor("_EmissionColor").ToColorX_sRGB();
            data.EmissiveMap = context.GetITexture2D(material.GetTexture("_EmissionMap"));
        }
        else
        {
            // There's no actual toggle for emission on the Resonite version, so just set it to black
            data.EmissiveColor = Color.black.ToColorX_sRGB();
        }

        return data;
    }
}
