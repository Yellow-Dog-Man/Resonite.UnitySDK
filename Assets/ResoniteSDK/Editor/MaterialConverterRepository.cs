using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public static class MaterialConverterRepository
{
    readonly struct HeuristicMaterialConverter
    {
        public readonly Type type;
        public readonly MaterialConversionHeuristicEvaluator evaluator;

        public HeuristicMaterialConverter(Type type, MaterialConversionHeuristicEvaluator evaluator)
        {
            this.type = type;
            this.evaluator = evaluator;
        }
    }

    public static Type TryGetConverter(UnityEngine.Material material)
    {
        var shader = material.shader;

        // No shader, no conversion
        if (shader == null)
            return null;

        // We found exact converter for this shader!
        if (_materialConverters.TryGetValue(shader.name, out var converter))
            return converter;

        // There's no exactly matching converter for this material/shader. Let's scan through the heuristic
        // ones and determine if there's a viable candidate.
        Type bestMatch = null;
        float bestScore = float.NegativeInfinity;

        foreach(var heuristic in _materialHeuristicConverters)
        {
            var score = heuristic.evaluator(material);

            // It cannot handle this one at all
            if (score == null)
                continue;

            if(bestMatch == null || score > bestScore)
            {
                bestMatch = heuristic.type;
                bestScore = score.Value;
            }
        }

        // Return the best match we found (or nothing if nothing can handle this)
        return bestMatch;
    }

    static Dictionary<string, Type> _materialConverters = new Dictionary<string, Type>();
    static List<HeuristicMaterialConverter> _materialHeuristicConverters = new List<HeuristicMaterialConverter>();

    static MaterialConverterRepository()
    {
        foreach (var converter in TypeCache.GetTypesDerivedFrom<ResoniteMaterialConverter>())
        {
            // Ignore abstract ones
            if (converter.IsAbstract)
                continue;

            var attribute = converter.GetCustomAttribute<MaterialConverterAttribute>(inherit: false);

            if (attribute == null)
            {
                Debug.LogWarning($"Material converter {converter.FullName} does not have MaterialConverterAttribute");
                continue;
            }

            if (attribute.SupportedShaders != null)
                foreach (var shader in attribute.SupportedShaders)
                {
                    // TODO!!! Should we add a system to "rank" the converters, so it's easier to determine
                    // which is the preferred one? It might be trickier to override some converters with
                    // this mechanism, where only the first one is found, but right now I'm uncertain if
                    // it will become actual problem in practice or not. If it does, this mechanism could be
                    // changed.
                    if (!_materialConverters.TryAdd(shader, converter))
                        Debug.LogWarning($"Duplicate material converter for shader {shader}.\n" +
                            $"Existing: {_materialConverters[shader].FullName}\n" +
                            $"Conflicting: {converter.FullName}\n" +
                            $"Only the existing one will be used for conversion.");
                }

            if (attribute.SupportsHeuristics)
            {
                // Get the static method
                var methodInfo = converter.GetMethod(ResoniteMaterialConverter.HEURISTIC_METHOD_NAME,
                    BindingFlags.Public | BindingFlags.Static);

                if (methodInfo == null)
                {
                    Debug.LogWarning($"Material converter {converter.FullName} indicates heuristic support but " +
                        $"does not declare public static method {ResoniteMaterialConverter.HEURISTIC_METHOD_NAME}");

                    continue;
                }

                try
                {
                    var method = (MaterialConversionHeuristicEvaluator)
                        methodInfo.CreateDelegate(typeof(MaterialConversionHeuristicEvaluator));

                    _materialHeuristicConverters.Add(new HeuristicMaterialConverter(converter, method));
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"Material converter {converter.FullName} heuristic method could not be bound: {ex.Message}");
                }
            }
        }
    }
}
