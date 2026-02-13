using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class BoxCollider
    {
        public void SetFrom(UnityEngine.BoxCollider collider)
        {
            base.SetFrom(collider);

            Size = collider.size;
            Offset = collider.center;
        }
    }
}

public class BoxColliderConverter : ResoniteSingleComponentConverter<BoxCollider, FrooxEngine.BoxColliderWrapper>
{
    protected override void UpdateConversion(BoxCollider target, IConversionContext context)
    {
        Binding.Data.SetFrom(target);
    }
}
