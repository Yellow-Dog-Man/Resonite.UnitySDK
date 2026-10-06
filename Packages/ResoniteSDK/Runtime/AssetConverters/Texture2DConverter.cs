using Elements.Assets;
using FrooxEngine;
using ResoniteLink;
using System;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace ResoniteSDK {
    public class Texture2DConverter : AssetConverter<StaticTexture2D, UnityEngine.Texture2D, FrooxEngine.Texture2D>
    {
        Renderite.Shared.TextureWrapMode _wrapModeU;
        Renderite.Shared.TextureWrapMode _wrapModeV;
        Renderite.Shared.TextureFilterMode? _filterMode;
        Renderite.Shared.ColorProfile _colorProfile;
        int? _anisoLevel;
        bool _uncompressed;
        bool _crunchCompressed;
        int? _maxSize;
        bool _mipMaps;
        bool _readable;

        public override string AssetClass => "Texture2D";
        public override string AssetName => Source.name;
        protected override Message GenerateConversion()
        {
            // Cache the texture wrap mode and other properties. We'll need to update provider with these.
            // Unity hates accessing those properties from other threads, so we have to fetch it here while
            // we're on the main thread.
            _wrapModeU = Source.wrapModeU.ToResoniteLink();
            _wrapModeV = Source.wrapModeV.ToResoniteLink();

            if (Source.anisoLevel > 1)
            {
                _anisoLevel = Source.anisoLevel;
                _filterMode = Renderite.Shared.TextureFilterMode.Anisotropic;
            }
            else
            {
                _anisoLevel = null;

                // Only explicitly set the point filtering mode, since that's usually a stylistic choice
                // However Bilinear and up is generally ok to leave to the actual graphics settings
                if (Source.filterMode == FilterMode.Point)
                    _filterMode = Renderite.Shared.TextureFilterMode.Point;
                else
                    _filterMode = null;
            }

            _mipMaps = Source.mipmapCount > 1;

            // If the format is not compressed in Unity, we should also avoid compression
            // This is improtant for texturew with lots of colors, pixel art and such
            _uncompressed = !Source.format.IsCompressed();
            _crunchCompressed = Source.format.IsCrunchCompressed();

            _colorProfile = Source.isDataSRGB ? Renderite.Shared.ColorProfile.sRGB : Renderite.Shared.ColorProfile.Linear;

            _readable = Source.isReadable;

            var assetPath = AssetDatabase.GetAssetPath(Source);

            if (!string.IsNullOrWhiteSpace(assetPath) && AssetImporter.GetAtPath(assetPath) is TextureImporter textureImporter)
                _maxSize = textureImporter.maxTextureSize;
            else
                _maxSize = null;

            return ConvertTexture2D(Source, PostProcessor != null);
        }

        protected override async Task<AssetData> SendConversion(Message message, LinkInterface link)
        {
            switch (message)
            {
                case ImportTexture2DFile importFile:
                    return await link.ImportTexture(importFile);

                case ImportTexture2DRawData importRawData:
                    return await link.ImportTexture(importRawData);

                case ImportTexture2DRawDataHDR importRawDataHDR:
                    return await link.ImportTexture(importRawDataHDR);

                default:
                    throw new NotSupportedException("Unsupported conversion message: " + message.GetType());
            }
        }
        protected override ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context)
        {
            Provider.Binding.URL = assetUrl;

            Provider.Binding.WrapModeU = _wrapModeU;
            Provider.Binding.WrapModeV = _wrapModeV;

            Provider.Binding.AnisotropicLevel = _anisoLevel;
            Provider.Binding.FilterMode = _filterMode;

            Provider.Binding.MipMaps = _mipMaps;
            Provider.Binding.MipMapFilter = Filtering.Box;

            Provider.Binding.PreferredProfile = _colorProfile;

            Provider.Binding.Uncompressed = _uncompressed;
            Provider.Binding.CrunchCompressed = _crunchCompressed;

            Provider.Binding.Readable = _readable;

            Provider.Binding.MaxSize = _maxSize;

            return Provider.Container.CollectData(context);
        }

        public static ResoniteLink.Message ConvertTexture2D(UnityEngine.Texture2D texture, bool requiresPostProcessing)
        {
            // We can only import the file directly if there's no postprocessing required
            if (!requiresPostProcessing)
            {
                // First try to import it as a file. This is easiest and will preserve most data
                // Rather than just extracting the raw pixels
                var assetPath = AssetDatabase.GetAssetPath(texture);

                if (!string.IsNullOrWhiteSpace(assetPath))
                {
                    assetPath = Path.GetFullPath(assetPath);

                    if (File.Exists(assetPath) && AssetConversionHelper.IsTextureFileSupportedByResonite(assetPath))
                        return new ImportTexture2DFile() { FilePath = assetPath };
                }
            }

            if (!texture.isReadable)
            {
                var readableTexture = new UnityEngine.Texture2D(texture.width, texture.height, texture.format, false);

                Graphics.CopyTexture(texture, 0, 0, readableTexture, 0, 0);

                texture = readableTexture;
            }

            // It is not supported directly, so we have to extract the raw data and send it over
            if (texture.format.IsHDR())
            {
                var import = new ImportTexture2DRawDataHDR()
                {
                    Width = texture.width,
                    Height = texture.height,
                };

                var data = import.AccessRawData();
                var pixels = texture.GetPixels(0);

                for (int y = 0; y < import.Height; y++)
                {
                    // GetPixels returns them from bottom to top, and ResoniteLink expects them from top to bottom
                    int ySource = import.Height - 1 - y;
                    for (int x = 0; x < import.Width; x++)
                    {
                        var c = pixels[x + ySource * import.Width];
                        data[x, y] = c.ToResoniteLink();
                    }
                }

                return import;
            }
            else
            {
                var import = new ImportTexture2DRawData()
                {
                    Width = texture.width,
                    Height = texture.height,
                };

                var data = import.AccessRawData();
                var pixels = texture.GetPixels32(0);

                for (int y = 0; y < import.Height; y++)
                {
                    // GetPixels returns them from bottom to top, and ResoniteLink expects them from top to bottom
                    int ySource = import.Height - 1 - y;
                    for (int x = 0; x < import.Width; x++)
                    {
                        var c = pixels[x + ySource * import.Width];
                        data[x, y] = c.ToResoniteLink();
                    }
                }

                return import;
            }
        }
    }
}