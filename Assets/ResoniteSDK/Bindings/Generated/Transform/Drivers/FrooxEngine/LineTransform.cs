
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LineTransform
// Generated on: pátek 13. února 2026 5:52:24
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Point0Anchor", new ResoniteLink.Reference() { });
members.Add("Point1Anchor", new ResoniteLink.Reference() { });
members.Add("LinePositionType", LinePositionType.ToResoniteLinkField());
members.Add("PlanePositionType", PlanePositionType.ToResoniteLinkField());
members.Add("LinePoint", LinePoint.ToResoniteLinkField());
members.Add("OffsetPoint", OffsetPoint.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_rotation", new ResoniteLink.Reference() { });
members.Add("AllowRepositioning", AllowRepositioning.ToResoniteLinkField());
members.Add("RepositionOffset", RepositionOffset.ToResoniteLinkField());
}

}
}
