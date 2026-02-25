using Elements.Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnumConversionHelper
{
    public static Renderite.Shared.TextureWrapMode ToResoniteLink(this UnityEngine.TextureWrapMode wrapMode)
    {
        switch(wrapMode)
        {
            case TextureWrapMode.Clamp: return Renderite.Shared.TextureWrapMode.Clamp;
            case TextureWrapMode.Repeat: return Renderite.Shared.TextureWrapMode.Repeat;
            case TextureWrapMode.Mirror: return Renderite.Shared.TextureWrapMode.Mirror;
            case TextureWrapMode.MirrorOnce: return Renderite.Shared.TextureWrapMode.MirrorOnce;

            default:
                throw new System.NotImplementedException($"Conversion not implemented for wrap mode: {wrapMode}");
        }
    }

    public static Renderite.Shared.TextureFilterMode ToResoniteLink(this UnityEngine.FilterMode filterMode)
    {
        switch(filterMode)
        {
            case FilterMode.Point: return Renderite.Shared.TextureFilterMode.Point;
            case FilterMode.Bilinear: return Renderite.Shared.TextureFilterMode.Bilinear;
            case FilterMode.Trilinear: return Renderite.Shared.TextureFilterMode.Trilinear;

            default:
                throw new System.NotImplementedException($"Conversion not implemented for filter mode: {filterMode}");
        }
    }

    public static Renderite.Shared.CameraClearMode ToResoniteLink(this UnityEngine.CameraClearFlags flags)
    {
        switch(flags)
        {
            case CameraClearFlags.Nothing: return Renderite.Shared.CameraClearMode.Nothing;
            case CameraClearFlags.Depth: return Renderite.Shared.CameraClearMode.Depth;
            case CameraClearFlags.Color: return Renderite.Shared.CameraClearMode.Color;
            case CameraClearFlags.Skybox: return Renderite.Shared.CameraClearMode.Skybox;

            default:
                throw new System.NotImplementedException($"Conversion not implemented for camera flags: {flags}");
        }
    }

    public static Renderite.Shared.ReflectionProbeClear ToResoniteLink(this UnityEngine.Rendering.ReflectionProbeClearFlags flags)
    {
        switch (flags)
        {
            case UnityEngine.Rendering.ReflectionProbeClearFlags.SolidColor: return Renderite.Shared.ReflectionProbeClear.Color;
            case UnityEngine.Rendering.ReflectionProbeClearFlags.Skybox: return Renderite.Shared.ReflectionProbeClear.Skybox;

            default:
                throw new System.NotImplementedException($"Conversion not implemented for reflection probe clear flags: {flags}");
        }
    }
}