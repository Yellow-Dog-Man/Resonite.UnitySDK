
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+BodyReference
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_vrIkAvatar", new ResoniteLink.Reference() { });
members.Add("_head", new ResoniteLink.Reference() { });
members.Add("_hips", new ResoniteLink.Reference() { });
members.Add("_chest", new ResoniteLink.Reference() { });
members.Add("_leftHand", new ResoniteLink.Reference() { });
members.Add("_rightHand", new ResoniteLink.Reference() { });
members.Add("_leftElbow", new ResoniteLink.Reference() { });
members.Add("_rightElbow", new ResoniteLink.Reference() { });
members.Add("_leftFoot", new ResoniteLink.Reference() { });
members.Add("_rightFoot", new ResoniteLink.Reference() { });
members.Add("_leftKnee", new ResoniteLink.Reference() { });
members.Add("_rightKnee", new ResoniteLink.Reference() { });
members.Add("_headPos", new ResoniteLink.Reference() { });
members.Add("_headRot", new ResoniteLink.Reference() { });
members.Add("_leftHandPos", new ResoniteLink.Reference() { });
members.Add("_leftHandRot", new ResoniteLink.Reference() { });
members.Add("_rightHandPos", new ResoniteLink.Reference() { });
members.Add("_rightHandRot", new ResoniteLink.Reference() { });
members.Add("_hipsPos", new ResoniteLink.Reference() { });
members.Add("_hipsRot", new ResoniteLink.Reference() { });
members.Add("_chestPos", new ResoniteLink.Reference() { });
members.Add("_chestRot", new ResoniteLink.Reference() { });
members.Add("_leftFootPos", new ResoniteLink.Reference() { });
members.Add("_leftFootRot", new ResoniteLink.Reference() { });
members.Add("_rightFootPos", new ResoniteLink.Reference() { });
members.Add("_rightFootRot", new ResoniteLink.Reference() { });
members.Add("_leftKneePos", new ResoniteLink.Reference() { });
members.Add("_leftKneeRot", new ResoniteLink.Reference() { });
members.Add("_rightKneePos", new ResoniteLink.Reference() { });
members.Add("_rightKneeRot", new ResoniteLink.Reference() { });
members.Add("_leftElbowPos", new ResoniteLink.Reference() { });
members.Add("_leftElbowRot", new ResoniteLink.Reference() { });
members.Add("_rightElbowPos", new ResoniteLink.Reference() { });
members.Add("_rightElbowRot", new ResoniteLink.Reference() { });
members.Add("_ikWeight", new ResoniteLink.Reference() { });
}

}
            }
}
