using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public static class BoxColliderHelper
{
    public static void SetFrom(this FrooxEngine.BoxCollider resonite, UnityEngine.BoxCollider unity)
    {
        // Set the base data
        resonite.SetFrom((UnityEngine.Collider)unity);

        resonite.Size = unity.size;
        resonite.Offset = unity.center;
    }
}

public class BoxColliderConverter : ResoniteSingleComponentConverter<BoxCollider, FrooxEngine.BoxColliderWrapper>
{
    protected override void UpdateConversion(BoxCollider target, IConversionContext context)
    {
        Binding.Data.SetFrom(target);
    }
}
