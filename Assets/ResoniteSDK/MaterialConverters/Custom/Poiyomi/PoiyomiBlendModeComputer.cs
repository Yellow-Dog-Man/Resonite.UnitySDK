using FrooxEngine;
using UnityEngine;

public class PoiyomiBlendModeComputer
{
    public static BlendMode FromPoiyomi(UnityEngine.Material material)
    {
        if (material.GetFloat("_AlphaForceOpaque") > 0)
        {
            return BlendMode.Opaque;
        }
        
        if (material.GetFloat("_DstBlend") == 10)
        {
            // TransClipping, Fade, Transparent
            return BlendMode.Transparent; 
        }
        
        if (material.GetFloat("_DstBlend") == 1)
        {
            // Additive, Soft Additive
            return BlendMode.Additive;
        }

        if (material.GetFloat("_SrcBlend") == 2)
        {
            // Multiplicative, 2x Multiplicative
            return BlendMode.Multiply;
        }

        if (
            material.GetFloat("_AlphaToCoverage") > 0 ||
            material.GetFloat("_AlphaDithering") > 0 ||
            material.GetFloat("_AlphaDistanceFade") > 0
        )
        {
            // TODO: Figure out how Poiyomi's advanced alpha parameters work exactly,
            return BlendMode.Alpha;
        }
        else
        {
            return BlendMode.Cutout;
        }
    }
}