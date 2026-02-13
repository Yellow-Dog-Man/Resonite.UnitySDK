
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxSpatialVariable<>
// Generated on: pátek 13. února 2026 5:51:12
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance.ToResoniteLinkField());
members.Add("BlendDistanceMode", BlendDistanceMode.ToResoniteLinkField());
}

}
}
