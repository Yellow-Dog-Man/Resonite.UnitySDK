
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxSpatialVariable<>
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxSpatialVariable<>")]
public abstract partial class BoxSpatialVariable<T> : global::FrooxEngine.SpatialVariable<T>
	

{
    public UnityEngine.Vector3 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Size_Element = new();
public global::System.Single BlendDistance { get => BlendDistance_Element.Data; set => BlendDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlendDistance_Element = new();
public global::FrooxEngine.SpatialVariableBlendDistanceMode BlendDistanceMode { get => BlendDistanceMode_Element.Data; set => BlendDistanceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SpatialVariableBlendDistanceMode>, global::FrooxEngine.SpatialVariableBlendDistanceMode> BlendDistanceMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance_Element.Data.ToResoniteLinkField());
members.Add("BlendDistanceMode", BlendDistanceMode_Element.Data.ToResoniteLinkField());
}

}
}
