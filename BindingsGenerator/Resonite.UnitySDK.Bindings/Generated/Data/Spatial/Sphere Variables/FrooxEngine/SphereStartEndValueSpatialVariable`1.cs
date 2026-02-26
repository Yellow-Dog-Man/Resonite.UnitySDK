
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereStartEndValueSpatialVariable<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereStartEndValueSpatialVariable<>")]
public partial class SphereStartEndValueSpatialVariable<T> : global::FrooxEngine.SphereSpatialVariable<T>
	

{
    public T StartValue { get => StartValue_Element.Data; set => StartValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> StartValue_Element = new();
public T EndValue { get => EndValue_Element.Data; set => EndValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> EndValue_Element = new();
public global::System.Single StartDistance { get => StartDistance_Element.Data; set => StartDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartDistance_Element = new();
public global::System.Single EndDistance { get => EndDistance_Element.Data; set => EndDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndDistance_Element = new();
public global::FrooxEngine.SpatialVariableDistanceMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SpatialVariableDistanceMode>, global::FrooxEngine.SpatialVariableDistanceMode> Mode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartValue", StartValue_Element.Data.ToResoniteLinkField());
members.Add("EndValue", EndValue_Element.Data.ToResoniteLinkField());
members.Add("StartDistance", StartDistance_Element.Data.ToResoniteLinkField());
members.Add("EndDistance", EndDistance_Element.Data.ToResoniteLinkField());
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
}

}
}
