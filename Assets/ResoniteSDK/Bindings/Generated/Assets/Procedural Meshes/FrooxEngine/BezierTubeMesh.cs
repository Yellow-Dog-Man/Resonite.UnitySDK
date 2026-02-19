
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BezierTubeMesh
// Generated on: čtvrtek 19. února 2026 7:58:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BezierTubeMesh")]
public partial class BezierTubeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius;
public global::FrooxEngine.CurveKey<UnityEngine.Vector3>[] Points;
public global::System.Int32 SegmentPoints;
public global::System.Int32 StepsPerUnitLength;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkArray());
members.Add("SegmentPoints", SegmentPoints.ToResoniteLinkField());
members.Add("StepsPerUnitLength", StepsPerUnitLength.ToResoniteLinkField());
}

}
}
