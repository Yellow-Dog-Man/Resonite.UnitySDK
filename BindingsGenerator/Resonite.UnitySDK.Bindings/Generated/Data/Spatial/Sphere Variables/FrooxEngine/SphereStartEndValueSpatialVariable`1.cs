
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereStartEndValueSpatialVariable<>
// Generated on: středa 25. února 2026 16:13:08
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
    public T StartValue;
public T EndValue;
public global::System.Single StartDistance;
public global::System.Single EndDistance;
public global::FrooxEngine.SpatialVariableDistanceMode Mode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartValue", StartValue.ToResoniteLinkField());
members.Add("EndValue", EndValue.ToResoniteLinkField());
members.Add("StartDistance", StartDistance.ToResoniteLinkField());
members.Add("EndDistance", EndDistance.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
}

}
}
