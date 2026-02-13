
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisPanner
// Generated on: pátek 13. února 2026 23:23:08
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TimeBase", new ResoniteLink.Reference() { });
members.Add("Speed", Speed.ToResoniteLinkField());
members.Add("Range", Range.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("ReferenceScale", ReferenceScale.ToResoniteLinkField());
members.Add("FullScaleRangeRatio", FullScaleRangeRatio.ToResoniteLinkField());
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_scale", new ResoniteLink.Reference() { });
}

}
}
