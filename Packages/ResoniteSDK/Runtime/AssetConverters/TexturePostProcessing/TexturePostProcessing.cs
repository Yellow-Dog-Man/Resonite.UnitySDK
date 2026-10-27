using ResoniteLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoniteSDK {
    public static class TexturePostProcessing
    {
        #region COLOR INVERSION

        public static readonly AssetMessagePostProcessor InvertR = ProcessPixels(c => new color()
        {
            r = 1 - c.r,
            g = c.g,
            b = c.b,
            a = c.a
        });

        public static readonly AssetMessagePostProcessor InvertG = ProcessPixels(c => new color()
        {
            r = c.r,
            g = 1 - c.g,
            b = c.b,
            a = c.a
        });

        public static readonly AssetMessagePostProcessor InvertB = ProcessPixels(c => new color()
        {
            r = c.r,
            g = c.g,
            b = 1 - c.b,
            a = c.a
        });

        public static readonly AssetMessagePostProcessor InvertA = ProcessPixels(c => new color()
        {
            r = c.r,
            g = c.g,
            b = c.b,
            a = 1 - c.a
        });

        public static readonly AssetMessagePostProcessor InvertRGB = ProcessPixels(c => new color()
        {
            r = 1 - c.r,
            g = 1 - c.g,
            b = 1 - c.b,
            a = c.a
        });

        public static readonly AssetMessagePostProcessor InvertRGBA = ProcessPixels(c => new color()
        {
            r = 1 - c.r,
            g = 1 - c.g,
            b = 1 - c.b,
            a = 1 - c.a
        });

        #endregion

        public delegate color ColorFilter(color c);

        public static AssetMessageDelegatePostProcessor ProcessPixels(ColorFilter colorFilter)
        {
            if (colorFilter == null)
            {
                return null;
            }
            return new(message =>
            {
                switch (message)
                {
                    case ImportTexture2DRawDataHDR hdr:
                        var hdrData = hdr.AccessRawData();

                        for (int y = 0; y < hdrData.height; y++)
                            for (int x = 0; x < hdrData.width; x++)
                            {
                                ref var c = ref hdrData[x, y];
                                c = colorFilter(c);
                            }

                        break;

                    case ImportTexture2DRawData ldr:
                        var ldrData = ldr.AccessRawData();

                        var sRGB = ldr.ColorProfile != "Linear";

                        for (int y = 0; y < ldrData.height; y++)
                            for (int x = 0; x < ldrData.width; x++)
                            {
                                ref var c32 = ref ldrData[x, y];

                                var c = new color()
                                {
                                    r = FromByte(c32.r, sRGB),
                                    g = FromByte(c32.g, sRGB),
                                    b = FromByte(c32.b, sRGB),
                                    a = FromByte(c32.a, sRGB)
                                };

                                c = colorFilter(c);

                                c32 = new color32()
                                {
                                    r = ToByte(c.r, sRGB),
                                    g = ToByte(c.g, sRGB),
                                    b = ToByte(c.b, sRGB),
                                    a = ToByte(c.a, sRGB)
                                };
                            }
                        break;

                    default:
                        throw new NotSupportedException("Unsupported texture message type: " + message);
                }
            });
        }

        static float FromByte(byte value, bool sRGB) => MathF.Pow(value / 255f, 2.2f);

        static byte ToByte(float value, bool sRGB)
        {
            if (value < 0)
                return 0;

            if (value >= 1f)
                return byte.MaxValue;

            return (byte)(MathF.Pow(value, 1f / 2.2f) * 255f);
        }
    }
}