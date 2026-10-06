using System;
using FrooxEngine;
using UnityEngine;
using UnityEditor;
using ResoniteLink;

namespace ResoniteSDK {
    /// Texture post-processor which perfoms a swizzle
    /// between any combination of the four RGBA channels
    public class ColorSwizzler : AssetMessagePostProcessor
    {
        private TextureImporterSwizzle rSwizzle;
        private TextureImporterSwizzle gSwizzle;
        private TextureImporterSwizzle bSwizzle;
        private TextureImporterSwizzle aSwizzle;

        public TextureImporterSwizzle RSwizzle { set { IsDirty |= rSwizzle != value; rSwizzle = value; } }
        public TextureImporterSwizzle GSwizzle { set { IsDirty |= gSwizzle != value; gSwizzle = value; } }
        public TextureImporterSwizzle BSwizzle { set { IsDirty |= bSwizzle != value; bSwizzle = value; } }
        public TextureImporterSwizzle ASwizzle { set { IsDirty |= aSwizzle != value; aSwizzle = value; } }
        bool IsDirty;

        public override void Process(ResoniteLink.Message message)
        {
            TexturePostProcessing.ProcessPixels(ReflectionSwizzle()).Process(message);
            IsDirty = false;
        }

        public override bool HasChanged() => IsDirty;

        public void Update(
            TextureImporterSwizzle rSwizzle,
            TextureImporterSwizzle gSwizzle,
            TextureImporterSwizzle bSwizzle,
            TextureImporterSwizzle aSwizzle)
        {
            RSwizzle = rSwizzle;
            GSwizzle = gSwizzle;
            BSwizzle = bSwizzle;
            ASwizzle = aSwizzle;
        }

        private TexturePostProcessing.ColorFilter ReflectionSwizzle()
        {
            var rChannelSwizzle = ChannelSwizzle(rSwizzle);
            var gChannelSwizzle = ChannelSwizzle(gSwizzle);
            var bChannelSwizzle = ChannelSwizzle(bSwizzle);
            var aChannelSwizzle = ChannelSwizzle(aSwizzle);

            return c => new color()
            {
                r = rChannelSwizzle(c),
                g = gChannelSwizzle(c),
                b = bChannelSwizzle(c),
                a = aChannelSwizzle(c),
            };
        }

        private Func<color, float> ChannelSwizzle(TextureImporterSwizzle swizzle)
        {
            switch (swizzle)
            {
                case TextureImporterSwizzle.R:
                    return c => c.r;
                case TextureImporterSwizzle.OneMinusR:
                    return c => 1 - c.r;
                case TextureImporterSwizzle.G:
                    return c => c.g;
                case TextureImporterSwizzle.OneMinusG:
                    return c => 1 - c.g;
                case TextureImporterSwizzle.B:
                    return c => c.b;
                case TextureImporterSwizzle.OneMinusB:
                    return c => 1 - c.b;
                case TextureImporterSwizzle.A:
                    return c => c.a;
                case TextureImporterSwizzle.OneMinusA:
                    return c => 1 - c.a;
                case TextureImporterSwizzle.One:
                    return _ => 1;
                case TextureImporterSwizzle.Zero:
                default:
                    return _ => 0;
            }
        }
    }
}