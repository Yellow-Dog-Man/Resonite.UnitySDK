using FrooxEngine;
using System.Collections.Generic;
using System.Linq;

[MaterialConverter(true, "Standard")]
public class StandardConverter : StandardBaseConverter<PBS_Metallic>
{
    protected static readonly IEnumerable<string> SupportedProperties = new List<string>()
    {
        "_Glossiness",
        "_Metallic",
        "_MetallicGlossMap",
    };

    public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
    {
        var provider = base.UpdateConversion(material, context);

        var data = PBS;

        data.Smoothness = material.GetFloat("_Glossiness");
        data.Metallic = material.GetFloat("_Metallic");

        data.MetallicMap = context.GetITexture2D(material.GetTexture("_MetallicGlossMap"));

        return provider;
    }

    public static float? EvaluateHeuristicConversion(UnityEngine.Material material)
    {
        if (material.shader == null)
            return null;

        return PropertyBasedCompatibilityEvaluator.ComputeCompatibility(material,
            SupportedProperties.Concat(BaseSupportedProperties));
    }
}
