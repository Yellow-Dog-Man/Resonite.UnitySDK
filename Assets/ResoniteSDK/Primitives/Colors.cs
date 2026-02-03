using System;
using UnityEngine;

[Serializable]
public struct ColorX
{
    public Color color;
#if RESOLINK_BINDINGS_GENERATED
    public Renderite.Shared.ColorProfile profile;
#endif
}