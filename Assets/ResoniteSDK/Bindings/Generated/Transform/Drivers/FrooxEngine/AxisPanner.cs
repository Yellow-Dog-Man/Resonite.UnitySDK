
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisPanner
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisPanner")]
public partial class AxisPanner : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Double> TimeBase;
public global::System.Single Speed;
public global::System.Single Range;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Axis;
public UnityEngine.Vector3 ReferenceScale;
public global::System.Single FullScaleRangeRatio;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TimeBase", TimeBase.ToResoniteReference(context));
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Range", Range.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("ReferenceScale", ReferenceScale.ToResoniteLinkField());
members.Add("FullScaleRangeRatio", FullScaleRangeRatio.ToResoniteLinkField());
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_scale", _scale.ToResoniteReference(context));
}

}
}
