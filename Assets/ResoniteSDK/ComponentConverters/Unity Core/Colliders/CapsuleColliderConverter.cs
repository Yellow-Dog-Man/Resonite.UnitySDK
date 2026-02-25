using FrooxEngine.UIX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CapsuleColliderHelper
{
    public static void SetFrom(this FrooxEngine.CapsuleCollider resonite, UnityEngine.CapsuleCollider unity)
    {
        // Set the base data
        resonite.SetFrom((UnityEngine.Collider)unity);

        resonite.Height = unity.height;
        resonite.Radius = unity.radius;
        resonite.Offset = unity.center;
    }
}

public class CapsuleColliderConverter : ResoniteSingleComponentConverter<CapsuleCollider, FrooxEngine.CapsuleColliderWrapper>
{
    protected override void UpdateConversion(CapsuleCollider target, IConversionContext context)
    {
        Binding.Data.SetFrom(target);
    }
}
