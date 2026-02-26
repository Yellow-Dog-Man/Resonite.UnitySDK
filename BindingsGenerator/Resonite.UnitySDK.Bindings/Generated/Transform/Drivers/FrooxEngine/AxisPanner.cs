
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisPanner
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisPanner")]
public partial class AxisPanner : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Double> TimeBase { get => TimeBase_Element.Data; set => TimeBase_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IValue<global::System.Double>>, global::FrooxEngine.IValue<global::System.Double>> TimeBase_Element = new();
public global::System.Single Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Speed_Element = new();
public global::System.Single Range { get => Range_Element.Data; set => Range_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Range_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public UnityEngine.Vector3 ReferenceScale { get => ReferenceScale_Element.Data; set => ReferenceScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ReferenceScale_Element = new();
public global::System.Single FullScaleRangeRatio { get => FullScaleRangeRatio_Element.Data; set => FullScaleRangeRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FullScaleRangeRatio_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TimeBase", TimeBase_Element.ToLinkReference(context));
members.Add("Speed", Speed_Element.ToLinkField(context));
members.Add("Range", Range_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Axis", Axis_Element.ToLinkField(context));
members.Add("ReferenceScale", ReferenceScale_Element.ToLinkField(context));
members.Add("FullScaleRangeRatio", FullScaleRangeRatio_Element.ToLinkField(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_scale", _scale_Element.ToLinkReference(context));
}

}
}
