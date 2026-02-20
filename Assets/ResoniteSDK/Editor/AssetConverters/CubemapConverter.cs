using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using UnityEditor;
using UnityEngine;
using Elements.Assets;

public class CubemapConverter : AssetConverter<StaticCubemapWrapper, StaticCubemap, UnityEngine.Cubemap, FrooxEngine.Cubemap>
{
    public CubemapConverter(UnityEngine.Cubemap source, Transform assetsRoot) : base(source, assetsRoot)
    {
    }

    protected override string AssetClass => "Cubemap";
    protected override string AssetName => Source.name;

    protected override Message GenerateConversion()
    {
        return ConvertCubemap(Source);
    }

    protected override async Task<AssetData> SendConversion(Message message, LinkInterface link)
    {
        switch (message)
        {
            case ImportCubemapFiles importFile:
                return await link.ImportCubemap(importFile);

            case ImportCubemapFileWithRegions importFileRegions:
                return await link.ImportCubemap(importFileRegions);

            case ImportCubemapRawData importRawData:
                return await link.ImportCubemap(importRawData);

            case ImportCubemapRawDataHDR importRawDataHDR:
                return await link.ImportCubemap(importRawDataHDR);

            default:
                throw new NotSupportedException("Unsupported conversion message: " + message.GetType());
        }
    }

    protected override ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context)
    {
        Provider.Data.URL = assetUrl;

        return Provider.CollectData(context);
    }

    public static ResoniteLink.Message ConvertCubemap(UnityEngine.Cubemap cubemap)
    {
        if(!cubemap.isReadable)
        {
            string path = AssetDatabase.GetAssetPath(cubemap);

            var importer = AssetImporter.GetAtPath(path);

            switch (importer)
            {
                case TextureImporter textureImporter:
                    textureImporter.isReadable = true;
                    textureImporter.SaveAndReimport();
                    break;

                case AssetImporter assetImporter:
                    // This is likely a legacy cubemap. We can't mark this as isReadable to my knowledge, so we have to read it
                    var readableCubemap = new UnityEngine.Cubemap(cubemap.width, cubemap.format, cubemap.mipmapCount > 1, true);

                    for(int f = 0; f < 6; f++)
                        Graphics.CopyTexture(cubemap, f, readableCubemap, f);

                    cubemap = readableCubemap;
                    break;

                default:
                    throw new NotImplementedException($"Unsupported importer type: {importer?.GetType().FullName}");
            }            
        }

        var hasMipMaps = cubemap.mipmapCount > 1;

        // If there are no mipmaps, we can import this from the file itself
        // However if mipmaps are present, we need to read their data and send them raw
        // The mipmap data can be specially convoluted (e.g. for reflection probes), so we want to preserve them
        // exactly as they are in Unity
        if (!hasMipMaps)
        {
            var assetPath = AssetDatabase.GetAssetPath(cubemap);

            if (!string.IsNullOrWhiteSpace(assetPath))
            {
                assetPath = Path.GetFullPath(assetPath);

                if (File.Exists(assetPath) && AssetConversionHelper.IsTextureFileSupportedByResonite(assetPath))
                    return ConvertCubemapFromFile(assetPath);
            }
        }

        // Extract the data from the cubemap
        // TODO!!! Should we add non-HDR version as well? Unity doesn't even give way to access the 8-bit data right now
        // and generally cubemaps are HDR anyways. Might be good to add later though.
        var import = new ImportCubemapRawDataHDR()
        {
            Size = cubemap.width,
            MipMaps = hasMipMaps
        };

        for(int mip = 0; mip < cubemap.mipmapCount; mip++)
        {
            for(int face = 0; face < 6; face++)
            {
                var unityFace = (CubemapFace)face;
                var pixels = cubemap.GetPixels(unityFace, mip);

                Span2D<color> data;

                switch(unityFace)
                {
                    case CubemapFace.PositiveX: data = import.AccessPositiveX(mip); break;
                    case CubemapFace.PositiveY: data = import.AccessPositiveY(mip); break;
                    case CubemapFace.PositiveZ: data = import.AccessPositiveZ(mip); break;
                    case CubemapFace.NegativeX: data = import.AccessNegativeX(mip); break;
                    case CubemapFace.NegativeY: data = import.AccessNegativeY(mip); break;
                    case CubemapFace.NegativeZ: data = import.AccessNegativeZ(mip); break;

                    // This should never happen
                    default: throw new ArgumentException($"Invalid face: {unityFace}");
                }

                for (int y = 0; y < data.height; y++)
                    for(int x = 0; x < data.width; x++)
                    {
                        var c = pixels[x + y * data.width];
                        data[x, y] = c.ToResoniteLink();
                    }
            }
        }

        return import;
    }

    public static ResoniteLink.ImportCubemapFileWithRegions ConvertCubemapFromFile(string assetPath)
    {
        var horizontalSize = 1f / 6f;

        return new ImportCubemapFileWithRegions()
        {
            FilePath = assetPath,

            PositiveXRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 0, y = 0 },
            },

            PositiveYRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 1, y = 0 },
            },

            PositiveZRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 2, y = 0 },
            },

            NegativeXRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 3, y = 0 },
            },

            NegativeYRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 4, y = 0 },
            },

            NegativeZRegion = new ResoniteLink.Rect()
            {
                size = new float2() { x = horizontalSize, y = 1 },
                position = new float2 { x = horizontalSize * 5, y = 0 },
            },
        };
    }
}