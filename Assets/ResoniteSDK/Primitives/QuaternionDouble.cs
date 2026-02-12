using ResoniteLink;
using System;

namespace UnityEngine
{
    [Serializable]
    public struct QuaternionDouble
    {
        public double x, y, z, w;

        public doubleQ ToResoniteLink() => new doubleQ() { x = x, y = y, z = z, w = w };
    }
}