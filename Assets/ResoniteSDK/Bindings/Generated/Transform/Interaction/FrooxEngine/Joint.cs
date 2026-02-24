
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Joint
// Generated on: úterý 24. února 2026 18:20:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Joint")]
public partial class Joint : global::FrooxEngine.Draggable

{
    public global::System.Single MaxSwing;
public global::System.Single MaxTwist;
public UnityEngine.Vector3 Axis;
public UnityEngine.Vector3 TwistReferenceAxis;
public global::System.Single PositionTwistThresholdAngle;
public global::System.Single VibrationAngle;
public global::FrooxEngine.VibratePreset VibrationPreset;
public global::System.Single SnapIncrement;
public global::System.Single SnapTime;
public global::System.Boolean SnapOnRelease;
public System.Collections.Generic.List<global::FrooxEngine.Joint.SnapOrientation> SnapOrientations;
public UnityEngine.Quaternion origRotation;
public UnityEngine.Quaternion rotReference;
public UnityEngine.Vector3 dirReference;
public UnityEngine.Vector3 twistReference;
public global::System.Boolean usePositionTwist;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("TwistReferenceAxis", TwistReferenceAxis.ToResoniteLinkField());
members.Add("PositionTwistThresholdAngle", PositionTwistThresholdAngle.ToResoniteLinkField());
members.Add("VibrationAngle", VibrationAngle.ToResoniteLinkField());
members.Add("VibrationPreset", VibrationPreset.ToResoniteLinkField());
members.Add("SnapIncrement", SnapIncrement.ToResoniteLinkField());
members.Add("SnapTime", SnapTime.ToResoniteLinkField());
members.Add("SnapOnRelease", SnapOnRelease.ToResoniteLinkField());
members.Add("SnapOrientations", new ResoniteLink.SyncList()
{
    Elements = SnapOrientations.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("origRotation", origRotation.ToResoniteLinkField());
members.Add("rotReference", rotReference.ToResoniteLinkField());
members.Add("dirReference", dirReference.ToResoniteLinkField());
members.Add("twistReference", twistReference.ToResoniteLinkField());
members.Add("usePositionTwist", usePositionTwist.ToResoniteLinkField());
}

}
}
