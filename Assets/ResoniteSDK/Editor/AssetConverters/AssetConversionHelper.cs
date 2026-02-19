using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class AssetConversionHelper
{
    /// <summary>
    /// Determines if given texture format is HDR or not
    /// </summary>
    /// <param name="format">Format to determine</param>
    /// <returns></returns>
    public static bool IsHDR(this TextureFormat format)
    {
        switch (format)
        {
            case TextureFormat.RHalf:
            case TextureFormat.RGHalf:
            case TextureFormat.RGBAHalf:

            case TextureFormat.RFloat:
            case TextureFormat.RGFloat:
            case TextureFormat.RGBAFloat:

            case TextureFormat.BC6H:
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines if given texture asset is supported to be imported as a file
    /// </summary>
    /// <param name="assetPath">Path to the asset file</param>
    /// <returns>True if Resonite should support this file directly</returns>
    public static bool IsTextureFileSupportedByResonite(string assetPath)
    {
        // Just a simple heuristic using the most common formats that Resonite supports
        // Could potentially be expanded in the future
        var extension = Path.GetExtension(assetPath).ToLowerInvariant();

        switch (extension)
        {
            case ".jpg":
            case ".jpeg":
            case ".jif":

            case ".png":

            case ".webp":

            case ".bmp":
            case ".ico":
            case ".gif":

            case ".tga":

            case ".tif":
            case ".tiff":

            case ".psd":
            case ".dng":

            // HDR
            case ".exr":
            case ".hdr":
                return true;

            default:
                return false;
        }
    }
}