
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineTransform
// Generated on: čtvrtek 26. února 2026 12:28:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LineTransform")]
public partial class LineTransform : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point0_Element = new();
public UnityEngine.Vector3 Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point1_Element = new();
public global::FrooxEngine.Slot Point0Anchor { get => Point0Anchor_Element.Data; set => Point0Anchor_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Point0Anchor_Element = new();
public global::FrooxEngine.Slot Point1Anchor { get => Point1Anchor_Element.Data; set => Point1Anchor_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Point1Anchor_Element = new();
public global::FrooxEngine.PositionType LinePositionType { get => LinePositionType_Element.Data; set => LinePositionType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PositionType>, global::FrooxEngine.PositionType> LinePositionType_Element = new();
public global::FrooxEngine.PositionType PlanePositionType { get => PlanePositionType_Element.Data; set => PlanePositionType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PositionType>, global::FrooxEngine.PositionType> PlanePositionType_Element = new();
public global::System.Single LinePoint { get => LinePoint_Element.Data; set => LinePoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LinePoint_Element = new();
public UnityEngine.Vector3 OffsetPoint { get => OffsetPoint_Element.Data; set => OffsetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> OffsetPoint_Element = new();
public UnityEngine.Quaternion RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RotationOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();
public global::System.Boolean AllowRepositioning { get => AllowRepositioning_Element.Data; set => AllowRepositioning_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowRepositioning_Element = new();
public global::System.Boolean RepositionOffset { get => RepositionOffset_Element.Data; set => RepositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RepositionOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0_Element.ToLinkField(context));
members.Add("Point1", Point1_Element.ToLinkField(context));
members.Add("Point0Anchor", Point0Anchor_Element.ToLinkReference(context));
members.Add("Point1Anchor", Point1Anchor_Element.ToLinkReference(context));
members.Add("LinePositionType", LinePositionType_Element.ToLinkField(context));
members.Add("PlanePositionType", PlanePositionType_Element.ToLinkField(context));
members.Add("LinePoint", LinePoint_Element.ToLinkField(context));
members.Add("OffsetPoint", OffsetPoint_Element.ToLinkField(context));
members.Add("RotationOffset", RotationOffset_Element.ToLinkField(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
members.Add("AllowRepositioning", AllowRepositioning_Element.ToLinkField(context));
members.Add("RepositionOffset", RepositionOffset_Element.ToLinkField(context));
}

}
}
