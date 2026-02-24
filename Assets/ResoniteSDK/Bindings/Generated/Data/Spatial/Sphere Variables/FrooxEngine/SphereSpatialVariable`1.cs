
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereSpatialVariable<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereSpatialVariable<>")]
public abstract partial class SphereSpatialVariable<T> : global::FrooxEngine.SpatialVariable<T>
	

{
    public global::System.Single Radius;
public global::System.Single BlendDistance;
public global::FrooxEngine.SpatialVariableBlendDistanceMode BlendDistanceMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance.ToResoniteLinkField());
members.Add("BlendDistanceMode", BlendDistanceMode.ToResoniteLinkField());
}

}
}
