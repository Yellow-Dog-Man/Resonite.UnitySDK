using UnityEditor;

namespace ResoniteSDK {
    public enum PoiyomiColorChannel
    {
        R,
        G,
        B,
        A,
        White
    }

    public static class PoiyomiColorChannelMethods
    {
        public static TextureImporterSwizzle SwizzleFromChannel(PoiyomiColorChannel channel, bool invert)
        {
            TextureImporterSwizzle result;
            switch (channel)
            {
                case PoiyomiColorChannel.R:
                    result = TextureImporterSwizzle.R;
                    break;
                case PoiyomiColorChannel.G:
                    result = TextureImporterSwizzle.G;
                    break;
                case PoiyomiColorChannel.B:
                    result = TextureImporterSwizzle.B;
                    break;
                case PoiyomiColorChannel.A:
                    result = TextureImporterSwizzle.A;
                    break;
                case PoiyomiColorChannel.White:
                default:
                    result = TextureImporterSwizzle.One;
                    break;
            }
            if (invert)
            {
                result = InvertSwizzle(result);
            }
            return result;
        }

        public static TextureImporterSwizzle InvertSwizzle(TextureImporterSwizzle source)
        {
            switch (source)
            {
                case TextureImporterSwizzle.R:
                    return TextureImporterSwizzle.OneMinusR;
                case TextureImporterSwizzle.G:
                    return TextureImporterSwizzle.OneMinusG;
                case TextureImporterSwizzle.B:
                    return TextureImporterSwizzle.OneMinusB;
                case TextureImporterSwizzle.A:
                    return TextureImporterSwizzle.OneMinusA;
                case TextureImporterSwizzle.Zero:
                    return TextureImporterSwizzle.One;
                case TextureImporterSwizzle.OneMinusR:
                    return TextureImporterSwizzle.R;
                case TextureImporterSwizzle.OneMinusG:
                    return TextureImporterSwizzle.G;
                case TextureImporterSwizzle.OneMinusB:
                    return TextureImporterSwizzle.B;
                case TextureImporterSwizzle.OneMinusA:
                    return TextureImporterSwizzle.A;
                case TextureImporterSwizzle.One:
                default:
                    return TextureImporterSwizzle.Zero;
            }
        }
    }
}