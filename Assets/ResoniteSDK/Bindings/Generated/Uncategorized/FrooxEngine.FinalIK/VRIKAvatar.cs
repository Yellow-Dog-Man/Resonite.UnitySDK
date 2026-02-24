
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar
// Generated on: úterý 24. února 2026 18:20:22
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.FinalIK.VRIK IK;
public global::System.Single HeightCompensation;
public global::System.Single AvatarHeight;
public global::System.Single UserResizeThreshold;
public global::System.Boolean FeetIgnoreOtherPlayers;
public global::FrooxEngine.ListFilterMode FeetCollisionListMode;
public System.Collections.Generic.List<global::FrooxEngine.Slot> FeetCollisionList;
public global::System.Single HeadMaxFixDistance;
public global::System.Boolean ForceUseFeetProxies;
public global::System.Boolean ForceUsePelvisProxy;
public global::System.Boolean ForceUseChestProxy;
public global::System.Boolean ForceUseElbowProxies;
public global::System.Boolean ForceUseKneeProxies;
public global::System.Boolean FeetCalibrated;
public global::System.Boolean PelvisCalibrated;
public global::System.Single GroundCheckHeightRatio;
public global::System.Single FeetHoverHeight;
public global::System.Single FeetHoverSmoothSpeed;
public global::System.Single MinFeetTransitionSpeed;
public global::System.Single MaxFeetTransitionSpeed;
public global::System.Single GaitFeetTransitionSpeedMultiplier;
public global::System.Single FeetHoverTilt;
public UnityEngine.Vector3 LeftFootFloatOffset;
public UnityEngine.Vector3 RightFootFloatOffset;
public global::System.Single LeftFootRootHeight;
public global::System.Single RightFootRootHeight;
public global::System.Single FootFloatSpeed;
public global::System.Single FootFloatAngleMagnitude;
public global::System.Single FootFloatOffsetMagnitude;
public global::System.Single FeetFloatVelocityForce;
public global::System.Single FeetFloatVelocityDampeningSpeed;
public global::System.Single MaxFeetVelocityOffset;
public global::System.Single VelocityAverageRate;
public global::System.Single HoverVelocityThreshold;
public global::System.Single HorizontalBodyAngle;
public global::System.Boolean SupressWalkAnimationWhenHorizontal;
public global::System.Boolean AlwaysUseTrackersWhenHorizontal;
public System.Collections.Generic.List<global::FrooxEngine.FinalIK.VRIKAvatar.Gait> Gaits;
public global::System.Single GaitTransitionSpeed;
public global::System.Single GaitMovementDirectionSmoothSpeed;
public global::System.Single RigCollidersRadiusRatio;
public UnityEngine.Quaternion LeftHandRotationOffset;
public UnityEngine.Quaternion RightHandRotationOffset;
public global::System.Single CurrentAverageVelocity;
public global::System.Boolean CurrentOnGround;
public global::System.Int32 CurrentGaitIndex;
public global::FrooxEngine.LocomotionController _locomotionController;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftHandNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightHandNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftElbowNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightElbowNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftFootNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightFootNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _leftKneeNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _rightKneeNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _headNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _pelvisNode;
public global::FrooxEngine.CommonAvatar.AvatarPoseNode _chestNode;
public global::FrooxEngine.Slot _headProxy;
public global::FrooxEngine.Slot _pelvisProxy;
public global::FrooxEngine.Slot _chestProxy;
public global::FrooxEngine.Slot _leftHandProxy;
public global::FrooxEngine.Slot _rightHandProxy;
public global::FrooxEngine.Slot _leftElbowProxy;
public global::FrooxEngine.Slot _rightElbowProxy;
public global::FrooxEngine.Slot _leftFootProxy;
public global::FrooxEngine.Slot _rightFootProxy;
public global::FrooxEngine.Slot _leftKneeProxy;
public global::FrooxEngine.Slot _rightKneeProxy;
public global::FrooxEngine.Slot _leftKneeDefaultProxy;
public global::FrooxEngine.Slot _rightKneeDefaultProxy;
public global::FrooxEngine.IField<UnityEngine.Vector3> _headTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _headTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _pelvisTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _pelvisTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _chestTargetPos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftHandTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftHandTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightHandTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightHandTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftElbowTargetPos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightElbowTargetPos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftFootTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootTargetPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightFootTargetRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftKneeTargetPos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightKneeTargetPos;
public global::FrooxEngine.IField<global::System.Single> _pelvisPositionWeight;
public global::FrooxEngine.IField<global::System.Single> _pelvisRotationWeight;
public global::FrooxEngine.IField<global::System.Single> _chestWeight;
public global::FrooxEngine.IField<global::System.Single> _locomotionWeight;
public global::FrooxEngine.IField<global::System.Single> _leftLegPositionWeight;
public global::FrooxEngine.IField<global::System.Single> _leftLegRotationWeight;
public global::FrooxEngine.IField<global::System.Single> _rightLegPositionWeight;
public global::FrooxEngine.IField<global::System.Single> _rightLegRotationWeight;
public global::FrooxEngine.IField<global::System.Single> _leftKneeBendWeight;
public global::FrooxEngine.IField<global::System.Single> _rightKneeBendWeight;
public global::FrooxEngine.IField<global::System.Single> _leftElbowBendWeight;
public global::FrooxEngine.IField<global::System.Single> _rightElbowBendWeight;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootOffset;
public UnityEngine.Quaternion _leftFootRelativeToRoot;
public UnityEngine.Quaternion _rightFootRelativeToRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _locomotionOffset;
public global::FrooxEngine.IField<global::System.Boolean> _simplifiedColliderEnabled;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> _rigCollidersEnabledStates;
public global::System.Boolean _horizontalTrackingLocked;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IK", IK.ToResoniteReference(context));
members.Add("HeightCompensation", HeightCompensation.ToResoniteLinkField());
members.Add("AvatarHeight", AvatarHeight.ToResoniteLinkField());
members.Add("UserResizeThreshold", UserResizeThreshold.ToResoniteLinkField());
members.Add("FeetIgnoreOtherPlayers", FeetIgnoreOtherPlayers.ToResoniteLinkField());
members.Add("FeetCollisionListMode", FeetCollisionListMode.ToResoniteLinkField());
members.Add("FeetCollisionList", new ResoniteLink.SyncList()
{
    Elements = FeetCollisionList.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("HeadMaxFixDistance", HeadMaxFixDistance.ToResoniteLinkField());
members.Add("ForceUseFeetProxies", ForceUseFeetProxies.ToResoniteLinkField());
members.Add("ForceUsePelvisProxy", ForceUsePelvisProxy.ToResoniteLinkField());
members.Add("ForceUseChestProxy", ForceUseChestProxy.ToResoniteLinkField());
members.Add("ForceUseElbowProxies", ForceUseElbowProxies.ToResoniteLinkField());
members.Add("ForceUseKneeProxies", ForceUseKneeProxies.ToResoniteLinkField());
members.Add("FeetCalibrated", FeetCalibrated.ToResoniteLinkField());
members.Add("PelvisCalibrated", PelvisCalibrated.ToResoniteLinkField());
members.Add("GroundCheckHeightRatio", GroundCheckHeightRatio.ToResoniteLinkField());
members.Add("FeetHoverHeight", FeetHoverHeight.ToResoniteLinkField());
members.Add("FeetHoverSmoothSpeed", FeetHoverSmoothSpeed.ToResoniteLinkField());
members.Add("MinFeetTransitionSpeed", MinFeetTransitionSpeed.ToResoniteLinkField());
members.Add("MaxFeetTransitionSpeed", MaxFeetTransitionSpeed.ToResoniteLinkField());
members.Add("GaitFeetTransitionSpeedMultiplier", GaitFeetTransitionSpeedMultiplier.ToResoniteLinkField());
members.Add("FeetHoverTilt", FeetHoverTilt.ToResoniteLinkField());
members.Add("LeftFootFloatOffset", LeftFootFloatOffset.ToResoniteLinkField());
members.Add("RightFootFloatOffset", RightFootFloatOffset.ToResoniteLinkField());
members.Add("LeftFootRootHeight", LeftFootRootHeight.ToResoniteLinkField());
members.Add("RightFootRootHeight", RightFootRootHeight.ToResoniteLinkField());
members.Add("FootFloatSpeed", FootFloatSpeed.ToResoniteLinkField());
members.Add("FootFloatAngleMagnitude", FootFloatAngleMagnitude.ToResoniteLinkField());
members.Add("FootFloatOffsetMagnitude", FootFloatOffsetMagnitude.ToResoniteLinkField());
members.Add("FeetFloatVelocityForce", FeetFloatVelocityForce.ToResoniteLinkField());
members.Add("FeetFloatVelocityDampeningSpeed", FeetFloatVelocityDampeningSpeed.ToResoniteLinkField());
members.Add("MaxFeetVelocityOffset", MaxFeetVelocityOffset.ToResoniteLinkField());
members.Add("VelocityAverageRate", VelocityAverageRate.ToResoniteLinkField());
members.Add("HoverVelocityThreshold", HoverVelocityThreshold.ToResoniteLinkField());
members.Add("HorizontalBodyAngle", HorizontalBodyAngle.ToResoniteLinkField());
members.Add("SupressWalkAnimationWhenHorizontal", SupressWalkAnimationWhenHorizontal.ToResoniteLinkField());
members.Add("AlwaysUseTrackersWhenHorizontal", AlwaysUseTrackersWhenHorizontal.ToResoniteLinkField());
members.Add("Gaits", new ResoniteLink.SyncList()
{
    Elements = Gaits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("GaitTransitionSpeed", GaitTransitionSpeed.ToResoniteLinkField());
members.Add("GaitMovementDirectionSmoothSpeed", GaitMovementDirectionSmoothSpeed.ToResoniteLinkField());
members.Add("RigCollidersRadiusRatio", RigCollidersRadiusRatio.ToResoniteLinkField());
members.Add("LeftHandRotationOffset", LeftHandRotationOffset.ToResoniteLinkField());
members.Add("RightHandRotationOffset", RightHandRotationOffset.ToResoniteLinkField());
members.Add("CurrentAverageVelocity", CurrentAverageVelocity.ToResoniteLinkField());
members.Add("CurrentOnGround", CurrentOnGround.ToResoniteLinkField());
members.Add("CurrentGaitIndex", CurrentGaitIndex.ToResoniteLinkField());
members.Add("_locomotionController", _locomotionController.ToResoniteReference(context));
members.Add("_leftHandNode", _leftHandNode.ToResoniteReference(context));
members.Add("_rightHandNode", _rightHandNode.ToResoniteReference(context));
members.Add("_leftElbowNode", _leftElbowNode.ToResoniteReference(context));
members.Add("_rightElbowNode", _rightElbowNode.ToResoniteReference(context));
members.Add("_leftFootNode", _leftFootNode.ToResoniteReference(context));
members.Add("_rightFootNode", _rightFootNode.ToResoniteReference(context));
members.Add("_leftKneeNode", _leftKneeNode.ToResoniteReference(context));
members.Add("_rightKneeNode", _rightKneeNode.ToResoniteReference(context));
members.Add("_headNode", _headNode.ToResoniteReference(context));
members.Add("_pelvisNode", _pelvisNode.ToResoniteReference(context));
members.Add("_chestNode", _chestNode.ToResoniteReference(context));
members.Add("_headProxy", _headProxy.ToResoniteReference(context));
members.Add("_pelvisProxy", _pelvisProxy.ToResoniteReference(context));
members.Add("_chestProxy", _chestProxy.ToResoniteReference(context));
members.Add("_leftHandProxy", _leftHandProxy.ToResoniteReference(context));
members.Add("_rightHandProxy", _rightHandProxy.ToResoniteReference(context));
members.Add("_leftElbowProxy", _leftElbowProxy.ToResoniteReference(context));
members.Add("_rightElbowProxy", _rightElbowProxy.ToResoniteReference(context));
members.Add("_leftFootProxy", _leftFootProxy.ToResoniteReference(context));
members.Add("_rightFootProxy", _rightFootProxy.ToResoniteReference(context));
members.Add("_leftKneeProxy", _leftKneeProxy.ToResoniteReference(context));
members.Add("_rightKneeProxy", _rightKneeProxy.ToResoniteReference(context));
members.Add("_leftKneeDefaultProxy", _leftKneeDefaultProxy.ToResoniteReference(context));
members.Add("_rightKneeDefaultProxy", _rightKneeDefaultProxy.ToResoniteReference(context));
members.Add("_headTargetPos", _headTargetPos.ToResoniteReference(context));
members.Add("_headTargetRot", _headTargetRot.ToResoniteReference(context));
members.Add("_pelvisTargetPos", _pelvisTargetPos.ToResoniteReference(context));
members.Add("_pelvisTargetRot", _pelvisTargetRot.ToResoniteReference(context));
members.Add("_chestTargetPos", _chestTargetPos.ToResoniteReference(context));
members.Add("_leftHandTargetPos", _leftHandTargetPos.ToResoniteReference(context));
members.Add("_leftHandTargetRot", _leftHandTargetRot.ToResoniteReference(context));
members.Add("_rightHandTargetPos", _rightHandTargetPos.ToResoniteReference(context));
members.Add("_rightHandTargetRot", _rightHandTargetRot.ToResoniteReference(context));
members.Add("_leftElbowTargetPos", _leftElbowTargetPos.ToResoniteReference(context));
members.Add("_rightElbowTargetPos", _rightElbowTargetPos.ToResoniteReference(context));
members.Add("_leftFootTargetPos", _leftFootTargetPos.ToResoniteReference(context));
members.Add("_leftFootTargetRot", _leftFootTargetRot.ToResoniteReference(context));
members.Add("_rightFootTargetPos", _rightFootTargetPos.ToResoniteReference(context));
members.Add("_rightFootTargetRot", _rightFootTargetRot.ToResoniteReference(context));
members.Add("_leftKneeTargetPos", _leftKneeTargetPos.ToResoniteReference(context));
members.Add("_rightKneeTargetPos", _rightKneeTargetPos.ToResoniteReference(context));
members.Add("_pelvisPositionWeight", _pelvisPositionWeight.ToResoniteReference(context));
members.Add("_pelvisRotationWeight", _pelvisRotationWeight.ToResoniteReference(context));
members.Add("_chestWeight", _chestWeight.ToResoniteReference(context));
members.Add("_locomotionWeight", _locomotionWeight.ToResoniteReference(context));
members.Add("_leftLegPositionWeight", _leftLegPositionWeight.ToResoniteReference(context));
members.Add("_leftLegRotationWeight", _leftLegRotationWeight.ToResoniteReference(context));
members.Add("_rightLegPositionWeight", _rightLegPositionWeight.ToResoniteReference(context));
members.Add("_rightLegRotationWeight", _rightLegRotationWeight.ToResoniteReference(context));
members.Add("_leftKneeBendWeight", _leftKneeBendWeight.ToResoniteReference(context));
members.Add("_rightKneeBendWeight", _rightKneeBendWeight.ToResoniteReference(context));
members.Add("_leftElbowBendWeight", _leftElbowBendWeight.ToResoniteReference(context));
members.Add("_rightElbowBendWeight", _rightElbowBendWeight.ToResoniteReference(context));
members.Add("_leftFootOffset", _leftFootOffset.ToResoniteReference(context));
members.Add("_rightFootOffset", _rightFootOffset.ToResoniteReference(context));
members.Add("_leftFootRelativeToRoot", _leftFootRelativeToRoot.ToResoniteLinkField());
members.Add("_rightFootRelativeToRoot", _rightFootRelativeToRoot.ToResoniteLinkField());
members.Add("_locomotionOffset", _locomotionOffset.ToResoniteReference(context));
members.Add("_simplifiedColliderEnabled", _simplifiedColliderEnabled.ToResoniteReference(context));
members.Add("_rigCollidersEnabledStates", new ResoniteLink.SyncList()
{
    Elements = _rigCollidersEnabledStates.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_horizontalTrackingLocked", _horizontalTrackingLocked.ToResoniteLinkField());
}

}
}
