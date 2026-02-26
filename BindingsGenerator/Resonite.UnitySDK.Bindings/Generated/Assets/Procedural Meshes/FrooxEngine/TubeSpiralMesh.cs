
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeSpiralMesh
// Generated on: čtvrtek 26. února 2026 10:03:36
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeSpiralMesh")]
public partial class TubeSpiralMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 Steps { get => Steps_Element.Data; set => Steps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Steps_Element = new();
public global::System.Nullable<global::System.Single> MaximumDistanceBetweenRings { get => MaximumDistanceBetweenRings_Element.Data; set => MaximumDistanceBetweenRings_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> MaximumDistanceBetweenRings_Element = new();
public global::System.Boolean RadiusIndependentStepScaling { get => RadiusIndependentStepScaling_Element.Data; set => RadiusIndependentStepScaling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RadiusIndependentStepScaling_Element = new();
public global::System.Single CoilCount { get => CoilCount_Element.Data; set => CoilCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CoilCount_Element = new();
public global::System.Boolean ScaleCoilCountByLength { get => ScaleCoilCountByLength_Element.Data; set => ScaleCoilCountByLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleCoilCountByLength_Element = new();
public global::System.Single CoilPhase { get => CoilPhase_Element.Data; set => CoilPhase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CoilPhase_Element = new();
public UnityEngine.Vector3 StartPoint { get => StartPoint_Element.Data; set => StartPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> StartPoint_Element = new();
public UnityEngine.Vector3 StartTangent { get => StartTangent_Element.Data; set => StartTangent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> StartTangent_Element = new();
public UnityEngine.Vector3 EndPoint { get => EndPoint_Element.Data; set => EndPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> EndPoint_Element = new();
public UnityEngine.Vector3 EndTangent { get => EndTangent_Element.Data; set => EndTangent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> EndTangent_Element = new();
public global::System.Single StartSpiralRadius { get => StartSpiralRadius_Element.Data; set => StartSpiralRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartSpiralRadius_Element = new();
public global::System.Single EndSpiralRadius { get => EndSpiralRadius_Element.Data; set => EndSpiralRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndSpiralRadius_Element = new();
public UnityEngine.Quaternion StartSpiralOrientation { get => StartSpiralOrientation_Element.Data; set => StartSpiralOrientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> StartSpiralOrientation_Element = new();
public UnityEngine.Quaternion EndSpiralOrientation { get => EndSpiralOrientation_Element.Data; set => EndSpiralOrientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> EndSpiralOrientation_Element = new();
public global::Elements.Assets.SegmentedBuilder.Ends Ends { get => Ends_Element.Data; set => Ends_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Ends>, global::Elements.Assets.SegmentedBuilder.Ends> Ends_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();
public global::System.Single StartTubeRadius { get => StartTubeRadius_Element.Data; set => StartTubeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartTubeRadius_Element = new();
public global::System.Single EndTubeRadius { get => EndTubeRadius_Element.Data; set => EndTubeRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndTubeRadius_Element = new();
public global::System.Int32 TubePoints { get => TubePoints_Element.Data; set => TubePoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TubePoints_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Steps", Steps_Element.Data.ToResoniteLinkField());
members.Add("MaximumDistanceBetweenRings", MaximumDistanceBetweenRings_Element.Data.ToResoniteLinkField());
members.Add("RadiusIndependentStepScaling", RadiusIndependentStepScaling_Element.Data.ToResoniteLinkField());
members.Add("CoilCount", CoilCount_Element.Data.ToResoniteLinkField());
members.Add("ScaleCoilCountByLength", ScaleCoilCountByLength_Element.Data.ToResoniteLinkField());
members.Add("CoilPhase", CoilPhase_Element.Data.ToResoniteLinkField());
members.Add("StartPoint", StartPoint_Element.Data.ToResoniteLinkField());
members.Add("StartTangent", StartTangent_Element.Data.ToResoniteLinkField());
members.Add("EndPoint", EndPoint_Element.Data.ToResoniteLinkField());
members.Add("EndTangent", EndTangent_Element.Data.ToResoniteLinkField());
members.Add("StartSpiralRadius", StartSpiralRadius_Element.Data.ToResoniteLinkField());
members.Add("EndSpiralRadius", EndSpiralRadius_Element.Data.ToResoniteLinkField());
members.Add("StartSpiralOrientation", StartSpiralOrientation_Element.Data.ToResoniteLinkField());
members.Add("EndSpiralOrientation", EndSpiralOrientation_Element.Data.ToResoniteLinkField());
members.Add("Ends", Ends_Element.Data.ToResoniteLinkField());
members.Add("Shading", Shading_Element.Data.ToResoniteLinkField());
members.Add("StartTubeRadius", StartTubeRadius_Element.Data.ToResoniteLinkField());
members.Add("EndTubeRadius", EndTubeRadius_Element.Data.ToResoniteLinkField());
members.Add("TubePoints", TubePoints_Element.Data.ToResoniteLinkField());
}

}
}
