
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeSpiralMesh
// Generated on: pátek 13. února 2026 5:51:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeSpiralMesh")]
public partial class TubeSpiralMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Steps;
public global::System.Nullable<global::System.Single> MaximumDistanceBetweenRings;
public global::System.Boolean RadiusIndependentStepScaling;
public global::System.Single CoilCount;
public global::System.Boolean ScaleCoilCountByLength;
public global::System.Single CoilPhase;
public UnityEngine.Vector3 StartPoint;
public UnityEngine.Vector3 StartTangent;
public UnityEngine.Vector3 EndPoint;
public UnityEngine.Vector3 EndTangent;
public global::System.Single StartSpiralRadius;
public global::System.Single EndSpiralRadius;
public UnityEngine.Quaternion StartSpiralOrientation;
public UnityEngine.Quaternion EndSpiralOrientation;
public global::Elements.Assets.SegmentedBuilder.Ends Ends;
public global::Elements.Assets.SegmentedBuilder.Shading Shading;
public global::System.Single StartTubeRadius;
public global::System.Single EndTubeRadius;
public global::System.Int32 TubePoints;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Steps", Steps.ToResoniteLinkField());
members.Add("MaximumDistanceBetweenRings", MaximumDistanceBetweenRings.ToResoniteLinkField());
members.Add("RadiusIndependentStepScaling", RadiusIndependentStepScaling.ToResoniteLinkField());
members.Add("CoilCount", CoilCount.ToResoniteLinkField());
members.Add("ScaleCoilCountByLength", ScaleCoilCountByLength.ToResoniteLinkField());
members.Add("CoilPhase", CoilPhase.ToResoniteLinkField());
members.Add("StartPoint", StartPoint.ToResoniteLinkField());
members.Add("StartTangent", StartTangent.ToResoniteLinkField());
members.Add("EndPoint", EndPoint.ToResoniteLinkField());
members.Add("EndTangent", EndTangent.ToResoniteLinkField());
members.Add("StartSpiralRadius", StartSpiralRadius.ToResoniteLinkField());
members.Add("EndSpiralRadius", EndSpiralRadius.ToResoniteLinkField());
members.Add("StartSpiralOrientation", StartSpiralOrientation.ToResoniteLinkField());
members.Add("EndSpiralOrientation", EndSpiralOrientation.ToResoniteLinkField());
members.Add("Ends", Ends.ToResoniteLinkField());
members.Add("Shading", Shading.ToResoniteLinkField());
members.Add("StartTubeRadius", StartTubeRadius.ToResoniteLinkField());
members.Add("EndTubeRadius", EndTubeRadius.ToResoniteLinkField());
members.Add("TubePoints", TubePoints.ToResoniteLinkField());
}

}
}
