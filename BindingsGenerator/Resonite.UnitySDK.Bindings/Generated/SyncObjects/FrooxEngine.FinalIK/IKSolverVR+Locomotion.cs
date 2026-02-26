
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Locomotion
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    public partial class IKSolverVR
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Locomotion")]
public partial class Locomotion : global::FrooxEngine.SyncObject

{
    public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::System.Single FootDistance { get => FootDistance_Element.Data; set => FootDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootDistance_Element = new();
public global::System.Single StepThreshold { get => StepThreshold_Element.Data; set => StepThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepThreshold_Element = new();
public global::System.Single AngleThreshold { get => AngleThreshold_Element.Data; set => AngleThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleThreshold_Element = new();
public global::System.Single ComAngleMlp { get => ComAngleMlp_Element.Data; set => ComAngleMlp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ComAngleMlp_Element = new();
public global::System.Single MaxVelocity { get => MaxVelocity_Element.Data; set => MaxVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVelocity_Element = new();
public global::System.Single VelocityFactor { get => VelocityFactor_Element.Data; set => VelocityFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityFactor_Element = new();
public global::System.Single MaxLegStretch { get => MaxLegStretch_Element.Data; set => MaxLegStretch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxLegStretch_Element = new();
public global::System.Single RootSpeed { get => RootSpeed_Element.Data; set => RootSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RootSpeed_Element = new();
public global::System.Single StepSpeed { get => StepSpeed_Element.Data; set => StepSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepSpeed_Element = new();
public global::SyncArray<global::FrooxEngine.SyncCurve<global::System.Single>, global::FrooxEngine.CurveKey<global::System.Single>> StepHeight = new();
public global::SyncArray<global::FrooxEngine.SyncCurve<global::System.Single>, global::FrooxEngine.CurveKey<global::System.Single>> HeelHeight = new();
public global::System.Single RelaxLegTwistMinAngle { get => RelaxLegTwistMinAngle_Element.Data; set => RelaxLegTwistMinAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelaxLegTwistMinAngle_Element = new();
public global::System.Single RelaxLegTwistSpeed { get => RelaxLegTwistSpeed_Element.Data; set => RelaxLegTwistSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelaxLegTwistSpeed_Element = new();
public global::FrooxEngine.FinalIK.InterpolationMode StepInterpolation { get => StepInterpolation_Element.Data; set => StepInterpolation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FinalIK.InterpolationMode>, global::FrooxEngine.FinalIK.InterpolationMode> StepInterpolation_Element = new();
public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public UnityEngine.Vector3 LeftFootOffset { get => LeftFootOffset_Element.Data; set => LeftFootOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LeftFootOffset_Element = new();
public UnityEngine.Vector3 RightFootOffset { get => RightFootOffset_Element.Data; set => RightFootOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RightFootOffset_Element = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Footstep _leftFootstep = new();
public global::FrooxEngine.FinalIK.IKSolverVR.Footstep _rightFootstep = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight_Element.ToLinkField(context));
members.Add("FootDistance", FootDistance_Element.ToLinkField(context));
members.Add("StepThreshold", StepThreshold_Element.ToLinkField(context));
members.Add("AngleThreshold", AngleThreshold_Element.ToLinkField(context));
members.Add("ComAngleMlp", ComAngleMlp_Element.ToLinkField(context));
members.Add("MaxVelocity", MaxVelocity_Element.ToLinkField(context));
members.Add("VelocityFactor", VelocityFactor_Element.ToLinkField(context));
members.Add("MaxLegStretch", MaxLegStretch_Element.ToLinkField(context));
members.Add("RootSpeed", RootSpeed_Element.ToLinkField(context));
members.Add("StepSpeed", StepSpeed_Element.ToLinkField(context));
members.Add("StepHeight", StepHeight.ToLinkArray(context));
members.Add("HeelHeight", HeelHeight.ToLinkArray(context));
members.Add("RelaxLegTwistMinAngle", RelaxLegTwistMinAngle_Element.ToLinkField(context));
members.Add("RelaxLegTwistSpeed", RelaxLegTwistSpeed_Element.ToLinkField(context));
members.Add("StepInterpolation", StepInterpolation_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("LeftFootOffset", LeftFootOffset_Element.ToLinkField(context));
members.Add("RightFootOffset", RightFootOffset_Element.ToLinkField(context));
members.Add("_leftFootstep", _leftFootstep.ToLinkSyncObject(context));
members.Add("_rightFootstep", _rightFootstep.ToLinkSyncObject(context));
}

}
            }
}
