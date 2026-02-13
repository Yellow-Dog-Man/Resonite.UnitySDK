
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationGlobalParameters
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationGlobalParameters")]
public partial class LocomotionAnimationGlobalParameters : global::FrooxEngine.SyncObject

{
    public global::System.Single MinimumTravelSpeed;
public global::System.Single TargetPosChangeSpeed;
public global::System.Single MinFullTravelDistanceSpeed;
public global::System.Single MaxVerticalReferenceSpeed;
public global::System.Single StillVelocityThreshold;
public global::System.Single StillFootForwardsMaxDistance;
public global::System.Single StillFootSidewaysMaxDistanceRatio;
public global::System.Single StillFootSidewaysMaxExcessDistance;
public global::System.Single StillFootMaxAngleTravel;
public global::System.Single StillMinimumFootingTime;
public global::System.Single HandMotionTransfer;
public global::System.Single HandMaxVelocity;
public global::System.Single HandAirMotionTransfer;
public global::System.Single HandAirDrag;
public global::System.Single HandAirForce;
public UnityEngine.Vector3 HandAirUpwardsPose;
public UnityEngine.Vector3 HandAirDownwardsPose;
public UnityEngine.Vector3 HandAirCenterOffset;
public UnityEngine.Vector3 HandAirUp;
public global::System.Single HandFloatingMotionTransfer;
public global::System.Single HandFloatingDrag;
public global::System.Single HandFloatingForce;
public UnityEngine.Vector3 HandFloatingPose;
public UnityEngine.Vector3 HandFloatingCenterOffset;
public UnityEngine.Vector3 HandFloatingUp;
public global::System.Single FootMaxDistance;
public global::System.Single FootTiltMinAngle;
public global::System.Single FootTiltMaxAngle;
public global::System.Single FootAvoidanceRadius;
public global::System.Single HandHorizontalSwingRatio;
public UnityEngine.Vector3 HandSwayMin;
public UnityEngine.Vector3 HandSwayMax;
public global::System.Single HandSwayMinSpeed;
public global::System.Single HandSwayMaxSpeed;
public global::System.Single HandSwaySpeedSpeed;
public UnityEngine.Vector3 HandCrouchOffset;
public global::System.Single HandCrouchSwingMultiplier;
public UnityEngine.Vector3 HandCrouchUp;
public UnityEngine.Vector3 HandCrouchCenterOffset;
public global::System.Single HandCrouchMinForce;
public global::System.Single HandCrouchMinDrag;
public UnityEngine.Vector3 FootRandomPositionOffsetMagnitude;
public global::System.Single RandomFootAngleOffsetMagnitude;
public global::System.Single FootAirMotionTransfer;
public global::System.Single FootAirDrag;
public global::System.Single FootAirForce;
public global::System.Single FootAirMinDistance;
public global::System.Single FootAirMaxDistance;
public global::System.Single FootAirVelocityDistanceRatio;
public global::System.Single FootAirUpwardsTiltAngle;
public global::System.Single FootAirDownwardsTiltAngle;
public global::System.Single FootAirRotationSpeed;
public global::System.Single FootAirVerticalOffset;
public global::System.Single FeetAirMaxVelocity;
public global::System.Single FootFloatingMotionTransfer;
public global::System.Single FootFloatingDrag;
public global::System.Single FootFloatingForce;
public global::System.Single FootFloatingMinAngle;
public global::System.Single FootFloatingMaxAngle;
public global::System.Single FootFloatingAngleSpeed;
public UnityEngine.Vector3 FootFloatingOffset;
public UnityEngine.Vector3 FootFloatingOffsetMagnitude;
public global::System.Single FootFloatingPositionSpeed;
public global::System.Single FootFloatingRotationSpeed;
public global::System.Single FootFloatingMaxDistance;
public global::System.Single HeadJumpAngle;
public global::System.Single HeadVerticalForce;
public global::System.Single HeadVerticalDrag;
public global::System.Single HeadVerticalTransferRatio;
public global::System.Single HeadMaxVerticalVelocity;
public global::System.Single HeadMaxVerticalOffset;
public global::System.Single HeadMinVerticalOffset;
public global::System.Single HeadFloatingVerticalForce;
public global::System.Single HeadFloatingVerticalDrag;
public global::System.Single HeadFloatingVerticalTransferRatio;
public global::System.Single HeadSwayVerticalAngle;
public global::System.Single HeadSwayHorizontalAngle;
public global::System.Single HeadSwayMinSpeed;
public global::System.Single HeadSwayMaxSpeed;
public global::System.Single HeadSwaySpeedSpeed;
public global::System.Single HeadMaxLookDirectionAngle;
public global::System.Single HeadLookSpeed;
public global::FrooxEngine.IFingerPoseSourceComponent InAirFingerBasePose;
public global::System.Single InAirFingerCurlOffset;
public global::System.Single InAirFingerCurlSwayMagnitude;
public global::System.Single InAirFingerCurlSwaySpeed;
public global::System.Single InAirFingerCurlVariationMagnitude;
public global::System.Single InAirFingerCurlVariationSpeed;
public global::System.Single InAirFingerUpwardsSplayMagnitude;
public global::System.Single InAirFingerUpwardsVelocityReference;
public global::System.Single InAirFingerDownwardsSplayMagnitude;
public global::System.Single InAirFingerDownwardsVelocityReference;
public global::FrooxEngine.IFingerPoseSourceComponent FloatingFingerBasePose;
public global::System.Single FloatingFingerCurlOffset;
public global::System.Single FloatingFingerSplayOffset;
public global::System.Single FloatingFingerCurlSwayMagnitude;
public global::System.Single FloatingFingerCurlSwaySpeed;
public global::System.Single FloatingFingerCurlVariationMagnitude;
public global::System.Single FloatingFingerCurlVariationSpeed;
public global::System.Single FloatingFingerCurlSpeedMagnitude;
public global::System.Single FloatingFingerCurlSpeedReference;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinimumTravelSpeed", MinimumTravelSpeed.ToResoniteLinkField());
members.Add("TargetPosChangeSpeed", TargetPosChangeSpeed.ToResoniteLinkField());
members.Add("MinFullTravelDistanceSpeed", MinFullTravelDistanceSpeed.ToResoniteLinkField());
members.Add("MaxVerticalReferenceSpeed", MaxVerticalReferenceSpeed.ToResoniteLinkField());
members.Add("StillVelocityThreshold", StillVelocityThreshold.ToResoniteLinkField());
members.Add("StillFootForwardsMaxDistance", StillFootForwardsMaxDistance.ToResoniteLinkField());
members.Add("StillFootSidewaysMaxDistanceRatio", StillFootSidewaysMaxDistanceRatio.ToResoniteLinkField());
members.Add("StillFootSidewaysMaxExcessDistance", StillFootSidewaysMaxExcessDistance.ToResoniteLinkField());
members.Add("StillFootMaxAngleTravel", StillFootMaxAngleTravel.ToResoniteLinkField());
members.Add("StillMinimumFootingTime", StillMinimumFootingTime.ToResoniteLinkField());
members.Add("HandMotionTransfer", HandMotionTransfer.ToResoniteLinkField());
members.Add("HandMaxVelocity", HandMaxVelocity.ToResoniteLinkField());
members.Add("HandAirMotionTransfer", HandAirMotionTransfer.ToResoniteLinkField());
members.Add("HandAirDrag", HandAirDrag.ToResoniteLinkField());
members.Add("HandAirForce", HandAirForce.ToResoniteLinkField());
members.Add("HandAirUpwardsPose", HandAirUpwardsPose.ToResoniteLinkField());
members.Add("HandAirDownwardsPose", HandAirDownwardsPose.ToResoniteLinkField());
members.Add("HandAirCenterOffset", HandAirCenterOffset.ToResoniteLinkField());
members.Add("HandAirUp", HandAirUp.ToResoniteLinkField());
members.Add("HandFloatingMotionTransfer", HandFloatingMotionTransfer.ToResoniteLinkField());
members.Add("HandFloatingDrag", HandFloatingDrag.ToResoniteLinkField());
members.Add("HandFloatingForce", HandFloatingForce.ToResoniteLinkField());
members.Add("HandFloatingPose", HandFloatingPose.ToResoniteLinkField());
members.Add("HandFloatingCenterOffset", HandFloatingCenterOffset.ToResoniteLinkField());
members.Add("HandFloatingUp", HandFloatingUp.ToResoniteLinkField());
members.Add("FootMaxDistance", FootMaxDistance.ToResoniteLinkField());
members.Add("FootTiltMinAngle", FootTiltMinAngle.ToResoniteLinkField());
members.Add("FootTiltMaxAngle", FootTiltMaxAngle.ToResoniteLinkField());
members.Add("FootAvoidanceRadius", FootAvoidanceRadius.ToResoniteLinkField());
members.Add("HandHorizontalSwingRatio", HandHorizontalSwingRatio.ToResoniteLinkField());
members.Add("HandSwayMin", HandSwayMin.ToResoniteLinkField());
members.Add("HandSwayMax", HandSwayMax.ToResoniteLinkField());
members.Add("HandSwayMinSpeed", HandSwayMinSpeed.ToResoniteLinkField());
members.Add("HandSwayMaxSpeed", HandSwayMaxSpeed.ToResoniteLinkField());
members.Add("HandSwaySpeedSpeed", HandSwaySpeedSpeed.ToResoniteLinkField());
members.Add("HandCrouchOffset", HandCrouchOffset.ToResoniteLinkField());
members.Add("HandCrouchSwingMultiplier", HandCrouchSwingMultiplier.ToResoniteLinkField());
members.Add("HandCrouchUp", HandCrouchUp.ToResoniteLinkField());
members.Add("HandCrouchCenterOffset", HandCrouchCenterOffset.ToResoniteLinkField());
members.Add("HandCrouchMinForce", HandCrouchMinForce.ToResoniteLinkField());
members.Add("HandCrouchMinDrag", HandCrouchMinDrag.ToResoniteLinkField());
members.Add("FootRandomPositionOffsetMagnitude", FootRandomPositionOffsetMagnitude.ToResoniteLinkField());
members.Add("RandomFootAngleOffsetMagnitude", RandomFootAngleOffsetMagnitude.ToResoniteLinkField());
members.Add("FootAirMotionTransfer", FootAirMotionTransfer.ToResoniteLinkField());
members.Add("FootAirDrag", FootAirDrag.ToResoniteLinkField());
members.Add("FootAirForce", FootAirForce.ToResoniteLinkField());
members.Add("FootAirMinDistance", FootAirMinDistance.ToResoniteLinkField());
members.Add("FootAirMaxDistance", FootAirMaxDistance.ToResoniteLinkField());
members.Add("FootAirVelocityDistanceRatio", FootAirVelocityDistanceRatio.ToResoniteLinkField());
members.Add("FootAirUpwardsTiltAngle", FootAirUpwardsTiltAngle.ToResoniteLinkField());
members.Add("FootAirDownwardsTiltAngle", FootAirDownwardsTiltAngle.ToResoniteLinkField());
members.Add("FootAirRotationSpeed", FootAirRotationSpeed.ToResoniteLinkField());
members.Add("FootAirVerticalOffset", FootAirVerticalOffset.ToResoniteLinkField());
members.Add("FeetAirMaxVelocity", FeetAirMaxVelocity.ToResoniteLinkField());
members.Add("FootFloatingMotionTransfer", FootFloatingMotionTransfer.ToResoniteLinkField());
members.Add("FootFloatingDrag", FootFloatingDrag.ToResoniteLinkField());
members.Add("FootFloatingForce", FootFloatingForce.ToResoniteLinkField());
members.Add("FootFloatingMinAngle", FootFloatingMinAngle.ToResoniteLinkField());
members.Add("FootFloatingMaxAngle", FootFloatingMaxAngle.ToResoniteLinkField());
members.Add("FootFloatingAngleSpeed", FootFloatingAngleSpeed.ToResoniteLinkField());
members.Add("FootFloatingOffset", FootFloatingOffset.ToResoniteLinkField());
members.Add("FootFloatingOffsetMagnitude", FootFloatingOffsetMagnitude.ToResoniteLinkField());
members.Add("FootFloatingPositionSpeed", FootFloatingPositionSpeed.ToResoniteLinkField());
members.Add("FootFloatingRotationSpeed", FootFloatingRotationSpeed.ToResoniteLinkField());
members.Add("FootFloatingMaxDistance", FootFloatingMaxDistance.ToResoniteLinkField());
members.Add("HeadJumpAngle", HeadJumpAngle.ToResoniteLinkField());
members.Add("HeadVerticalForce", HeadVerticalForce.ToResoniteLinkField());
members.Add("HeadVerticalDrag", HeadVerticalDrag.ToResoniteLinkField());
members.Add("HeadVerticalTransferRatio", HeadVerticalTransferRatio.ToResoniteLinkField());
members.Add("HeadMaxVerticalVelocity", HeadMaxVerticalVelocity.ToResoniteLinkField());
members.Add("HeadMaxVerticalOffset", HeadMaxVerticalOffset.ToResoniteLinkField());
members.Add("HeadMinVerticalOffset", HeadMinVerticalOffset.ToResoniteLinkField());
members.Add("HeadFloatingVerticalForce", HeadFloatingVerticalForce.ToResoniteLinkField());
members.Add("HeadFloatingVerticalDrag", HeadFloatingVerticalDrag.ToResoniteLinkField());
members.Add("HeadFloatingVerticalTransferRatio", HeadFloatingVerticalTransferRatio.ToResoniteLinkField());
members.Add("HeadSwayVerticalAngle", HeadSwayVerticalAngle.ToResoniteLinkField());
members.Add("HeadSwayHorizontalAngle", HeadSwayHorizontalAngle.ToResoniteLinkField());
members.Add("HeadSwayMinSpeed", HeadSwayMinSpeed.ToResoniteLinkField());
members.Add("HeadSwayMaxSpeed", HeadSwayMaxSpeed.ToResoniteLinkField());
members.Add("HeadSwaySpeedSpeed", HeadSwaySpeedSpeed.ToResoniteLinkField());
members.Add("HeadMaxLookDirectionAngle", HeadMaxLookDirectionAngle.ToResoniteLinkField());
members.Add("HeadLookSpeed", HeadLookSpeed.ToResoniteLinkField());
members.Add("InAirFingerBasePose", new ResoniteLink.Reference() { });
members.Add("InAirFingerCurlOffset", InAirFingerCurlOffset.ToResoniteLinkField());
members.Add("InAirFingerCurlSwayMagnitude", InAirFingerCurlSwayMagnitude.ToResoniteLinkField());
members.Add("InAirFingerCurlSwaySpeed", InAirFingerCurlSwaySpeed.ToResoniteLinkField());
members.Add("InAirFingerCurlVariationMagnitude", InAirFingerCurlVariationMagnitude.ToResoniteLinkField());
members.Add("InAirFingerCurlVariationSpeed", InAirFingerCurlVariationSpeed.ToResoniteLinkField());
members.Add("InAirFingerUpwardsSplayMagnitude", InAirFingerUpwardsSplayMagnitude.ToResoniteLinkField());
members.Add("InAirFingerUpwardsVelocityReference", InAirFingerUpwardsVelocityReference.ToResoniteLinkField());
members.Add("InAirFingerDownwardsSplayMagnitude", InAirFingerDownwardsSplayMagnitude.ToResoniteLinkField());
members.Add("InAirFingerDownwardsVelocityReference", InAirFingerDownwardsVelocityReference.ToResoniteLinkField());
members.Add("FloatingFingerBasePose", new ResoniteLink.Reference() { });
members.Add("FloatingFingerCurlOffset", FloatingFingerCurlOffset.ToResoniteLinkField());
members.Add("FloatingFingerSplayOffset", FloatingFingerSplayOffset.ToResoniteLinkField());
members.Add("FloatingFingerCurlSwayMagnitude", FloatingFingerCurlSwayMagnitude.ToResoniteLinkField());
members.Add("FloatingFingerCurlSwaySpeed", FloatingFingerCurlSwaySpeed.ToResoniteLinkField());
members.Add("FloatingFingerCurlVariationMagnitude", FloatingFingerCurlVariationMagnitude.ToResoniteLinkField());
members.Add("FloatingFingerCurlVariationSpeed", FloatingFingerCurlVariationSpeed.ToResoniteLinkField());
members.Add("FloatingFingerCurlSpeedMagnitude", FloatingFingerCurlSpeedMagnitude.ToResoniteLinkField());
members.Add("FloatingFingerCurlSpeedReference", FloatingFingerCurlSpeedReference.ToResoniteLinkField());
}

}
}
