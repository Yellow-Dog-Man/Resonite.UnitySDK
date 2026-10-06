using FrooxEngine;
using UnityEngine;
using ResoniteLink;
using System;

namespace ResoniteSDK {
    public class PoiyomiXiexeTinter : AssetMessagePostProcessor
    {
        private bool tintWhite;
        private Color tint;
        private float strength;

        public bool TintWhite { set { IsDirty |= tintWhite != value; tintWhite = value; } }
        public Color Tint { set { IsDirty |= tint != value; tint = value; } }
        public float Strength { set { IsDirty |= strength != value; strength = value; } }
        bool IsDirty;

        public override void Process(ResoniteLink.Message message)
        {
            TexturePostProcessing.ProcessPixels(ApplyTint()).Process(message);
            IsDirty = false;
        }

        public override bool HasChanged() => IsDirty;

        private TexturePostProcessing.ColorFilter ApplyTint()
        {
            Func<float, float, float> channelTinter;
            if (tintWhite)
            {
                channelTinter = (channel, tintChannel) => channel * tintChannel;
            }
            else
            {
                channelTinter = (channel, tintChannel) => channel * (channel + (1 - channel) * tintChannel);
            }
            float channelFilter(float channel, float tintChannel)
            {
                return strength * channelTinter(channel, tintChannel) + (1 - strength);
            }

            return c => new color()
            {
                r = channelFilter(c.r, tint.r),
                g = channelFilter(c.g, tint.g),
                b = channelFilter(c.b, tint.b),
                a = channelFilter(c.a, tint.a),
            };
        }

    }
}