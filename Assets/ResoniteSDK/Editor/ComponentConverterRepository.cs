using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public class ConverterInfo
{
    public Type Type { get; private set; }
    public ConversionSupressionHandler SupressionHandler { get; private set; }

    public ConverterInfo(Type type, ConversionSupressionHandler supressionHandler)
    {
        this.Type = type;
        this.SupressionHandler = supressionHandler;
    }
}

public static class ComponentConverterRepository
{
    public static ConverterInfo TryGetConverter(Type unityType)
    {
        if (_converters.TryGetValue(unityType, out var converter))
            return converter;

        return null;
    }

    static Dictionary<Type, ConverterInfo> _converters = new Dictionary<Type, ConverterInfo>();

    static ComponentConverterRepository()
    {
        foreach (var converter in TypeCache.GetTypesDerivedFrom<ResoniteComponentConverter>())
        {
            // Ignore abstract ones
            if (converter.IsAbstract)
                continue;

            // Determine the type it converts from the generic base type
            var unityType = GetUnityComponentType(converter);

            var supressionHandlers = converter.GetMethods(BindingFlags.Static | BindingFlags.Public).
                Where(m => m.GetCustomAttribute<ConverterSupressionHandlerAttribute>() != null).ToList();

            if (supressionHandlers.Count > 1)
                Debug.LogWarning($"Converter {converter.GetType().FullName} has multiple supression handler methods. Only one is supported");

            ConversionSupressionHandler supressionHandler = null;

            try
            {
                if (supressionHandlers.Count > 0)
                    supressionHandler = (ConversionSupressionHandler)supressionHandlers[0].CreateDelegate(typeof(ConversionSupressionHandler));
            }
            catch(Exception ex)
            {
                Debug.LogWarning($"Failed to get conversion supression handler for converter {converter.GetType().FullName}. " +
                    $"Is the method signature correct?");
            }

            _converters.Add(unityType, new ConverterInfo(converter, supressionHandler));
        }
    }

    static Type GetUnityComponentType(Type type)
    {
        type = type.BaseType;

        do
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ResoniteComponentConverter<>))
                return type.GetGenericArguments()[0];

            type = type.BaseType;

        } while (type.BaseType != null);

        throw new Exception($"Could not determine conversion type for: {type}");
    }
}