using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoniteSDK {
    public static class PropertyBasedCompatibilityEvaluator
    {
        /// <summary>
        /// Computes a simple heuristic score for matching a material based on how many properties match (and don't match).
        /// Each matching property gives it a point. Each mismatching property removes a point.
        /// </summary>
        /// <param name="material">The material whose compatibility is being computed</param>
        /// <param name="supportedProperties">List of supported properties by the material</param>
        /// <returns></returns>
        public static float ComputeCompatibility(UnityEngine.Material material, IEnumerable<string> supportedProperties)
        {
            // No shader means we can't match this
            if (material.shader == null)
                return float.NegativeInfinity;

            // Collect all supported properties and normalize them
            var normalizedProperties = new HashSet<string>();

            foreach (var property in supportedProperties)
                normalizedProperties.Add(NormalizePropertyName(property));

            float score = 0f;

            var propertyCount = material.shader.GetPropertyCount();

            for(int i = 0; i < propertyCount; i++)
            {
                var name = material.shader.GetPropertyName(i);
                name = NormalizePropertyName(name);

                if (normalizedProperties.Remove(name))
                    score += 1f; // A match! Add a point.
                else
                    score -= 1f; // Not supported, remove point.
            }

            // For any property that the shader supports, but that's not needed, lose half a point
            // This is for cases like PBS matching simple Unlit material, where the only needed thing is main texture
            // and color tint, the extra properties on PBS will disadvantage it over simpler materials like Unlit
            // Assuming there's no other filtering going on
            score -= normalizedProperties.Count * 0.5f;

            return score;
        }

        /// <summary>
        /// Normalizes the property name so small differences like underscores and case don't matter.
        /// </summary>
        /// <param name="propertyName">Property name to normalize</param>
        /// <returns>Normalized property name</returns>
        public static string NormalizePropertyName(string propertyName) => propertyName.Replace("_", "").ToLowerInvariant();
    }
}