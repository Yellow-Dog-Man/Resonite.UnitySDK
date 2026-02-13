
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationGaitParameters
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationGaitParameters")]
public partial class LocomotionAnimationGaitParameters : global::FrooxEngine.SyncObject

{
    public global::System.Single ReferenceSpeed;
public global::System.Single MinOpposingProgress;
public global::System.Single VelocityIncreaseSmoothTime;
public global::System.Single VelocityDecreaseSmoothTime;
public global::System.Single FootTravelDistance;
public global::System.Single FootSidewaysDistanceRatio;
public global::System.Single FootBackwardsDistanceRatio;
public global::System.Single FootMaxAngle;
public global::System.Single FootTurnInfluence;
public UnityEngine.Vector3 Offset;
public global::System.Single FootStepUpHeight;
public global::System.Single FootStepDownHeight;
public global::System.Single FootStepUpPow;
public global::System.Single FootStepDownPow;
public global::System.Single FootStepUpVelocityMultiplier;
public global::System.Single FootStepUpVelocityVerticalRatio;
public global::System.Single FootGroundAngle;
public global::System.Single FootGroundPow;
public global::System.Single FootStepUpAngularVelocityMultiplier;
public global::System.Single FootStepDownAngle;
public global::System.Single HandForwardForce;
public global::System.Single HandBackwardForce;
public global::System.Single HandDrag;
public global::System.Single HandSwingDistance;
public UnityEngine.Vector3 HandOffset;
public UnityEngine.Vector3 HandDirectionCenterOffset;
public UnityEngine.Vector3 HandSwingDirection;
public UnityEngine.Vector3 HandSwingArcPeak;
public global::FrooxEngine.IFingerPoseSourceComponent FingerBasePose;
public global::System.Single FingerCurlOffset;
public global::System.Single FingerCurlSwayMagnitude;
public global::System.Single FingerCurlSwaySpeed;
public global::System.Single FingerCurlVariationMagnitude;
public global::System.Single FingerCurlVariationSpeed;
public global::System.Single HeadSmoothingSpeed;
public global::System.Single HeadHorizontalBobOffset;
public global::System.Single HeadHorizontalBobAngle;
public global::System.Single HeadVerticalBobOffset;
public global::System.Single HeadVerticalBobAngle;
public global::System.Single VerticalHeadAngleOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceSpeed", ReferenceSpeed.ToResoniteLinkField());
members.Add("MinOpposingProgress", MinOpposingProgress.ToResoniteLinkField());
members.Add("VelocityIncreaseSmoothTime", VelocityIncreaseSmoothTime.ToResoniteLinkField());
members.Add("VelocityDecreaseSmoothTime", VelocityDecreaseSmoothTime.ToResoniteLinkField());
members.Add("FootTravelDistance", FootTravelDistance.ToResoniteLinkField());
members.Add("FootSidewaysDistanceRatio", FootSidewaysDistanceRatio.ToResoniteLinkField());
members.Add("FootBackwardsDistanceRatio", FootBackwardsDistanceRatio.ToResoniteLinkField());
members.Add("FootMaxAngle", FootMaxAngle.ToResoniteLinkField());
members.Add("FootTurnInfluence", FootTurnInfluence.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("FootStepUpHeight", FootStepUpHeight.ToResoniteLinkField());
members.Add("FootStepDownHeight", FootStepDownHeight.ToResoniteLinkField());
members.Add("FootStepUpPow", FootStepUpPow.ToResoniteLinkField());
members.Add("FootStepDownPow", FootStepDownPow.ToResoniteLinkField());
members.Add("FootStepUpVelocityMultiplier", FootStepUpVelocityMultiplier.ToResoniteLinkField());
members.Add("FootStepUpVelocityVerticalRatio", FootStepUpVelocityVerticalRatio.ToResoniteLinkField());
members.Add("FootGroundAngle", FootGroundAngle.ToResoniteLinkField());
members.Add("FootGroundPow", FootGroundPow.ToResoniteLinkField());
members.Add("FootStepUpAngularVelocityMultiplier", FootStepUpAngularVelocityMultiplier.ToResoniteLinkField());
members.Add("FootStepDownAngle", FootStepDownAngle.ToResoniteLinkField());
members.Add("HandForwardForce", HandForwardForce.ToResoniteLinkField());
members.Add("HandBackwardForce", HandBackwardForce.ToResoniteLinkField());
members.Add("HandDrag", HandDrag.ToResoniteLinkField());
members.Add("HandSwingDistance", HandSwingDistance.ToResoniteLinkField());
members.Add("HandOffset", HandOffset.ToResoniteLinkField());
members.Add("HandDirectionCenterOffset", HandDirectionCenterOffset.ToResoniteLinkField());
members.Add("HandSwingDirection", HandSwingDirection.ToResoniteLinkField());
members.Add("HandSwingArcPeak", HandSwingArcPeak.ToResoniteLinkField());
members.Add("FingerBasePose", new ResoniteLink.Reference() { });
members.Add("FingerCurlOffset", FingerCurlOffset.ToResoniteLinkField());
members.Add("FingerCurlSwayMagnitude", FingerCurlSwayMagnitude.ToResoniteLinkField());
members.Add("FingerCurlSwaySpeed", FingerCurlSwaySpeed.ToResoniteLinkField());
members.Add("FingerCurlVariationMagnitude", FingerCurlVariationMagnitude.ToResoniteLinkField());
members.Add("FingerCurlVariationSpeed", FingerCurlVariationSpeed.ToResoniteLinkField());
members.Add("HeadSmoothingSpeed", HeadSmoothingSpeed.ToResoniteLinkField());
members.Add("HeadHorizontalBobOffset", HeadHorizontalBobOffset.ToResoniteLinkField());
members.Add("HeadHorizontalBobAngle", HeadHorizontalBobAngle.ToResoniteLinkField());
members.Add("HeadVerticalBobOffset", HeadVerticalBobOffset.ToResoniteLinkField());
members.Add("HeadVerticalBobAngle", HeadVerticalBobAngle.ToResoniteLinkField());
members.Add("VerticalHeadAngleOffset", VerticalHeadAngleOffset.ToResoniteLinkField());
}

}
}
