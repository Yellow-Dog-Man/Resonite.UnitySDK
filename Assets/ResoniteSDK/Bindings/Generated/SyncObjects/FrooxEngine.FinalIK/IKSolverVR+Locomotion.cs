
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Locomotion
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Single Weight;
public global::System.Single FootDistance;
public global::System.Single StepThreshold;
public global::System.Single AngleThreshold;
public global::System.Single ComAngleMlp;
public global::System.Single MaxVelocity;
public global::System.Single VelocityFactor;
public global::System.Single MaxLegStretch;
public global::System.Single RootSpeed;
public global::System.Single StepSpeed;
public global::FrooxEngine.CurveKey<global::System.Single>[] StepHeight;
public global::FrooxEngine.CurveKey<global::System.Single>[] HeelHeight;
public global::System.Single RelaxLegTwistMinAngle;
public global::System.Single RelaxLegTwistSpeed;
public global::FrooxEngine.FinalIK.InterpolationMode StepInterpolation;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 LeftFootOffset;
public UnityEngine.Vector3 RightFootOffset;
public global::FrooxEngine.FinalIK.IKSolverVR.Footstep _leftFootstep;
public global::FrooxEngine.FinalIK.IKSolverVR.Footstep _rightFootstep;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("FootDistance", FootDistance.ToResoniteLinkField());
members.Add("StepThreshold", StepThreshold.ToResoniteLinkField());
members.Add("AngleThreshold", AngleThreshold.ToResoniteLinkField());
members.Add("ComAngleMlp", ComAngleMlp.ToResoniteLinkField());
members.Add("MaxVelocity", MaxVelocity.ToResoniteLinkField());
members.Add("VelocityFactor", VelocityFactor.ToResoniteLinkField());
members.Add("MaxLegStretch", MaxLegStretch.ToResoniteLinkField());
members.Add("RootSpeed", RootSpeed.ToResoniteLinkField());
members.Add("StepSpeed", StepSpeed.ToResoniteLinkField());
members.Add("StepHeight", StepHeight.ToResoniteLinkArray());
members.Add("HeelHeight", HeelHeight.ToResoniteLinkArray());
members.Add("RelaxLegTwistMinAngle", RelaxLegTwistMinAngle.ToResoniteLinkField());
members.Add("RelaxLegTwistSpeed", RelaxLegTwistSpeed.ToResoniteLinkField());
members.Add("StepInterpolation", StepInterpolation.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("LeftFootOffset", LeftFootOffset.ToResoniteLinkField());
members.Add("RightFootOffset", RightFootOffset.ToResoniteLinkField());
members.Add("_leftFootstep", new ResoniteLink.SyncObject() { Members = _leftFootstep.CollectMembers(context) });
members.Add("_rightFootstep", new ResoniteLink.SyncObject() { Members = _rightFootstep.CollectMembers(context) });
}

}
            }
}
