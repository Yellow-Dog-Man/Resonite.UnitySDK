using FrooxEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ResoniteSDK {
    [MaterialConverter(false, "Standard (Specular setup)")]
    public class StandardSpecularConverter : StandardBaseConverter<PBS_Specular>
    {
        protected static readonly IEnumerable<string> SupportedProperties = new List<string>()
        {
            "_SpecColor",
            "_Glossiness",
            "_SpecGlossMap",
        };

        public override IAssetProvider<FrooxEngine.Material> UpdateConversion(UnityEngine.Material material, IConversionContext context)
        {
            var provider = base.UpdateConversion(material, context);

            var data = PBS;

            var specColor = material.GetColor("_SpecColor");

            // Resonite uses the alpha channel to determine the glossiness
            specColor.a = material.GetFloat("_Glossiness");

            data.SpecularColor = specColor.ToColorX_sRGB();
            data.SpecularMap = context.GetITexture2D(material.GetTexture("_SpecGlossMap"));

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
}