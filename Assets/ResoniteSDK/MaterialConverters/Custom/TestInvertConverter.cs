using FrooxEngine;
using UnityEngine;

// This converter is intended as an example of how a conversion of custom shaders can work for things that aren't directly
// supported by Resonite's materials. In this particular case, the shader inverts the texture colors. To achieve this,
// we request the texture with a post processing method that inverts the texture itself.
// Similar mechanism can be used to swizzle channels and do other types of processing on the texture data.
[MaterialConverter(false, "Unlit/TestInvertShader")]
public class TestInvertConverter : ResoniteMaterialConverter
{
    public ResRef<FrooxEngine.UnlitMaterial> Unlit;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (Unlit == null)
            Unlit = gameObject.AddResoniteComponent<FrooxEngine.UnlitMaterial>();

        var data = Unlit.Binding;

        data.RenderQueue = material.renderQueue;

        data.Texture = context.GetITexture2D(material.mainTexture, TexturePostProcessing.InvertRGB);
        data.TextureScale = material.mainTextureScale;

        data.BlendMode = BlendMode.Alpha;
        data.TintColor = Color.white.ToColorX_sRGB();

        return data;
    }
}