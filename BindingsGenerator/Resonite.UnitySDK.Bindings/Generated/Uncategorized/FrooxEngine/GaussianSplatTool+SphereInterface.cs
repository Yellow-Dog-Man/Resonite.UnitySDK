
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool+SphereInterface
// Generated on: středa 25. února 2026 16:14:19
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class GaussianSplatTool
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatTool+SphereInterface")]
public partial class SphereInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Radius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteReference(context));
}

}
            }
}
