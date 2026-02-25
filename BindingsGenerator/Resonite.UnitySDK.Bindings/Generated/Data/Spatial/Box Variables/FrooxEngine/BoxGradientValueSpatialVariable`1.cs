
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>")]
public partial class BoxGradientValueSpatialVariable<T> : global::FrooxEngine.BoxSpatialVariable<T>
	

{
    public T StartValue;
public T EndValue;
public UnityEngine.Vector3 GradientDirection;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartValue", StartValue.ToResoniteLinkField());
members.Add("EndValue", EndValue.ToResoniteLinkField());
members.Add("GradientDirection", GradientDirection.ToResoniteLinkField());
}

}
}
