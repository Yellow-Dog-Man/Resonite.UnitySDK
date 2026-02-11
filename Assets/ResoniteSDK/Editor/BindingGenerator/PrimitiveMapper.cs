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

        return MapEnginePrimitive(typeDefinition.Name);
    }

    public static Type MapEnginePrimitive(string typename)
    {
        switch (typename)
        {
            #region PRIMITIVES
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
            case "Uri": return typeof(Uri);
            #endregion


            #region UNITY TYPES
            case "float2": return typeof(Vector2);
            case "float3": return typeof(Vector3);
            case "float4": return typeof(Vector4);

            case "floatQ": return typeof(Quaternion);

            case "int2": return typeof(Vector2Int);
            case "int3": return typeof(Vector3Int);

            case "float4x4": return typeof(Matrix4x4);

            case "color": return typeof(UnityEngine.Color);
            case "color32": return typeof(UnityEngine.Color32);

            case "Rect": return typeof(UnityEngine.Rect);
            case "IntRect": return typeof(UnityEngine.RectInt);
            #endregion

            #region MISC
            case "doubleQ": return typeof(QuaternionDouble);
            case "colorX": return typeof(ColorX);
            #endregion

            #region CUSTOM VECTORS

            case "bool2": return typeof(Vector2Bool);
            case "bool3": return typeof(Vector3Bool);
            case "bool4": return typeof(Vector4Bool);

            case "byte2": return typeof(Vector2Byte);
            case "byte3": return typeof(Vector3Byte);
            case "byte4": return typeof(Vector4Byte);

            case "ushort2": return typeof(Vector2Ushort);
            case "ushort3": return typeof(Vector3Ushort);
            case "ushort4": return typeof(Vector4Ushort);

            case "uint2": return typeof(Vector2Uint);
            case "uint3": return typeof(Vector3Uint);
            case "uint4": return typeof(Vector4Uint);

            case "ulong2": return typeof(Vector2Ulong);
            case "ulong3": return typeof(Vector3Ulong);
            case "ulong4": return typeof(Vector4Ulong);

            case "sbyte2": return typeof(Vector2Sbyte);
            case "sbyte3": return typeof(Vector3Sbyte);
            case "sbyte4": return typeof(Vector4Sbyte);

            case "short2": return typeof(Vector2Short);
            case "short3": return typeof(Vector3Short);
            case "short4": return typeof(Vector4Short);

            // Unity has Int types for the other variants
            case "int4": return typeof(Vector4Int);

            case "long2": return typeof(Vector2Long);
            case "long3": return typeof(Vector3Long);
            case "long4": return typeof(Vector4Long);

            case "double2": return typeof(Vector2Double);
            case "double3": return typeof(Vector3Double);
            case "double4": return typeof(Vector4Double);
            #endregion

            #region CUSTOM MATRICES
            case "float2x2": return typeof(Matrix2x2);
            case "float3x3": return typeof(Matrix3x3);

            case "double2x2": return typeof(Matrix2x2Double);
            case "double3x3": return typeof(Matrix3x3Double);
            case "double4x4": return typeof(Matrix4x4Double);
            #endregion

            // We cannot represent types as actual types, instead they are encoded into a string
            case "Type": return typeof(string);

            default:
                return null;
        }
    }
}
