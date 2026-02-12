using System;

namespace UnityEngine
{
    [Serializable]
    public struct ColorX
    {
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