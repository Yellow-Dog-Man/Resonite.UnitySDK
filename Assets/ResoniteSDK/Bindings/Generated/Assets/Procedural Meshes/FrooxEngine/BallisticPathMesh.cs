
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BallisticPathMesh
// Generated on: sobota 14. února 2026 8:56:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BallisticPathMesh")]
public partial class BallisticPathMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 InitialPosition;
public UnityEngine.Vector3 InitialVelocity;
public UnityEngine.Vector3 Gravity;
public global::System.Single Drag;
public global::FrooxEngine.BallisticPathMesh.StepMode Mode;
public global::System.Single StepSize;
public global::System.Single TotalUnits;
public global::FrooxEngine.BallisticPathMesh.PathShape Shape;
public global::System.Single Size;
public global::System.Int32 Points;
public global::System.Boolean DualSided;
public UnityEngine.Vector3 Up;
public global::System.Single DistanceSizeGrowth;
public global::System.Single MinGrownSize;
public global::System.Single MaxGrownSize;
public global::System.Boolean UseLastSegment;
public UnityEngine.Vector3 LastSegmentPosition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InitialPosition", InitialPosition.ToResoniteLinkField());
members.Add("InitialVelocity", InitialVelocity.ToResoniteLinkField());
members.Add("Gravity", Gravity.ToResoniteLinkField());
members.Add("Drag", Drag.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("StepSize", StepSize.ToResoniteLinkField());
members.Add("TotalUnits", TotalUnits.ToResoniteLinkField());
members.Add("Shape", Shape.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("Up", Up.ToResoniteLinkField());
members.Add("DistanceSizeGrowth", DistanceSizeGrowth.ToResoniteLinkField());
members.Add("MinGrownSize", MinGrownSize.ToResoniteLinkField());
members.Add("MaxGrownSize", MaxGrownSize.ToResoniteLinkField());
members.Add("UseLastSegment", UseLastSegment.ToResoniteLinkField());
members.Add("LastSegmentPosition", LastSegmentPosition.ToResoniteLinkField());
}

}
}
