
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar
// Generated on: čtvrtek 26. února 2026 10:04:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar")]
public partial class VRIKAvatar : global::FrooxEngine.UserRootComponent, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.ICustomInspector, global::FrooxEngine.CommonAvatar.IAvatarBodyNodeEventReceiver, global::FrooxEngine.INeckOffsetSource, global::FrooxEngine.IInputUpdateReceiver, global::FrooxEngine.ILocomotionAnimationMetricSource

{
    public global::FrooxEngine.FinalIK.VRIK IK { get => IK_Element.Data; set => IK_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FinalIK.VRIK>, global::FrooxEngine.FinalIK.VRIK> IK_Element = new();
public global::System.Single HeightCompensation { get => HeightCompensation_Element.Data; set => HeightCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightCompensation_Element = new();
public global::System.Single AvatarHeight { get => AvatarHeight_Element.Data; set => AvatarHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AvatarHeight_Element = new();
public global::System.Single UserResizeThreshold { get => UserResizeThreshold_Element.Data; set => UserResizeThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserResizeThreshold_Element = new();
public global::System.Boolean FeetIgnoreOtherPlayers { get => FeetIgnoreOtherPlayers_Element.Data; set => FeetIgnoreOtherPlayers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FeetIgnoreOtherPlayers_Element = new();
public global::FrooxEngine.ListFilterMode FeetCollisionListMode { get => FeetCollisionListMode_Element.Data; set => FeetCollisionListMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ListFilterMode>, global::FrooxEngine.ListFilterMode> FeetCollisionListMode_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> FeetCollisionList = new();
public global::System.Single HeadMaxFixDistance { get => HeadMaxFixDistance_Element.Data; set => HeadMaxFixDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadMaxFixDistance_Element = new();
public global::System.Boolean ForceUseFeetProxies { get => ForceUseFeetProxies_Element.Data; set => ForceUseFeetProxies_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceUseFeetProxies_Element = new();
public global::System.Boolean ForceUsePelvisProxy { get => ForceUsePelvisProxy_Element.Data; set => ForceUsePelvisProxy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceUsePelvisProxy_Element = new();
public global::System.Boolean ForceUseChestProxy { get => ForceUseChestProxy_Element.Data; set => ForceUseChestProxy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceUseChestProxy_Element = new();
public global::System.Boolean ForceUseElbowProxies { get => ForceUseElbowProxies_Element.Data; set => ForceUseElbowProxies_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceUseElbowProxies_Element = new();
public global::System.Boolean ForceUseKneeProxies { get => ForceUseKneeProxies_Element.Data; set => ForceUseKneeProxies_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceUseKneeProxies_Element = new();
public global::System.Boolean FeetCalibrated { get => FeetCalibrated_Element.Data; set => FeetCalibrated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FeetCalibrated_Element = new();
public global::System.Boolean PelvisCalibrated { get => PelvisCalibrated_Element.Data; set => PelvisCalibrated_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PelvisCalibrated_Element = new();
public global::System.Single GroundCheckHeightRatio { get => GroundCheckHeightRatio_Element.Data; set => GroundCheckHeightRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GroundCheckHeightRatio_Element = new();
public global::System.Single FeetHoverHeight { get => FeetHoverHeight_Element.Data; set => FeetHoverHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetHoverHeight_Element = new();
public global::System.Single FeetHoverSmoothSpeed { get => FeetHoverSmoothSpeed_Element.Data; set => FeetHoverSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetHoverSmoothSpeed_Element = new();
public global::System.Single MinFeetTransitionSpeed { get => MinFeetTransitionSpeed_Element.Data; set => MinFeetTransitionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinFeetTransitionSpeed_Element = new();
public global::System.Single MaxFeetTransitionSpeed { get => MaxFeetTransitionSpeed_Element.Data; set => MaxFeetTransitionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxFeetTransitionSpeed_Element = new();
public global::System.Single GaitFeetTransitionSpeedMultiplier { get => GaitFeetTransitionSpeedMultiplier_Element.Data; set => GaitFeetTransitionSpeedMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GaitFeetTransitionSpeedMultiplier_Element = new();
public global::System.Single FeetHoverTilt { get => FeetHoverTilt_Element.Data; set => FeetHoverTilt_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetHoverTilt_Element = new();
public UnityEngine.Vector3 LeftFootFloatOffset { get => LeftFootFloatOffset_Element.Data; set => LeftFootFloatOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LeftFootFloatOffset_Element = new();
public UnityEngine.Vector3 RightFootFloatOffset { get => RightFootFloatOffset_Element.Data; set => RightFootFloatOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RightFootFloatOffset_Element = new();
public global::System.Single LeftFootRootHeight { get => LeftFootRootHeight_Element.Data; set => LeftFootRootHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LeftFootRootHeight_Element = new();
public global::System.Single RightFootRootHeight { get => RightFootRootHeight_Element.Data; set => RightFootRootHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RightFootRootHeight_Element = new();
public global::System.Single FootFloatSpeed { get => FootFloatSpeed_Element.Data; set => FootFloatSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatSpeed_Element = new();
public global::System.Single FootFloatAngleMagnitude { get => FootFloatAngleMagnitude_Element.Data; set => FootFloatAngleMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatAngleMagnitude_Element = new();
public global::System.Single FootFloatOffsetMagnitude { get => FootFloatOffsetMagnitude_Element.Data; set => FootFloatOffsetMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootFloatOffsetMagnitude_Element = new();
public global::System.Single FeetFloatVelocityForce { get => FeetFloatVelocityForce_Element.Data; set => FeetFloatVelocityForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetFloatVelocityForce_Element = new();
public global::System.Single FeetFloatVelocityDampeningSpeed { get => FeetFloatVelocityDampeningSpeed_Element.Data; set => FeetFloatVelocityDampeningSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetFloatVelocityDampeningSpeed_Element = new();
public global::System.Single MaxFeetVelocityOffset { get => MaxFeetVelocityOffset_Element.Data; set => MaxFeetVelocityOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxFeetVelocityOffset_Element = new();
public global::System.Single VelocityAverageRate { get => VelocityAverageRate_Element.Data; set => VelocityAverageRate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityAverageRate_Element = new();
public global::System.Single HoverVelocityThreshold { get => HoverVelocityThreshold_Element.Data; set => HoverVelocityThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoverVelocityThreshold_Element = new();
public global::System.Single HorizontalBodyAngle { get => HorizontalBodyAngle_Element.Data; set => HorizontalBodyAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalBodyAngle_Element = new();
public global::System.Boolean SupressWalkAnimationWhenHorizontal { get => SupressWalkAnimationWhenHorizontal_Element.Data; set => SupressWalkAnimationWhenHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SupressWalkAnimationWhenHorizontal_Element = new();
public global::System.Boolean AlwaysUseTrackersWhenHorizontal { get => AlwaysUseTrackersWhenHorizontal_Element.Data; set => AlwaysUseTrackersWhenHorizontal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysUseTrackersWhenHorizontal_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FinalIK.VRIKAvatar.Gait>, global::FrooxEngine.FinalIK.VRIKAvatar.Gait> Gaits = new();
public global::System.Single GaitTransitionSpeed { get => GaitTransitionSpeed_Element.Data; set => GaitTransitionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GaitTransitionSpeed_Element = new();
public global::System.Single GaitMovementDirectionSmoothSpeed { get => GaitMovementDirectionSmoothSpeed_Element.Data; set => GaitMovementDirectionSmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GaitMovementDirectionSmoothSpeed_Element = new();
public global::System.Single RigCollidersRadiusRatio { get => RigCollidersRadiusRatio_Element.Data; set => RigCollidersRadiusRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RigCollidersRadiusRatio_Element = new();
public UnityEngine.Quaternion LeftHandRotationOffset { get => LeftHandRotationOffset_Element.Data; set => LeftHandRotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LeftHandRotationOffset_Element = new();
public UnityEngine.Quaternion RightHandRotationOffset { get => RightHandRotationOffset_Element.Data; set => RightHandRotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> RightHandRotationOffset_Element = new();
public global::System.Single CurrentAverageVelocity { get => CurrentAverageVelocity_Element.Data; set => CurrentAverageVelocity_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CurrentAverageVelocity_Element = new();
public global::System.Boolean CurrentOnGround { get => CurrentOnGround_Element.Data; set => CurrentOnGround_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> CurrentOnGround_Element = new();
public global::System.Int32 CurrentGaitIndex { get => CurrentGaitIndex_Element.Data; set => CurrentGaitIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> CurrentGaitIndex_Element = new();
public global::FrooxEngine.LocomotionController _locomotionController { get => _locomotionController_Element.Data; set => _locomotionController_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LocomotionController>, global::FrooxEngine.LocomotionController> _locomotionController_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftHandNode { get => _leftHandNode_Element.Data; set => _leftHandNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _leftHandNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightHandNode { get => _rightHandNode_Element.Data; set => _rightHandNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _rightHandNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftElbowNode { get => _leftElbowNode_Element.Data; set => _leftElbowNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _leftElbowNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightElbowNode { get => _rightElbowNode_Element.Data; set => _rightElbowNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _rightElbowNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftFootNode { get => _leftFootNode_Element.Data; set => _leftFootNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _leftFootNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightFootNode { get => _rightFootNode_Element.Data; set => _rightFootNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _rightFootNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftKneeNode { get => _leftKneeNode_Element.Data; set => _leftKneeNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _leftKneeNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightKneeNode { get => _rightKneeNode_Element.Data; set => _rightKneeNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _rightKneeNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _headNode { get => _headNode_Element.Data; set => _headNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _headNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _pelvisNode { get => _pelvisNode_Element.Data; set => _pelvisNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _pelvisNode_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _chestNode { get => _chestNode_Element.Data; set => _chestNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarPoseNode>, global::FrooxEngine.CommonAvatar.AvatarPoseNode> _chestNode_Element = new();
public global::FrooxEngine.Slot _headProxy { get => _headProxy_Element.Data; set => _headProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _headProxy_Element = new();
public global::FrooxEngine.Slot _pelvisProxy { get => _pelvisProxy_Element.Data; set => _pelvisProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _pelvisProxy_Element = new();
public global::FrooxEngine.Slot _chestProxy { get => _chestProxy_Element.Data; set => _chestProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _chestProxy_Element = new();
public global::FrooxEngine.Slot _leftHandProxy { get => _leftHandProxy_Element.Data; set => _leftHandProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftHandProxy_Element = new();
public global::FrooxEngine.Slot _rightHandProxy { get => _rightHandProxy_Element.Data; set => _rightHandProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightHandProxy_Element = new();
public global::FrooxEngine.Slot _leftElbowProxy { get => _leftElbowProxy_Element.Data; set => _leftElbowProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftElbowProxy_Element = new();
public global::FrooxEngine.Slot _rightElbowProxy { get => _rightElbowProxy_Element.Data; set => _rightElbowProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightElbowProxy_Element = new();
public global::FrooxEngine.Slot _leftFootProxy { get => _leftFootProxy_Element.Data; set => _leftFootProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftFootProxy_Element = new();
public global::FrooxEngine.Slot _rightFootProxy { get => _rightFootProxy_Element.Data; set => _rightFootProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightFootProxy_Element = new();
public global::FrooxEngine.Slot _leftKneeProxy { get => _leftKneeProxy_Element.Data; set => _leftKneeProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftKneeProxy_Element = new();
public global::FrooxEngine.Slot _rightKneeProxy { get => _rightKneeProxy_Element.Data; set => _rightKneeProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightKneeProxy_Element = new();
public global::FrooxEngine.Slot _leftKneeDefaultProxy { get => _leftKneeDefaultProxy_Element.Data; set => _leftKneeDefaultProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftKneeDefaultProxy_Element = new();
public global::FrooxEngine.Slot _rightKneeDefaultProxy { get => _rightKneeDefaultProxy_Element.Data; set => _rightKneeDefaultProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightKneeDefaultProxy_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _headTargetPos { get => _headTargetPos_Element.Data; set => _headTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _headTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _headTargetRot { get => _headTargetRot_Element.Data; set => _headTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _headTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _pelvisTargetPos { get => _pelvisTargetPos_Element.Data; set => _pelvisTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _pelvisTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _pelvisTargetRot { get => _pelvisTargetRot_Element.Data; set => _pelvisTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _pelvisTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _chestTargetPos { get => _chestTargetPos_Element.Data; set => _chestTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _chestTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftHandTargetPos { get => _leftHandTargetPos_Element.Data; set => _leftHandTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftHandTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftHandTargetRot { get => _leftHandTargetRot_Element.Data; set => _leftHandTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftHandTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightHandTargetPos { get => _rightHandTargetPos_Element.Data; set => _rightHandTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightHandTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightHandTargetRot { get => _rightHandTargetRot_Element.Data; set => _rightHandTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightHandTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftElbowTargetPos { get => _leftElbowTargetPos_Element.Data; set => _leftElbowTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftElbowTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightElbowTargetPos { get => _rightElbowTargetPos_Element.Data; set => _rightElbowTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightElbowTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootTargetPos { get => _leftFootTargetPos_Element.Data; set => _leftFootTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftFootTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftFootTargetRot { get => _leftFootTargetRot_Element.Data; set => _leftFootTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftFootTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootTargetPos { get => _rightFootTargetPos_Element.Data; set => _rightFootTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightFootTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightFootTargetRot { get => _rightFootTargetRot_Element.Data; set => _rightFootTargetRot_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightFootTargetRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftKneeTargetPos { get => _leftKneeTargetPos_Element.Data; set => _leftKneeTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftKneeTargetPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightKneeTargetPos { get => _rightKneeTargetPos_Element.Data; set => _rightKneeTargetPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightKneeTargetPos_Element = new();
public global::FrooxEngine.IField<global::System.Single> _pelvisPositionWeight { get => _pelvisPositionWeight_Element.Data; set => _pelvisPositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _pelvisPositionWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _pelvisRotationWeight { get => _pelvisRotationWeight_Element.Data; set => _pelvisRotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _pelvisRotationWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _chestWeight { get => _chestWeight_Element.Data; set => _chestWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _chestWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _locomotionWeight { get => _locomotionWeight_Element.Data; set => _locomotionWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _locomotionWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _leftLegPositionWeight { get => _leftLegPositionWeight_Element.Data; set => _leftLegPositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _leftLegPositionWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _leftLegRotationWeight { get => _leftLegRotationWeight_Element.Data; set => _leftLegRotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _leftLegRotationWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rightLegPositionWeight { get => _rightLegPositionWeight_Element.Data; set => _rightLegPositionWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rightLegPositionWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rightLegRotationWeight { get => _rightLegRotationWeight_Element.Data; set => _rightLegRotationWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rightLegRotationWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _leftKneeBendWeight { get => _leftKneeBendWeight_Element.Data; set => _leftKneeBendWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _leftKneeBendWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rightKneeBendWeight { get => _rightKneeBendWeight_Element.Data; set => _rightKneeBendWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rightKneeBendWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _leftElbowBendWeight { get => _leftElbowBendWeight_Element.Data; set => _leftElbowBendWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _leftElbowBendWeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rightElbowBendWeight { get => _rightElbowBendWeight_Element.Data; set => _rightElbowBendWeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rightElbowBendWeight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootOffset { get => _leftFootOffset_Element.Data; set => _leftFootOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftFootOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootOffset { get => _rightFootOffset_Element.Data; set => _rightFootOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightFootOffset_Element = new();
public UnityEngine.Quaternion _leftFootRelativeToRoot { get => _leftFootRelativeToRoot_Element.Data; set => _leftFootRelativeToRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _leftFootRelativeToRoot_Element = new();
public UnityEngine.Quaternion _rightFootRelativeToRoot { get => _rightFootRelativeToRoot_Element.Data; set => _rightFootRelativeToRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> _rightFootRelativeToRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _locomotionOffset { get => _locomotionOffset_Element.Data; set => _locomotionOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _locomotionOffset_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _simplifiedColliderEnabled { get => _simplifiedColliderEnabled_Element.Data; set => _simplifiedColliderEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _simplifiedColliderEnabled_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> _rigCollidersEnabledStates = new();
public global::System.Boolean _horizontalTrackingLocked { get => _horizontalTrackingLocked_Element.Data; set => _horizontalTrackingLocked_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _horizontalTrackingLocked_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IK", IK_Element.Data.ToResoniteReference(context));
members.Add("HeightCompensation", HeightCompensation_Element.Data.ToResoniteLinkField());
members.Add("AvatarHeight", AvatarHeight_Element.Data.ToResoniteLinkField());
members.Add("UserResizeThreshold", UserResizeThreshold_Element.Data.ToResoniteLinkField());
members.Add("FeetIgnoreOtherPlayers", FeetIgnoreOtherPlayers_Element.Data.ToResoniteLinkField());
members.Add("FeetCollisionListMode", FeetCollisionListMode_Element.Data.ToResoniteLinkField());
members.Add("FeetCollisionList", new ResoniteLink.SyncList()
{
    Elements = FeetCollisionList.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("HeadMaxFixDistance", HeadMaxFixDistance_Element.Data.ToResoniteLinkField());
members.Add("ForceUseFeetProxies", ForceUseFeetProxies_Element.Data.ToResoniteLinkField());
members.Add("ForceUsePelvisProxy", ForceUsePelvisProxy_Element.Data.ToResoniteLinkField());
members.Add("ForceUseChestProxy", ForceUseChestProxy_Element.Data.ToResoniteLinkField());
members.Add("ForceUseElbowProxies", ForceUseElbowProxies_Element.Data.ToResoniteLinkField());
members.Add("ForceUseKneeProxies", ForceUseKneeProxies_Element.Data.ToResoniteLinkField());
members.Add("FeetCalibrated", FeetCalibrated_Element.Data.ToResoniteLinkField());
members.Add("PelvisCalibrated", PelvisCalibrated_Element.Data.ToResoniteLinkField());
members.Add("GroundCheckHeightRatio", GroundCheckHeightRatio_Element.Data.ToResoniteLinkField());
members.Add("FeetHoverHeight", FeetHoverHeight_Element.Data.ToResoniteLinkField());
members.Add("FeetHoverSmoothSpeed", FeetHoverSmoothSpeed_Element.Data.ToResoniteLinkField());
members.Add("MinFeetTransitionSpeed", MinFeetTransitionSpeed_Element.Data.ToResoniteLinkField());
members.Add("MaxFeetTransitionSpeed", MaxFeetTransitionSpeed_Element.Data.ToResoniteLinkField());
members.Add("GaitFeetTransitionSpeedMultiplier", GaitFeetTransitionSpeedMultiplier_Element.Data.ToResoniteLinkField());
members.Add("FeetHoverTilt", FeetHoverTilt_Element.Data.ToResoniteLinkField());
members.Add("LeftFootFloatOffset", LeftFootFloatOffset_Element.Data.ToResoniteLinkField());
members.Add("RightFootFloatOffset", RightFootFloatOffset_Element.Data.ToResoniteLinkField());
members.Add("LeftFootRootHeight", LeftFootRootHeight_Element.Data.ToResoniteLinkField());
members.Add("RightFootRootHeight", RightFootRootHeight_Element.Data.ToResoniteLinkField());
members.Add("FootFloatSpeed", FootFloatSpeed_Element.Data.ToResoniteLinkField());
members.Add("FootFloatAngleMagnitude", FootFloatAngleMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FootFloatOffsetMagnitude", FootFloatOffsetMagnitude_Element.Data.ToResoniteLinkField());
members.Add("FeetFloatVelocityForce", FeetFloatVelocityForce_Element.Data.ToResoniteLinkField());
members.Add("FeetFloatVelocityDampeningSpeed", FeetFloatVelocityDampeningSpeed_Element.Data.ToResoniteLinkField());
members.Add("MaxFeetVelocityOffset", MaxFeetVelocityOffset_Element.Data.ToResoniteLinkField());
members.Add("VelocityAverageRate", VelocityAverageRate_Element.Data.ToResoniteLinkField());
members.Add("HoverVelocityThreshold", HoverVelocityThreshold_Element.Data.ToResoniteLinkField());
members.Add("HorizontalBodyAngle", HorizontalBodyAngle_Element.Data.ToResoniteLinkField());
members.Add("SupressWalkAnimationWhenHorizontal", SupressWalkAnimationWhenHorizontal_Element.Data.ToResoniteLinkField());
members.Add("AlwaysUseTrackersWhenHorizontal", AlwaysUseTrackersWhenHorizontal_Element.Data.ToResoniteLinkField());
members.Add("Gaits", new ResoniteLink.SyncList()
{
    Elements = Gaits.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("GaitTransitionSpeed", GaitTransitionSpeed_Element.Data.ToResoniteLinkField());
members.Add("GaitMovementDirectionSmoothSpeed", GaitMovementDirectionSmoothSpeed_Element.Data.ToResoniteLinkField());
members.Add("RigCollidersRadiusRatio", RigCollidersRadiusRatio_Element.Data.ToResoniteLinkField());
members.Add("LeftHandRotationOffset", LeftHandRotationOffset_Element.Data.ToResoniteLinkField());
members.Add("RightHandRotationOffset", RightHandRotationOffset_Element.Data.ToResoniteLinkField());
members.Add("CurrentAverageVelocity", CurrentAverageVelocity_Element.Data.ToResoniteLinkField());
members.Add("CurrentOnGround", CurrentOnGround_Element.Data.ToResoniteLinkField());
members.Add("CurrentGaitIndex", CurrentGaitIndex_Element.Data.ToResoniteLinkField());
members.Add("_locomotionController", _locomotionController_Element.Data.ToResoniteReference(context));
members.Add("_leftHandNode", _leftHandNode_Element.Data.ToResoniteReference(context));
members.Add("_rightHandNode", _rightHandNode_Element.Data.ToResoniteReference(context));
members.Add("_leftElbowNode", _leftElbowNode_Element.Data.ToResoniteReference(context));
members.Add("_rightElbowNode", _rightElbowNode_Element.Data.ToResoniteReference(context));
members.Add("_leftFootNode", _leftFootNode_Element.Data.ToResoniteReference(context));
members.Add("_rightFootNode", _rightFootNode_Element.Data.ToResoniteReference(context));
members.Add("_leftKneeNode", _leftKneeNode_Element.Data.ToResoniteReference(context));
members.Add("_rightKneeNode", _rightKneeNode_Element.Data.ToResoniteReference(context));
members.Add("_headNode", _headNode_Element.Data.ToResoniteReference(context));
members.Add("_pelvisNode", _pelvisNode_Element.Data.ToResoniteReference(context));
members.Add("_chestNode", _chestNode_Element.Data.ToResoniteReference(context));
members.Add("_headProxy", _headProxy_Element.Data.ToResoniteReference(context));
members.Add("_pelvisProxy", _pelvisProxy_Element.Data.ToResoniteReference(context));
members.Add("_chestProxy", _chestProxy_Element.Data.ToResoniteReference(context));
members.Add("_leftHandProxy", _leftHandProxy_Element.Data.ToResoniteReference(context));
members.Add("_rightHandProxy", _rightHandProxy_Element.Data.ToResoniteReference(context));
members.Add("_leftElbowProxy", _leftElbowProxy_Element.Data.ToResoniteReference(context));
members.Add("_rightElbowProxy", _rightElbowProxy_Element.Data.ToResoniteReference(context));
members.Add("_leftFootProxy", _leftFootProxy_Element.Data.ToResoniteReference(context));
members.Add("_rightFootProxy", _rightFootProxy_Element.Data.ToResoniteReference(context));
members.Add("_leftKneeProxy", _leftKneeProxy_Element.Data.ToResoniteReference(context));
members.Add("_rightKneeProxy", _rightKneeProxy_Element.Data.ToResoniteReference(context));
members.Add("_leftKneeDefaultProxy", _leftKneeDefaultProxy_Element.Data.ToResoniteReference(context));
members.Add("_rightKneeDefaultProxy", _rightKneeDefaultProxy_Element.Data.ToResoniteReference(context));
members.Add("_headTargetPos", _headTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_headTargetRot", _headTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_pelvisTargetPos", _pelvisTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_pelvisTargetRot", _pelvisTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_chestTargetPos", _chestTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_leftHandTargetPos", _leftHandTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_leftHandTargetRot", _leftHandTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_rightHandTargetPos", _rightHandTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_rightHandTargetRot", _rightHandTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_leftElbowTargetPos", _leftElbowTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_rightElbowTargetPos", _rightElbowTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_leftFootTargetPos", _leftFootTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_leftFootTargetRot", _leftFootTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_rightFootTargetPos", _rightFootTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_rightFootTargetRot", _rightFootTargetRot_Element.Data.ToResoniteReference(context));
members.Add("_leftKneeTargetPos", _leftKneeTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_rightKneeTargetPos", _rightKneeTargetPos_Element.Data.ToResoniteReference(context));
members.Add("_pelvisPositionWeight", _pelvisPositionWeight_Element.Data.ToResoniteReference(context));
members.Add("_pelvisRotationWeight", _pelvisRotationWeight_Element.Data.ToResoniteReference(context));
members.Add("_chestWeight", _chestWeight_Element.Data.ToResoniteReference(context));
members.Add("_locomotionWeight", _locomotionWeight_Element.Data.ToResoniteReference(context));
members.Add("_leftLegPositionWeight", _leftLegPositionWeight_Element.Data.ToResoniteReference(context));
members.Add("_leftLegRotationWeight", _leftLegRotationWeight_Element.Data.ToResoniteReference(context));
members.Add("_rightLegPositionWeight", _rightLegPositionWeight_Element.Data.ToResoniteReference(context));
members.Add("_rightLegRotationWeight", _rightLegRotationWeight_Element.Data.ToResoniteReference(context));
members.Add("_leftKneeBendWeight", _leftKneeBendWeight_Element.Data.ToResoniteReference(context));
members.Add("_rightKneeBendWeight", _rightKneeBendWeight_Element.Data.ToResoniteReference(context));
members.Add("_leftElbowBendWeight", _leftElbowBendWeight_Element.Data.ToResoniteReference(context));
members.Add("_rightElbowBendWeight", _rightElbowBendWeight_Element.Data.ToResoniteReference(context));
members.Add("_leftFootOffset", _leftFootOffset_Element.Data.ToResoniteReference(context));
members.Add("_rightFootOffset", _rightFootOffset_Element.Data.ToResoniteReference(context));
members.Add("_leftFootRelativeToRoot", _leftFootRelativeToRoot_Element.Data.ToResoniteLinkField());
members.Add("_rightFootRelativeToRoot", _rightFootRelativeToRoot_Element.Data.ToResoniteLinkField());
members.Add("_locomotionOffset", _locomotionOffset_Element.Data.ToResoniteReference(context));
members.Add("_simplifiedColliderEnabled", _simplifiedColliderEnabled_Element.Data.ToResoniteReference(context));
members.Add("_rigCollidersEnabledStates", new ResoniteLink.SyncList()
{
    Elements = _rigCollidersEnabledStates.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_horizontalTrackingLocked", _horizontalTrackingLocked_Element.Data.ToResoniteLinkField());
}

}
}
