
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxSpatialVariable<>
// Generated on: úterý 24. února 2026 18:17:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxSpatialVariable<>")]
public abstract partial class BoxSpatialVariable<T> : global::FrooxEngine.SpatialVariable<T>
	

{
    public UnityEngine.Vector3 Size;
public global::System.Single BlendDistance;
public global::FrooxEngine.SpatialVariableBlendDistanceMode BlendDistanceMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance.ToResoniteLinkField());
members.Add("BlendDistanceMode", BlendDistanceMode.ToResoniteLinkField());
}

}
}
