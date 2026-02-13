
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool+SphereInterface
// Generated on: pátek 13. února 2026 23:23:07
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", new ResoniteLink.Reference() { });
}

}
            }
}
