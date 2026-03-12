using FrooxEngine;

[MaterialConverter(false, "Standard")]
public class StandardConverter : StandardBaseConverter<PBS_MetallicWrapper, PBS_Metallic>
{
    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        var provider = base.UpdateConversion(material, context);

        var data = PBS.Data;

        data.Smoothness = material.GetFloat("_Glossiness");
        data.Metallic = material.GetFloat("_Metallic");

        return provider;
    }
}
