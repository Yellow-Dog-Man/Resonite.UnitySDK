using System;

namespace UnityEngine
{
    [Serializable]
    public struct ColorX
    {
        public ColorX(Color color)
        {
            this.color = color;
            this.profile = Renderite.Shared.ColorProfile.sRGB;
        }

        public ColorX(Color color, Renderite.Shared.ColorProfile profile)
        {
            this.color = color;
            this.profile = profile;
        }

        public Color color;
        public Renderite.Shared.ColorProfile profile;

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
        public static ColorX ToColorX(this Color color, Renderite.Shared.ColorProfile profile) =>
            new ColorX(color, profile);

        public static ColorX ToColorX_Auto(this Color color) =>
            color.ToColorX(QualitySettings.activeColorSpace ==
                ColorSpace.Gamma ? Renderite.Shared.ColorProfile.sRGB : Renderite.Shared.ColorProfile.Linear);

        public static ColorX ToColorX_Linear(this Color color) => color.ToColorX(Renderite.Shared.ColorProfile.Linear);
        public static ColorX ToColorX_sRGB(this Color color) => color.ToColorX(Renderite.Shared.ColorProfile.sRGB);
    }
}