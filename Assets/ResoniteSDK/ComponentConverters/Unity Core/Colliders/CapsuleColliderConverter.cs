using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class CapsuleCollider
    {
        public void SetFrom(UnityEngine.CapsuleCollider collider)
        {
            base.SetFrom(collider);

            Height = collider.height;
            Radius = collider.radius;
            Offset = collider.center;
        }
    }
}

public class CapsuleColliderConverter : ResoniteSingleComponentConverter<CapsuleCollider, FrooxEngine.CapsuleColliderWrapper>
{
    protected override void UpdateConversion(CapsuleCollider target, IConversionContext context)
    {
        Binding.Data.SetFrom(target);
    }
}
