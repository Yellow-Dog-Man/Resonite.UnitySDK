using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class PrimitiveMapper
{
    public static Type MapEnginePrimitive(TypeDefinition typeDefinition)
    {
        if (!typeDefinition.IsEnginePrimitive)
            throw new System.ArgumentException($"Type definition must be an engine primitive");

        switch(typeDefinition.Name)
        {
            case "byte": return typeof(byte);
            case "ushort": return typeof(ushort);
            case "uint": return typeof(uint);
            case "ulong": return typeof(ulong);

            case "sbyte": return typeof(sbyte);
            case "short": return typeof(short);
            case "int": return typeof(int);
            case "long": return typeof(long);

            case "half": return typeof(Half);
            case "float": return typeof(float);
            case "double": return typeof(double);
            case "decimal": return typeof(decimal);

            case "bool": return typeof(bool);
            case "char": return typeof(char);
            case "string": return typeof(string);

            case "float2": return typeof(Vector2);
            case "float3": return typeof(Vector3);
            case "float4": return typeof(Vector4);

            case "int2": return typeof(Vector2Int);
            case "int3": return typeof(Vector3Int);

            case "float4x4": return typeof(Matrix4x4);

            case "color": return typeof(UnityEngine.Color);
            case "color32": return typeof(UnityEngine.Color32);

            default:
                return null;
        }
    }
}
