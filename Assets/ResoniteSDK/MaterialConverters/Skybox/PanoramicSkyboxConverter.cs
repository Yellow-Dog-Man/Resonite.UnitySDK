using FrooxEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

[MaterialConverter(false, "Skybox/Panoramic")]
public class PanoramicSkyboxConverter : ResoniteMaterialConverter
{
    public ResRef<FrooxEngine.Projection360Material> Sky;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (Sky == null)
            Sky = gameObject.AddResoniteComponent<FrooxEngine.Projection360Material>();

        var data = Sky.Binding;

        switch(material.mainTexture)
        {
            case UnityEngine.Cubemap cubemap:
                data.Cubemap = context.GetCubemap(cubemap);
                data.Texture = null;
                break;

            default:
                data.Texture = context.GetITexture2D(material.mainTexture);
                data.Cubemap = null;
                break;
        }

        data.TextureScale = Vector2.one;

        // TODO!!! Empirical observation, it seems that the tint is half the strength that Resonite expects
        // But this might need more testing with different materials
        data.Tint = (material.GetColor("_Tint") * 2).ToColorX_sRGB();
        data.Exposure = material.GetFloat("_Exposure");
        data.AngleOffset = new Vector2(material.GetFloat("_Rotation"), 0);

        data.FieldOfView = new Vector2(360, 180);
        data.Gamma = 1;

        // Setup the material for skybox
        data.Sidedness = Sidedness.Double;
        data.ZWrite = ZWrite.Off;
        data.ZTest = ZTest.LessOrEqual;
        data.BlendMode = BlendMode.Opaque;

        data.RenderQueue = 1000;
        data.ColorMask = ColorMask.RGBA;

        data.Projection = Projection360Material.Mode.View;

        return data;
    }
}