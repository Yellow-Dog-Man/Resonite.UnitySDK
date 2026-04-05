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
        return (
            lightingMode == PoiyomiLightingMode.Realistic ||
            lightingMode == PoiyomiLightingMode.Cloth);
    }
}
