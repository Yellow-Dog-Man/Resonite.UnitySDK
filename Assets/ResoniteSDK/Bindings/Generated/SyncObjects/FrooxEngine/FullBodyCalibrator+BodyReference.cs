
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+BodyReference
// Generated on: úterý 24. února 2026 18:20:22
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
    public partial class FullBodyCalibrator
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyCalibrator+BodyReference")]
public partial class BodyReference : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FinalIK.VRIKAvatar _vrIkAvatar;
public global::FrooxEngine.CommonAvatar.IAvatarObject _head;
public global::FrooxEngine.CommonAvatar.IAvatarObject _hips;
public global::FrooxEngine.CommonAvatar.IAvatarObject _chest;
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftHand;
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightHand;
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftElbow;
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightElbow;
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftFoot;
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightFoot;
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftKnee;
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightKnee;
public global::FrooxEngine.IField<UnityEngine.Vector3> _headPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _headRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftHandPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftHandRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightHandPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightHandRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _hipsPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _hipsRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _chestPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _chestRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftFootRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightFootRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftKneePos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftKneeRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightKneePos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightKneeRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftElbowPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftElbowRot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightElbowPos;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightElbowRot;
public global::FrooxEngine.IField<global::System.Single> _ikWeight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_vrIkAvatar", _vrIkAvatar.ToResoniteReference(context));
members.Add("_head", _head.ToResoniteReference(context));
members.Add("_hips", _hips.ToResoniteReference(context));
members.Add("_chest", _chest.ToResoniteReference(context));
members.Add("_leftHand", _leftHand.ToResoniteReference(context));
members.Add("_rightHand", _rightHand.ToResoniteReference(context));
members.Add("_leftElbow", _leftElbow.ToResoniteReference(context));
members.Add("_rightElbow", _rightElbow.ToResoniteReference(context));
members.Add("_leftFoot", _leftFoot.ToResoniteReference(context));
members.Add("_rightFoot", _rightFoot.ToResoniteReference(context));
members.Add("_leftKnee", _leftKnee.ToResoniteReference(context));
members.Add("_rightKnee", _rightKnee.ToResoniteReference(context));
members.Add("_headPos", _headPos.ToResoniteReference(context));
members.Add("_headRot", _headRot.ToResoniteReference(context));
members.Add("_leftHandPos", _leftHandPos.ToResoniteReference(context));
members.Add("_leftHandRot", _leftHandRot.ToResoniteReference(context));
members.Add("_rightHandPos", _rightHandPos.ToResoniteReference(context));
members.Add("_rightHandRot", _rightHandRot.ToResoniteReference(context));
members.Add("_hipsPos", _hipsPos.ToResoniteReference(context));
members.Add("_hipsRot", _hipsRot.ToResoniteReference(context));
members.Add("_chestPos", _chestPos.ToResoniteReference(context));
members.Add("_chestRot", _chestRot.ToResoniteReference(context));
members.Add("_leftFootPos", _leftFootPos.ToResoniteReference(context));
members.Add("_leftFootRot", _leftFootRot.ToResoniteReference(context));
members.Add("_rightFootPos", _rightFootPos.ToResoniteReference(context));
members.Add("_rightFootRot", _rightFootRot.ToResoniteReference(context));
members.Add("_leftKneePos", _leftKneePos.ToResoniteReference(context));
members.Add("_leftKneeRot", _leftKneeRot.ToResoniteReference(context));
members.Add("_rightKneePos", _rightKneePos.ToResoniteReference(context));
members.Add("_rightKneeRot", _rightKneeRot.ToResoniteReference(context));
members.Add("_leftElbowPos", _leftElbowPos.ToResoniteReference(context));
members.Add("_leftElbowRot", _leftElbowRot.ToResoniteReference(context));
members.Add("_rightElbowPos", _rightElbowPos.ToResoniteReference(context));
members.Add("_rightElbowRot", _rightElbowRot.ToResoniteReference(context));
members.Add("_ikWeight", _ikWeight.ToResoniteReference(context));
}

}
            }
}
