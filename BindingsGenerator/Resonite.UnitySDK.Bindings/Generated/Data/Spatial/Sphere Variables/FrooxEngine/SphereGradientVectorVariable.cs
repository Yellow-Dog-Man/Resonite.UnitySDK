
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGradientVectorVariable
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereGradientVectorVariable")]
public partial class SphereGradientVectorVariable : global::FrooxEngine.SphereSpatialVariable<UnityEngine.Vector3>

{
    public global::System.Single EdgeMagnitude { get => EdgeMagnitude_Element.Data; set => EdgeMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeMagnitude_Element = new();
public global::System.Single CenterMagnitude { get => CenterMagnitude_Element.Data; set => CenterMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CenterMagnitude_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EdgeMagnitude", EdgeMagnitude_Element.Data.ToResoniteLinkField());
members.Add("CenterMagnitude", CenterMagnitude_Element.Data.ToResoniteLinkField());
}

}
}
