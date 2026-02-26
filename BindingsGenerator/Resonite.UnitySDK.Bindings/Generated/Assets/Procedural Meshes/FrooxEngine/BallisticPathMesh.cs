
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BallisticPathMesh
// Generated on: čtvrtek 26. února 2026 15:07:55
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public UnityEngine.Vector3 InitialPosition { get => InitialPosition_Element.Data; set => InitialPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> InitialPosition_Element = new();
public UnityEngine.Vector3 InitialVelocity { get => InitialVelocity_Element.Data; set => InitialVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> InitialVelocity_Element = new();
public UnityEngine.Vector3 Gravity { get => Gravity_Element.Data; set => Gravity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Gravity_Element = new();
public global::System.Single Drag { get => Drag_Element.Data; set => Drag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Drag_Element = new();
public global::FrooxEngine.BallisticPathMesh.StepMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BallisticPathMesh.StepMode>, global::FrooxEngine.BallisticPathMesh.StepMode> Mode_Element = new();
public global::System.Single StepSize { get => StepSize_Element.Data; set => StepSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepSize_Element = new();
public global::System.Single TotalUnits { get => TotalUnits_Element.Data; set => TotalUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TotalUnits_Element = new();
public global::FrooxEngine.BallisticPathMesh.PathShape Shape { get => Shape_Element.Data; set => Shape_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BallisticPathMesh.PathShape>, global::FrooxEngine.BallisticPathMesh.PathShape> Shape_Element = new();
public global::System.Single Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Size_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public UnityEngine.Vector3 Up { get => Up_Element.Data; set => Up_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Up_Element = new();
public global::System.Single DistanceSizeGrowth { get => DistanceSizeGrowth_Element.Data; set => DistanceSizeGrowth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DistanceSizeGrowth_Element = new();
public global::System.Single MinGrownSize { get => MinGrownSize_Element.Data; set => MinGrownSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinGrownSize_Element = new();
public global::System.Single MaxGrownSize { get => MaxGrownSize_Element.Data; set => MaxGrownSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxGrownSize_Element = new();
public global::System.Boolean UseLastSegment { get => UseLastSegment_Element.Data; set => UseLastSegment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLastSegment_Element = new();
public UnityEngine.Vector3 LastSegmentPosition { get => LastSegmentPosition_Element.Data; set => LastSegmentPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LastSegmentPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InitialPosition", InitialPosition_Element.ToLinkField(context));
members.Add("InitialVelocity", InitialVelocity_Element.ToLinkField(context));
members.Add("Gravity", Gravity_Element.ToLinkField(context));
members.Add("Drag", Drag_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("StepSize", StepSize_Element.ToLinkField(context));
members.Add("TotalUnits", TotalUnits_Element.ToLinkField(context));
members.Add("Shape", Shape_Element.ToLinkField(context));
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
members.Add("Up", Up_Element.ToLinkField(context));
members.Add("DistanceSizeGrowth", DistanceSizeGrowth_Element.ToLinkField(context));
members.Add("MinGrownSize", MinGrownSize_Element.ToLinkField(context));
members.Add("MaxGrownSize", MaxGrownSize_Element.ToLinkField(context));
members.Add("UseLastSegment", UseLastSegment_Element.ToLinkField(context));
members.Add("LastSegmentPosition", LastSegmentPosition_Element.ToLinkField(context));
}

}
}
