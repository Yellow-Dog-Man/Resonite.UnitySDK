using FrooxEngine;
using UnityEngine;

public enum PoiyomiLightingMode
{
    TextureRamp,
    MultilayerMath,
    Wrapped,
    Skin,
    ShadeMap,
    Flat,
    Realistic,
    Cloth,
    SDF
}

public static class PoiyomiLightingModeMethods
{
    public static bool IsPhysicallyBased(this PoiyomiLightingMode lightingMode)
    {
        switch (lightingMode)
        {
            case PoiyomiLightingMode.Realistic:
            case PoiyomiLightingMode.Cloth:
            case PoiyomiLightingMode.Skin:
            case PoiyomiLightingMode.Wrapped:
            case PoiyomiLightingMode.SDF:
                return true;
            default:
                return false;
        }
    }
}
