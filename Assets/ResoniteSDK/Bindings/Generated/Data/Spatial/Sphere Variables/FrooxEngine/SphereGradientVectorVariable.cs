
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGradientVectorVariable
// Generated on: úterý 24. února 2026 18:17:48
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereGradientVectorVariable")]
public partial class SphereGradientVectorVariable : global::FrooxEngine.SphereSpatialVariable<UnityEngine.Vector3>

{
    public global::System.Single EdgeMagnitude;
public global::System.Single CenterMagnitude;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EdgeMagnitude", EdgeMagnitude.ToResoniteLinkField());
members.Add("CenterMagnitude", CenterMagnitude.ToResoniteLinkField());
}

}
}
