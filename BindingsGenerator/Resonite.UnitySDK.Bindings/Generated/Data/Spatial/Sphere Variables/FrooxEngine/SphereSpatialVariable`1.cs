
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereSpatialVariable<>
// Generated on: čtvrtek 26. února 2026 10:03:39
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereSpatialVariable<>")]
public abstract partial class SphereSpatialVariable<T> : global::FrooxEngine.SpatialVariable<T>
	

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single BlendDistance { get => BlendDistance_Element.Data; set => BlendDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlendDistance_Element = new();
public global::FrooxEngine.SpatialVariableBlendDistanceMode BlendDistanceMode { get => BlendDistanceMode_Element.Data; set => BlendDistanceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SpatialVariableBlendDistanceMode>, global::FrooxEngine.SpatialVariableBlendDistanceMode> BlendDistanceMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.Data.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance_Element.Data.ToResoniteLinkField());
members.Add("BlendDistanceMode", BlendDistanceMode_Element.Data.ToResoniteLinkField());
}

}
}
