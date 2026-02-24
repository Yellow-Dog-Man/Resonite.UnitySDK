
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineTransform
// Generated on: úterý 24. února 2026 18:20:12
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public global::FrooxEngine.Slot Point0Anchor;
public global::FrooxEngine.Slot Point1Anchor;
public global::FrooxEngine.PositionType LinePositionType;
public global::FrooxEngine.PositionType PlanePositionType;
public global::System.Single LinePoint;
public UnityEngine.Vector3 OffsetPoint;
public UnityEngine.Quaternion RotationOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;
public global::System.Boolean AllowRepositioning;
public global::System.Boolean RepositionOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Point0Anchor", Point0Anchor.ToResoniteReference(context));
members.Add("Point1Anchor", Point1Anchor.ToResoniteReference(context));
members.Add("LinePositionType", LinePositionType.ToResoniteLinkField());
members.Add("PlanePositionType", PlanePositionType.ToResoniteLinkField());
members.Add("LinePoint", LinePoint.ToResoniteLinkField());
members.Add("OffsetPoint", OffsetPoint.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
members.Add("AllowRepositioning", AllowRepositioning.ToResoniteLinkField());
members.Add("RepositionOffset", RepositionOffset.ToResoniteLinkField());
}

}
}
