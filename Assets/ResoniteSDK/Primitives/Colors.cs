using System;
using UnityEngine;

[Serializable]
public struct ColorX
{
    public Color color;
#if RESOLINK_BINDINGS_GENERATED
    public ColorProfile profile;
#endif
}