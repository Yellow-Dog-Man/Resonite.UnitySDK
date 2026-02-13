using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class SphereCollider
    {
        public void SetFrom(UnityEngine.SphereCollider collider)
        {
            base.SetFrom(collider);

            Radius = collider.radius;
            Offset = collider.center;
        }
    }
}

public class SphereColliderConverter : ResoniteSingleComponentConverter<SphereCollider, FrooxEngine.SphereColliderWrapper>
{
    protected override void UpdateConversion(SphereCollider target, IConversionContext context)
    {
        Binding.Data.SetFrom(target);
    }
}
