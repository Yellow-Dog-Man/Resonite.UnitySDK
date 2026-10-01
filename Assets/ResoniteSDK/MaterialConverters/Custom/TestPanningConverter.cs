using FrooxEngine;
using UnityEngine;

// This converter is intended as an example of how a conversion of custom shaders can work for things that aren't directly
// supported by Resonite's materials. This example is relatively simple, but you can make more complex conversions using
// similar principles
[MaterialConverter(false, "Custom/TestPanningShader")]
public class TestPanningConverter : ResoniteMaterialConverter
{
    public ResRef<FrooxEngine.PBS_Metallic> PBS;
    public ResRef<FrooxEngine.Panner2D> Panner;

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        if (PBS == null)
            PBS = gameObject.AddResoniteComponent<FrooxEngine.PBS_Metallic>();

        if (Panner == null)
            Panner = gameObject.AddResoniteComponent<FrooxEngine.Panner2D>();

        var data = PBS.Binding;
        var pannerData = Panner.Binding;

        data.RenderQueue = material.renderQueue;

        data.AlbedoTexture = context.GetITexture2D(material.mainTexture);
        data.TextureScale = material.mainTextureScale;

        data.AlbedoColor = material.GetColor("_Color").ToColorX_sRGB();

        data.Smoothness = material.GetFloat("_Glossiness");
        data.Metallic = material.GetFloat("_Metallic");

        // Since this shader uses time to do a panning animation, but Resonite doesn't have an equivalent shader
        // we convert this to a Panner component and set it up with panning speed and offset.
        var panningSpeed = material.GetVector("_PanningSpeed");

        pannerData.Enabled = true;
        pannerData.persistent = true;

        // The panner will drive the TextureOffset field on the PBS material
        pannerData._target = data.TextureOffset_Element.Member;

        // Assign the panner speed from the material property
        pannerData._speed = panningSpeed;

        // We add in the texture offset from the material
        pannerData._offset = material.mainTextureOffset;

        // We don't need it to repeat & wrap around
        pannerData._repeat = new Vector2(float.PositiveInfinity, float.PositiveInfinity);

        return data;
    }
}