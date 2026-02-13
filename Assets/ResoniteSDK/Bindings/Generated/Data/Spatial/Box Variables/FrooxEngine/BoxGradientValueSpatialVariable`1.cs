
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>
// Generated on: pátek 13. února 2026 23:21:39
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxGradientValueSpatialVariable<>")]
public partial class BoxGradientValueSpatialVariable<T> : global::FrooxEngine.BoxSpatialVariable<T>
	

{
    public T StartValue;
public T EndValue;
public UnityEngine.Vector3 GradientDirection;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("StartValue", StartValue.ToResoniteLinkField());
members.Add("EndValue", EndValue.ToResoniteLinkField());
members.Add("GradientDirection", GradientDirection.ToResoniteLinkField());
}

}
}
