
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Joint
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Joint")]
public partial class Joint : global::FrooxEngine.Draggable

{
    public global::System.Single MaxSwing { get => MaxSwing_Element.Data; set => MaxSwing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSwing_Element = new();
public global::System.Single MaxTwist { get => MaxTwist_Element.Data; set => MaxTwist_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTwist_Element = new();
public UnityEngine.Vector3 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Axis_Element = new();
public UnityEngine.Vector3 TwistReferenceAxis { get => TwistReferenceAxis_Element.Data; set => TwistReferenceAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TwistReferenceAxis_Element = new();
public global::System.Single PositionTwistThresholdAngle { get => PositionTwistThresholdAngle_Element.Data; set => PositionTwistThresholdAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionTwistThresholdAngle_Element = new();
public global::System.Single VibrationAngle { get => VibrationAngle_Element.Data; set => VibrationAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VibrationAngle_Element = new();
public global::FrooxEngine.VibratePreset VibrationPreset { get => VibrationPreset_Element.Data; set => VibrationPreset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> VibrationPreset_Element = new();
public global::System.Single SnapIncrement { get => SnapIncrement_Element.Data; set => SnapIncrement_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapIncrement_Element = new();
public global::System.Single SnapTime { get => SnapTime_Element.Data; set => SnapTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapTime_Element = new();
public global::System.Boolean SnapOnRelease { get => SnapOnRelease_Element.Data; set => SnapOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SnapOnRelease_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.Joint.SnapOrientation>, global::FrooxEngine.Joint.SnapOrientation> SnapOrientations = new();
public UnityEngine.Quaternion origRotation { get => origRotation_Element.Data; set => origRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> origRotation_Element = new();
public UnityEngine.Quaternion rotReference { get => rotReference_Element.Data; set => rotReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> rotReference_Element = new();
public UnityEngine.Vector3 dirReference { get => dirReference_Element.Data; set => dirReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> dirReference_Element = new();
public UnityEngine.Vector3 twistReference { get => twistReference_Element.Data; set => twistReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> twistReference_Element = new();
public global::System.Boolean usePositionTwist { get => usePositionTwist_Element.Data; set => usePositionTwist_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> usePositionTwist_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSwing", MaxSwing_Element.Data.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist_Element.Data.ToResoniteLinkField());
members.Add("Axis", Axis_Element.Data.ToResoniteLinkField());
members.Add("TwistReferenceAxis", TwistReferenceAxis_Element.Data.ToResoniteLinkField());
members.Add("PositionTwistThresholdAngle", PositionTwistThresholdAngle_Element.Data.ToResoniteLinkField());
members.Add("VibrationAngle", VibrationAngle_Element.Data.ToResoniteLinkField());
members.Add("VibrationPreset", VibrationPreset_Element.Data.ToResoniteLinkField());
members.Add("SnapIncrement", SnapIncrement_Element.Data.ToResoniteLinkField());
members.Add("SnapTime", SnapTime_Element.Data.ToResoniteLinkField());
members.Add("SnapOnRelease", SnapOnRelease_Element.Data.ToResoniteLinkField());
members.Add("SnapOrientations", new ResoniteLink.SyncList()
{
    Elements = SnapOrientations.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("origRotation", origRotation_Element.Data.ToResoniteLinkField());
members.Add("rotReference", rotReference_Element.Data.ToResoniteLinkField());
members.Add("dirReference", dirReference_Element.Data.ToResoniteLinkField());
members.Add("twistReference", twistReference_Element.Data.ToResoniteLinkField());
members.Add("usePositionTwist", usePositionTwist_Element.Data.ToResoniteLinkField());
}

}
}
