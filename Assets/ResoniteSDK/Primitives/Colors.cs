using System;

namespace UnityEngine
{
    [Serializable]
    public struct ColorX
    {
        public ColorX(Color color)
        {
            this.color = color;

#if RESOLINK_BINDINGS_GENERATED
            this.profile = Renderite.Shared.ColorProfile.sRGB;
#endif
        }

#if RESOLINK_BINDINGS_GENERATED
        public ColorX(Color color, Renderite.Shared.ColorProfile profile)
        {
            this.color = color;
            this.profile = profile;
        }
#endif

        public Color color;
#if RESOLINK_BINDINGS_GENERATED
    public Renderite.Shared.ColorProfile profile;
#endif

        public ResoniteLink.colorX ToResoniteLink() => new ResoniteLink.colorX()
        {
            r = color.r,
            g = color.g,
            b = color.b,
            a = color.a,

#if RESOLINK_BINDINGS_GENERATED
            Profile = profile.ToString()
#endif
        };
    }
}