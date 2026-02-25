using System;

namespace UnityEngine
{
    public enum ColorProfile
    {
        sRGB,
        Linear
    };

    [Serializable]
    public struct ColorX
    {
        public ColorX(Color color)
        {
            this.color = color;
            this.profile = ColorProfile.sRGB;
        }

        public ColorX(Color color, ColorProfile profile)
        {
            this.color = color;
            this.profile = profile;
        }

        public Color color;
        public ColorProfile profile;

        public ResoniteLink.colorX ToResoniteLink() => new ResoniteLink.colorX()
        {
            r = color.r,
            g = color.g,
            b = color.b,
            a = color.a,

            Profile = profile.ToString()
        };
    }

    public static class ColorXHelper
    {
        public static ColorX ToColorX(this Color color, ColorProfile profile) => new ColorX(color, profile);

        public static ColorX ToColorX_Auto(this Color color) =>
            color.ToColorX(QualitySettings.activeColorSpace ==
                ColorSpace.Gamma ? ColorProfile.sRGB : ColorProfile.Linear);

        public static ColorX ToColorX_Linear(this Color color) => color.ToColorX(ColorProfile.Linear);
        public static ColorX ToColorX_sRGB(this Color color) => color.ToColorX(ColorProfile.sRGB);
    }
}