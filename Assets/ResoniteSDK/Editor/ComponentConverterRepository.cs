using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

public static class ComponentConverterRepository
{
    public static Type TryGetConverter(Type unityType)
    {
        if (_converters.TryGetValue(unityType, out var converter))
            return converter;

        return null;
    }

    static Dictionary<Type, Type> _converters = new Dictionary<Type, Type>();

    static ComponentConverterRepository()
    {
        foreach (var converter in TypeCache.GetTypesDerivedFrom<ResoniteComponentConverter>())
        {
            // Ignore abstract ones
            if (converter.IsAbstract)
                continue;

            // Determine the type it converts from the generic base type
            var unityType = GetUnityComponentType(converter);

            _converters.Add(unityType, converter);
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