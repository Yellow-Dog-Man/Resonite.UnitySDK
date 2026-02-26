
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationGlobalParameters
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationGlobalParameters")]
public partial class LocomotionAnimationGlobalParameters : global::FrooxEngine.SyncObject

{
    public global::System.Single MinimumTravelSpeed { get => MinimumTravelSpeed_Element.Data; set => MinimumTravelSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumTravelSpeed_Element = new();
public global::System.Single TargetPosChangeSpeed { get => TargetPosChangeSpeed_Element.Data; set => TargetPosChangeSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TargetPosChangeSpeed_Element = new();
public global::System.Single MinFullTravelDistanceSpeed { get => MinFullTravelDistanceSpeed_Element.Data; set => MinFullTravelDistanceSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinFullTravelDistanceSpeed_Element = new();
public global::System.Single MaxVerticalReferenceSpeed { get => MaxVerticalReferenceSpeed_Element.Data; set => MaxVerticalReferenceSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVerticalReferenceSpeed_Element = new();
public global::System.Single StillVelocityThreshold { get => StillVelocityThreshold_Element.Data; set => StillVelocityThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillVelocityThreshold_Element = new();
public global::System.Single StillFootForwardsMaxDistance { get => StillFootForwardsMaxDistance_Element.Data; set => StillFootForwardsMaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillFootForwardsMaxDistance_Element = new();
public global::System.Single StillFootSidewaysMaxDistanceRatio { get => StillFootSidewaysMaxDistanceRatio_Element.Data; set => StillFootSidewaysMaxDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillFootSidewaysMaxDistanceRatio_Element = new();
public global::System.Single StillFootSidewaysMaxExcessDistance { get => StillFootSidewaysMaxExcessDistance_Element.Data; set => StillFootSidewaysMaxExcessDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillFootSidewaysMaxExcessDistance_Element = new();
public global::System.Single StillFootMaxAngleTravel { get => StillFootMaxAngleTravel_Element.Data; set => StillFootMaxAngleTravel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillFootMaxAngleTravel_Element = new();
public global::System.Single StillMinimumFootingTime { get => StillMinimumFootingTime_Element.Data; set => StillMinimumFootingTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StillMinimumFootingTime_Element = new();
public global::System.Single HandMotionTransfer { get => HandMotionTransfer_Element.Data; set => HandMotionTransfer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandMotionTransfer_Element = new();
public global::System.Single HandMaxVelocity { get => HandMaxVelocity_Element.Data; set => HandMaxVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandMaxVelocity_Element = new();
public global::System.Single HandAirMotionTransfer { get => HandAirMotionTransfer_Element.Data; set => HandAirMotionTransfer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandAirMotionTransfer_Element = new();
public global::System.Single HandAirDrag { get => HandAirDrag_Element.Data; set => HandAirDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandAirDrag_Element = new();
public global::System.Single HandAirForce { get => HandAirForce_Element.Data; set => HandAirForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandAirForce_Element = new();
public UnityEngine.Vector3 HandAirUpwardsPose { get => HandAirUpwardsPose_Element.Data; set => HandAirUpwardsPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandAirUpwardsPose_Element = new();
public UnityEngine.Vector3 HandAirDownwardsPose { get => HandAirDownwardsPose_Element.Data; set => HandAirDownwardsPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandAirDownwardsPose_Element = new();
public UnityEngine.Vector3 HandAirCenterOffset { get => HandAirCenterOffset_Element.Data; set => HandAirCenterOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandAirCenterOffset_Element = new();
public UnityEngine.Vector3 HandAirUp { get => HandAirUp_Element.Data; set => HandAirUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandAirUp_Element = new();
public global::System.Single HandFloatingMotionTransfer { get => HandFloatingMotionTransfer_Element.Data; set => HandFloatingMotionTransfer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandFloatingMotionTransfer_Element = new();
public global::System.Single HandFloatingDrag { get => HandFloatingDrag_Element.Data; set => HandFloatingDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandFloatingDrag_Element = new();
public global::System.Single HandFloatingForce { get => HandFloatingForce_Element.Data; set => HandFloatingForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandFloatingForce_Element = new();
public UnityEngine.Vector3 HandFloatingPose { get => HandFloatingPose_Element.Data; set => HandFloatingPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandFloatingPose_Element = new();
public UnityEngine.Vector3 HandFloatingCenterOffset { get => HandFloatingCenterOffset_Element.Data; set => HandFloatingCenterOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandFloatingCenterOffset_Element = new();
public UnityEngine.Vector3 HandFloatingUp { get => HandFloatingUp_Element.Data; set => HandFloatingUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandFloatingUp_Element = new();
public global::System.Single FootMaxDistance { get => FootMaxDistance_Element.Data; set => FootMaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootMaxDistance_Element = new();
public global::System.Single FootTiltMinAngle { get => FootTiltMinAngle_Element.Data; set => FootTiltMinAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootTiltMinAngle_Element = new();
public global::System.Single FootTiltMaxAngle { get => FootTiltMaxAngle_Element.Data; set => FootTiltMaxAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootTiltMaxAngle_Element = new();
public global::System.Single FootAvoidanceRadius { get => FootAvoidanceRadius_Element.Data; set => FootAvoidanceRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAvoidanceRadius_Element = new();
public global::System.Single HandHorizontalSwingRatio { get => HandHorizontalSwingRatio_Element.Data; set => HandHorizontalSwingRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandHorizontalSwingRatio_Element = new();
public UnityEngine.Vector3 HandSwayMin { get => HandSwayMin_Element.Data; set => HandSwayMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandSwayMin_Element = new();
public UnityEngine.Vector3 HandSwayMax { get => HandSwayMax_Element.Data; set => HandSwayMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandSwayMax_Element = new();
public global::System.Single HandSwayMinSpeed { get => HandSwayMinSpeed_Element.Data; set => HandSwayMinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandSwayMinSpeed_Element = new();
public global::System.Single HandSwayMaxSpeed { get => HandSwayMaxSpeed_Element.Data; set => HandSwayMaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandSwayMaxSpeed_Element = new();
public global::System.Single HandSwaySpeedSpeed { get => HandSwaySpeedSpeed_Element.Data; set => HandSwaySpeedSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandSwaySpeedSpeed_Element = new();
public UnityEngine.Vector3 HandCrouchOffset { get => HandCrouchOffset_Element.Data; set => HandCrouchOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandCrouchOffset_Element = new();
public global::System.Single HandCrouchSwingMultiplier { get => HandCrouchSwingMultiplier_Element.Data; set => HandCrouchSwingMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandCrouchSwingMultiplier_Element = new();
public UnityEngine.Vector3 HandCrouchUp { get => HandCrouchUp_Element.Data; set => HandCrouchUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandCrouchUp_Element = new();
public UnityEngine.Vector3 HandCrouchCenterOffset { get => HandCrouchCenterOffset_Element.Data; set => HandCrouchCenterOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HandCrouchCenterOffset_Element = new();
public global::System.Single HandCrouchMinForce { get => HandCrouchMinForce_Element.Data; set => HandCrouchMinForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandCrouchMinForce_Element = new();
public global::System.Single HandCrouchMinDrag { get => HandCrouchMinDrag_Element.Data; set => HandCrouchMinDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandCrouchMinDrag_Element = new();
public UnityEngine.Vector3 FootRandomPositionOffsetMagnitude { get => FootRandomPositionOffsetMagnitude_Element.Data; set => FootRandomPositionOffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FootRandomPositionOffsetMagnitude_Element = new();
public global::System.Single RandomFootAngleOffsetMagnitude { get => RandomFootAngleOffsetMagnitude_Element.Data; set => RandomFootAngleOffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomFootAngleOffsetMagnitude_Element = new();
public global::System.Single FootAirMotionTransfer { get => FootAirMotionTransfer_Element.Data; set => FootAirMotionTransfer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirMotionTransfer_Element = new();
public global::System.Single FootAirDrag { get => FootAirDrag_Element.Data; set => FootAirDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirDrag_Element = new();
public global::System.Single FootAirForce { get => FootAirForce_Element.Data; set => FootAirForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirForce_Element = new();
public global::System.Single FootAirMinDistance { get => FootAirMinDistance_Element.Data; set => FootAirMinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirMinDistance_Element = new();
public global::System.Single FootAirMaxDistance { get => FootAirMaxDistance_Element.Data; set => FootAirMaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirMaxDistance_Element = new();
public global::System.Single FootAirVelocityDistanceRatio { get => FootAirVelocityDistanceRatio_Element.Data; set => FootAirVelocityDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirVelocityDistanceRatio_Element = new();
public global::System.Single FootAirUpwardsTiltAngle { get => FootAirUpwardsTiltAngle_Element.Data; set => FootAirUpwardsTiltAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirUpwardsTiltAngle_Element = new();
public global::System.Single FootAirDownwardsTiltAngle { get => FootAirDownwardsTiltAngle_Element.Data; set => FootAirDownwardsTiltAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirDownwardsTiltAngle_Element = new();
public global::System.Single FootAirRotationSpeed { get => FootAirRotationSpeed_Element.Data; set => FootAirRotationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirRotationSpeed_Element = new();
public global::System.Single FootAirVerticalOffset { get => FootAirVerticalOffset_Element.Data; set => FootAirVerticalOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootAirVerticalOffset_Element = new();
public global::System.Single FeetAirMaxVelocity { get => FeetAirMaxVelocity_Element.Data; set => FeetAirMaxVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetAirMaxVelocity_Element = new();
public global::System.Single FootFloatingMotionTransfer { get => FootFloatingMotionTransfer_Element.Data; set => FootFloatingMotionTransfer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingMotionTransfer_Element = new();
public global::System.Single FootFloatingDrag { get => FootFloatingDrag_Element.Data; set => FootFloatingDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingDrag_Element = new();
public global::System.Single FootFloatingForce { get => FootFloatingForce_Element.Data; set => FootFloatingForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingForce_Element = new();
public global::System.Single FootFloatingMinAngle { get => FootFloatingMinAngle_Element.Data; set => FootFloatingMinAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingMinAngle_Element = new();
public global::System.Single FootFloatingMaxAngle { get => FootFloatingMaxAngle_Element.Data; set => FootFloatingMaxAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingMaxAngle_Element = new();
public global::System.Single FootFloatingAngleSpeed { get => FootFloatingAngleSpeed_Element.Data; set => FootFloatingAngleSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingAngleSpeed_Element = new();
public UnityEngine.Vector3 FootFloatingOffset { get => FootFloatingOffset_Element.Data; set => FootFloatingOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FootFloatingOffset_Element = new();
public UnityEngine.Vector3 FootFloatingOffsetMagnitude { get => FootFloatingOffsetMagnitude_Element.Data; set => FootFloatingOffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FootFloatingOffsetMagnitude_Element = new();
public global::System.Single FootFloatingPositionSpeed { get => FootFloatingPositionSpeed_Element.Data; set => FootFloatingPositionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingPositionSpeed_Element = new();
public global::System.Single FootFloatingRotationSpeed { get => FootFloatingRotationSpeed_Element.Data; set => FootFloatingRotationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingRotationSpeed_Element = new();
public global::System.Single FootFloatingMaxDistance { get => FootFloatingMaxDistance_Element.Data; set => FootFloatingMaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatingMaxDistance_Element = new();
public global::System.Single HeadJumpAngle { get => HeadJumpAngle_Element.Data; set => HeadJumpAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadJumpAngle_Element = new();
public global::System.Single HeadVerticalForce { get => HeadVerticalForce_Element.Data; set => HeadVerticalForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadVerticalForce_Element = new();
public global::System.Single HeadVerticalDrag { get => HeadVerticalDrag_Element.Data; set => HeadVerticalDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadVerticalDrag_Element = new();
public global::System.Single HeadVerticalTransferRatio { get => HeadVerticalTransferRatio_Element.Data; set => HeadVerticalTransferRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadVerticalTransferRatio_Element = new();
public global::System.Single HeadMaxVerticalVelocity { get => HeadMaxVerticalVelocity_Element.Data; set => HeadMaxVerticalVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadMaxVerticalVelocity_Element = new();
public global::System.Single HeadMaxVerticalOffset { get => HeadMaxVerticalOffset_Element.Data; set => HeadMaxVerticalOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadMaxVerticalOffset_Element = new();
public global::System.Single HeadMinVerticalOffset { get => HeadMinVerticalOffset_Element.Data; set => HeadMinVerticalOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadMinVerticalOffset_Element = new();
public global::System.Single HeadFloatingVerticalForce { get => HeadFloatingVerticalForce_Element.Data; set => HeadFloatingVerticalForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadFloatingVerticalForce_Element = new();
public global::System.Single HeadFloatingVerticalDrag { get => HeadFloatingVerticalDrag_Element.Data; set => HeadFloatingVerticalDrag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadFloatingVerticalDrag_Element = new();
public global::System.Single HeadFloatingVerticalTransferRatio { get => HeadFloatingVerticalTransferRatio_Element.Data; set => HeadFloatingVerticalTransferRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadFloatingVerticalTransferRatio_Element = new();
public global::System.Single HeadSwayVerticalAngle { get => HeadSwayVerticalAngle_Element.Data; set => HeadSwayVerticalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSwayVerticalAngle_Element = new();
public global::System.Single HeadSwayHorizontalAngle { get => HeadSwayHorizontalAngle_Element.Data; set => HeadSwayHorizontalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSwayHorizontalAngle_Element = new();
public global::System.Single HeadSwayMinSpeed { get => HeadSwayMinSpeed_Element.Data; set => HeadSwayMinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSwayMinSpeed_Element = new();
public global::System.Single HeadSwayMaxSpeed { get => HeadSwayMaxSpeed_Element.Data; set => HeadSwayMaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSwayMaxSpeed_Element = new();
public global::System.Single HeadSwaySpeedSpeed { get => HeadSwaySpeedSpeed_Element.Data; set => HeadSwaySpeedSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadSwaySpeedSpeed_Element = new();
public global::System.Single HeadMaxLookDirectionAngle { get => HeadMaxLookDirectionAngle_Element.Data; set => HeadMaxLookDirectionAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadMaxLookDirectionAngle_Element = new();
public global::System.Single HeadLookSpeed { get => HeadLookSpeed_Element.Data; set => HeadLookSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadLookSpeed_Element = new();
public global::FrooxEngine.IFingerPoseSourceComponent InAirFingerBasePose { get => InAirFingerBasePose_Element.Data; set => InAirFingerBasePose_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> InAirFingerBasePose_Element = new();
public global::System.Single InAirFingerCurlOffset { get => InAirFingerCurlOffset_Element.Data; set => InAirFingerCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerCurlOffset_Element = new();
public global::System.Single InAirFingerCurlSwayMagnitude { get => InAirFingerCurlSwayMagnitude_Element.Data; set => InAirFingerCurlSwayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerCurlSwayMagnitude_Element = new();
public global::System.Single InAirFingerCurlSwaySpeed { get => InAirFingerCurlSwaySpeed_Element.Data; set => InAirFingerCurlSwaySpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerCurlSwaySpeed_Element = new();
public global::System.Single InAirFingerCurlVariationMagnitude { get => InAirFingerCurlVariationMagnitude_Element.Data; set => InAirFingerCurlVariationMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerCurlVariationMagnitude_Element = new();
public global::System.Single InAirFingerCurlVariationSpeed { get => InAirFingerCurlVariationSpeed_Element.Data; set => InAirFingerCurlVariationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerCurlVariationSpeed_Element = new();
public global::System.Single InAirFingerUpwardsSplayMagnitude { get => InAirFingerUpwardsSplayMagnitude_Element.Data; set => InAirFingerUpwardsSplayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerUpwardsSplayMagnitude_Element = new();
public global::System.Single InAirFingerUpwardsVelocityReference { get => InAirFingerUpwardsVelocityReference_Element.Data; set => InAirFingerUpwardsVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerUpwardsVelocityReference_Element = new();
public global::System.Single InAirFingerDownwardsSplayMagnitude { get => InAirFingerDownwardsSplayMagnitude_Element.Data; set => InAirFingerDownwardsSplayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerDownwardsSplayMagnitude_Element = new();
public global::System.Single InAirFingerDownwardsVelocityReference { get => InAirFingerDownwardsVelocityReference_Element.Data; set => InAirFingerDownwardsVelocityReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InAirFingerDownwardsVelocityReference_Element = new();
public global::FrooxEngine.IFingerPoseSourceComponent FloatingFingerBasePose { get => FloatingFingerBasePose_Element.Data; set => FloatingFingerBasePose_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> FloatingFingerBasePose_Element = new();
public global::System.Single FloatingFingerCurlOffset { get => FloatingFingerCurlOffset_Element.Data; set => FloatingFingerCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlOffset_Element = new();
public global::System.Single FloatingFingerSplayOffset { get => FloatingFingerSplayOffset_Element.Data; set => FloatingFingerSplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerSplayOffset_Element = new();
public global::System.Single FloatingFingerCurlSwayMagnitude { get => FloatingFingerCurlSwayMagnitude_Element.Data; set => FloatingFingerCurlSwayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlSwayMagnitude_Element = new();
public global::System.Single FloatingFingerCurlSwaySpeed { get => FloatingFingerCurlSwaySpeed_Element.Data; set => FloatingFingerCurlSwaySpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlSwaySpeed_Element = new();
public global::System.Single FloatingFingerCurlVariationMagnitude { get => FloatingFingerCurlVariationMagnitude_Element.Data; set => FloatingFingerCurlVariationMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlVariationMagnitude_Element = new();
public global::System.Single FloatingFingerCurlVariationSpeed { get => FloatingFingerCurlVariationSpeed_Element.Data; set => FloatingFingerCurlVariationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlVariationSpeed_Element = new();
public global::System.Single FloatingFingerCurlSpeedMagnitude { get => FloatingFingerCurlSpeedMagnitude_Element.Data; set => FloatingFingerCurlSpeedMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlSpeedMagnitude_Element = new();
public global::System.Single FloatingFingerCurlSpeedReference { get => FloatingFingerCurlSpeedReference_Element.Data; set => FloatingFingerCurlSpeedReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FloatingFingerCurlSpeedReference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinimumTravelSpeed", MinimumTravelSpeed_Element.Data.ToResoniteLinkField());
members.Add("TargetPosChangeSpeed", TargetPosChangeSpeed_Element.Data.ToResoniteLinkField());
members.Add("MinFullTravelDistanceSpeed", MinFullTravelDistanceSpeed_Element.Data.ToResoniteLinkField());
members.Add("MaxVerticalReferenceSpeed", MaxVerticalReferenceSpeed_Element.Data.ToResoniteLinkField());
members.Add("StillVelocityThreshold", StillVelocityThreshold_Element.Data.ToResoniteLinkField());
members.Add("StillFootForwardsMaxDistance", StillFootForwardsMaxDistance_Element.Data.ToResoniteLinkField());
members.Add("StillFootSidewaysMaxDistanceRatio", StillFootSidewaysMaxDistanceRatio_Element.Data.ToResoniteLinkField());
members.Add("StillFootSidewaysMaxExcessDistance", StillFootSidewaysMaxExcessDistance_Element.Data.ToResoniteLinkField());
members.Add("StillFootMaxAngleTravel", StillFootMaxAngleTravel_Element.Data.ToResoniteLinkField());
members.Add("StillMinimumFootingTime", StillMinimumFootingTime_Element.Data.ToResoniteLinkField());
members.Add("HandMotionTransfer", HandMotionTransfer_Element.Data.ToResoniteLinkField());
members.Add("HandMaxVelocity", HandMaxVelocity_Element.Data.ToResoniteLinkField());
members.Add("HandAirMotionTransfer", HandAirMotionTransfer_Element.Data.ToResoniteLinkField());
members.Add("HandAirDrag", HandAirDrag_Element.Data.ToResoniteLinkField());
members.Add("HandAirForce", HandAirForce_Element.Data.ToResoniteLinkField());
members.Add("HandAirUpwardsPose", HandAirUpwardsPose_Element.Data.ToResoniteLinkField());
members.Add("HandAirDownwardsPose", HandAirDownwardsPose_Element.Data.ToResoniteLinkField());
members.Add("HandAirCenterOffset", HandAirCenterOffset_Element.Data.ToResoniteLinkField());
members.Add("HandAirUp", HandAirUp_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingMotionTransfer", HandFloatingMotionTransfer_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingDrag", HandFloatingDrag_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingForce", HandFloatingForce_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingPose", HandFloatingPose_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingCenterOffset", HandFloatingCenterOffset_Element.Data.ToResoniteLinkField());
members.Add("HandFloatingUp", HandFloatingUp_Element.Data.ToResoniteLinkField());
members.Add("FootMaxDistance", FootMaxDistance_Element.Data.ToResoniteLinkField());
members.Add("FootTiltMinAngle", FootTiltMinAngle_Element.Data.ToResoniteLinkField());
members.Add("FootTiltMaxAngle", FootTiltMaxAngle_Element.Data.ToResoniteLinkField());
members.Add("FootAvoidanceRadius", FootAvoidanceRadius_Element.Data.ToResoniteLinkField());
members.Add("HandHorizontalSwingRatio", HandHorizontalSwingRatio_Element.Data.ToResoniteLinkField());
members.Add("HandSwayMin", HandSwayMin_Element.Data.ToResoniteLinkField());
members.Add("HandSwayMax", HandSwayMax_Element.Data.ToResoniteLinkField());
members.Add("HandSwayMinSpeed", HandSwayMinSpeed_Element.Data.ToResoniteLinkField());
members.Add("HandSwayMaxSpeed", HandSwayMaxSpeed_Element.Data.ToResoniteLinkField());
members.Add("HandSwaySpeedSpeed", HandSwaySpeedSpeed_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchOffset", HandCrouchOffset_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchSwingMultiplier", HandCrouchSwingMultiplier_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchUp", HandCrouchUp_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchCenterOffset", HandCrouchCenterOffset_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchMinForce", HandCrouchMinForce_Element.Data.ToResoniteLinkField());
members.Add("HandCrouchMinDrag", HandCrouchMinDrag_Element.Data.ToResoniteLinkField());
members.Add("FootRandomPositionOffsetMagnitude", FootRandomPositionOffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("RandomFootAngleOffsetMagnitude", RandomFootAngleOffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FootAirMotionTransfer", FootAirMotionTransfer_Element.Data.ToResoniteLinkField());
members.Add("FootAirDrag", FootAirDrag_Element.Data.ToResoniteLinkField());
members.Add("FootAirForce", FootAirForce_Element.Data.ToResoniteLinkField());
members.Add("FootAirMinDistance", FootAirMinDistance_Element.Data.ToResoniteLinkField());
members.Add("FootAirMaxDistance", FootAirMaxDistance_Element.Data.ToResoniteLinkField());
members.Add("FootAirVelocityDistanceRatio", FootAirVelocityDistanceRatio_Element.Data.ToResoniteLinkField());
members.Add("FootAirUpwardsTiltAngle", FootAirUpwardsTiltAngle_Element.Data.ToResoniteLinkField());
members.Add("FootAirDownwardsTiltAngle", FootAirDownwardsTiltAngle_Element.Data.ToResoniteLinkField());
members.Add("FootAirRotationSpeed", FootAirRotationSpeed_Element.Data.ToResoniteLinkField());
members.Add("FootAirVerticalOffset", FootAirVerticalOffset_Element.Data.ToResoniteLinkField());
members.Add("FeetAirMaxVelocity", FeetAirMaxVelocity_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingMotionTransfer", FootFloatingMotionTransfer_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingDrag", FootFloatingDrag_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingForce", FootFloatingForce_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingMinAngle", FootFloatingMinAngle_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingMaxAngle", FootFloatingMaxAngle_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingAngleSpeed", FootFloatingAngleSpeed_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingOffset", FootFloatingOffset_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingOffsetMagnitude", FootFloatingOffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingPositionSpeed", FootFloatingPositionSpeed_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingRotationSpeed", FootFloatingRotationSpeed_Element.Data.ToResoniteLinkField());
members.Add("FootFloatingMaxDistance", FootFloatingMaxDistance_Element.Data.ToResoniteLinkField());
members.Add("HeadJumpAngle", HeadJumpAngle_Element.Data.ToResoniteLinkField());
members.Add("HeadVerticalForce", HeadVerticalForce_Element.Data.ToResoniteLinkField());
members.Add("HeadVerticalDrag", HeadVerticalDrag_Element.Data.ToResoniteLinkField());
members.Add("HeadVerticalTransferRatio", HeadVerticalTransferRatio_Element.Data.ToResoniteLinkField());
members.Add("HeadMaxVerticalVelocity", HeadMaxVerticalVelocity_Element.Data.ToResoniteLinkField());
members.Add("HeadMaxVerticalOffset", HeadMaxVerticalOffset_Element.Data.ToResoniteLinkField());
members.Add("HeadMinVerticalOffset", HeadMinVerticalOffset_Element.Data.ToResoniteLinkField());
members.Add("HeadFloatingVerticalForce", HeadFloatingVerticalForce_Element.Data.ToResoniteLinkField());
members.Add("HeadFloatingVerticalDrag", HeadFloatingVerticalDrag_Element.Data.ToResoniteLinkField());
members.Add("HeadFloatingVerticalTransferRatio", HeadFloatingVerticalTransferRatio_Element.Data.ToResoniteLinkField());
members.Add("HeadSwayVerticalAngle", HeadSwayVerticalAngle_Element.Data.ToResoniteLinkField());
members.Add("HeadSwayHorizontalAngle", HeadSwayHorizontalAngle_Element.Data.ToResoniteLinkField());
members.Add("HeadSwayMinSpeed", HeadSwayMinSpeed_Element.Data.ToResoniteLinkField());
members.Add("HeadSwayMaxSpeed", HeadSwayMaxSpeed_Element.Data.ToResoniteLinkField());
members.Add("HeadSwaySpeedSpeed", HeadSwaySpeedSpeed_Element.Data.ToResoniteLinkField());
members.Add("HeadMaxLookDirectionAngle", HeadMaxLookDirectionAngle_Element.Data.ToResoniteLinkField());
members.Add("HeadLookSpeed", HeadLookSpeed_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerBasePose", InAirFingerBasePose_Element.Data.ToResoniteReference(context));
members.Add("InAirFingerCurlOffset", InAirFingerCurlOffset_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerCurlSwayMagnitude", InAirFingerCurlSwayMagnitude_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerCurlSwaySpeed", InAirFingerCurlSwaySpeed_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerCurlVariationMagnitude", InAirFingerCurlVariationMagnitude_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerCurlVariationSpeed", InAirFingerCurlVariationSpeed_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerUpwardsSplayMagnitude", InAirFingerUpwardsSplayMagnitude_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerUpwardsVelocityReference", InAirFingerUpwardsVelocityReference_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerDownwardsSplayMagnitude", InAirFingerDownwardsSplayMagnitude_Element.Data.ToResoniteLinkField());
members.Add("InAirFingerDownwardsVelocityReference", InAirFingerDownwardsVelocityReference_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerBasePose", FloatingFingerBasePose_Element.Data.ToResoniteReference(context));
members.Add("FloatingFingerCurlOffset", FloatingFingerCurlOffset_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerSplayOffset", FloatingFingerSplayOffset_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlSwayMagnitude", FloatingFingerCurlSwayMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlSwaySpeed", FloatingFingerCurlSwaySpeed_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlVariationMagnitude", FloatingFingerCurlVariationMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlVariationSpeed", FloatingFingerCurlVariationSpeed_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlSpeedMagnitude", FloatingFingerCurlSpeedMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FloatingFingerCurlSpeedReference", FloatingFingerCurlSpeedReference_Element.Data.ToResoniteLinkField());
}

}
}
