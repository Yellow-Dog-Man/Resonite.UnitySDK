
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorWheelTriangleMesh
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorWheelTriangleMesh")]
public partial class ColorWheelTriangleMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Hue;
public global::System.Single OuterRadius;
public global::System.Single InnerRadius;
public global::System.Int32 RingSegments;
public UnityEngine.Vector3 CursorPosition;
public global::System.Int32 CursorSegments;
public UnityEngine.ColorX CursorColor;
public global::System.Single CursorOuterRadius;
public global::System.Single CursorInnerRadius;
public global::System.Single CursorZOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Hue", Hue.ToResoniteLinkField());
members.Add("OuterRadius", OuterRadius.ToResoniteLinkField());
members.Add("InnerRadius", InnerRadius.ToResoniteLinkField());
members.Add("RingSegments", RingSegments.ToResoniteLinkField());
members.Add("CursorPosition", CursorPosition.ToResoniteLinkField());
members.Add("CursorSegments", CursorSegments.ToResoniteLinkField());
members.Add("CursorColor", CursorColor.ToResoniteLinkField());
members.Add("CursorOuterRadius", CursorOuterRadius.ToResoniteLinkField());
members.Add("CursorInnerRadius", CursorInnerRadius.ToResoniteLinkField());
members.Add("CursorZOffset", CursorZOffset.ToResoniteLinkField());
}

}
}
