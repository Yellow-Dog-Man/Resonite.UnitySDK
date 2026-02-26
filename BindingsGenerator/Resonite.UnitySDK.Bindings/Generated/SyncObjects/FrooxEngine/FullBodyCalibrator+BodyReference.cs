
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+BodyReference
// Generated on: čtvrtek 26. února 2026 15:09:11
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.FinalIK.VRIKAvatar _vrIkAvatar { get => _vrIkAvatar_Element.Data; set => _vrIkAvatar_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FinalIK.VRIKAvatar>, global::FrooxEngine.FinalIK.VRIKAvatar> _vrIkAvatar_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _head { get => _head_Element.Data; set => _head_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _head_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _hips { get => _hips_Element.Data; set => _hips_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _hips_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _chest { get => _chest_Element.Data; set => _chest_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _chest_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftHand { get => _leftHand_Element.Data; set => _leftHand_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _leftHand_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightHand { get => _rightHand_Element.Data; set => _rightHand_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _rightHand_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftElbow { get => _leftElbow_Element.Data; set => _leftElbow_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _leftElbow_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightElbow { get => _rightElbow_Element.Data; set => _rightElbow_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _rightElbow_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftFoot { get => _leftFoot_Element.Data; set => _leftFoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _leftFoot_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightFoot { get => _rightFoot_Element.Data; set => _rightFoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _rightFoot_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _leftKnee { get => _leftKnee_Element.Data; set => _leftKnee_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _leftKnee_Element = new();
public global::FrooxEngine.CommonAvatar.IAvatarObject _rightKnee { get => _rightKnee_Element.Data; set => _rightKnee_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject> _rightKnee_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _headPos { get => _headPos_Element.Data; set => _headPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _headPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _headRot { get => _headRot_Element.Data; set => _headRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _headRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftHandPos { get => _leftHandPos_Element.Data; set => _leftHandPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftHandPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftHandRot { get => _leftHandRot_Element.Data; set => _leftHandRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftHandRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightHandPos { get => _rightHandPos_Element.Data; set => _rightHandPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightHandPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightHandRot { get => _rightHandRot_Element.Data; set => _rightHandRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightHandRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _hipsPos { get => _hipsPos_Element.Data; set => _hipsPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _hipsPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _hipsRot { get => _hipsRot_Element.Data; set => _hipsRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _hipsRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _chestPos { get => _chestPos_Element.Data; set => _chestPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _chestPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _chestRot { get => _chestRot_Element.Data; set => _chestRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _chestRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftFootPos { get => _leftFootPos_Element.Data; set => _leftFootPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftFootPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftFootRot { get => _leftFootRot_Element.Data; set => _leftFootRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftFootRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightFootPos { get => _rightFootPos_Element.Data; set => _rightFootPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightFootPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightFootRot { get => _rightFootRot_Element.Data; set => _rightFootRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightFootRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftKneePos { get => _leftKneePos_Element.Data; set => _leftKneePos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftKneePos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftKneeRot { get => _leftKneeRot_Element.Data; set => _leftKneeRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftKneeRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightKneePos { get => _rightKneePos_Element.Data; set => _rightKneePos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightKneePos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightKneeRot { get => _rightKneeRot_Element.Data; set => _rightKneeRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightKneeRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftElbowPos { get => _leftElbowPos_Element.Data; set => _leftElbowPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftElbowPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _leftElbowRot { get => _leftElbowRot_Element.Data; set => _leftElbowRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _leftElbowRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightElbowPos { get => _rightElbowPos_Element.Data; set => _rightElbowPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightElbowPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rightElbowRot { get => _rightElbowRot_Element.Data; set => _rightElbowRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rightElbowRot_Element = new();
public global::FrooxEngine.IField<global::System.Single> _ikWeight { get => _ikWeight_Element.Data; set => _ikWeight_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _ikWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_vrIkAvatar", _vrIkAvatar_Element.ToLinkReference(context));
members.Add("_head", _head_Element.ToLinkReference(context));
members.Add("_hips", _hips_Element.ToLinkReference(context));
members.Add("_chest", _chest_Element.ToLinkReference(context));
members.Add("_leftHand", _leftHand_Element.ToLinkReference(context));
members.Add("_rightHand", _rightHand_Element.ToLinkReference(context));
members.Add("_leftElbow", _leftElbow_Element.ToLinkReference(context));
members.Add("_rightElbow", _rightElbow_Element.ToLinkReference(context));
members.Add("_leftFoot", _leftFoot_Element.ToLinkReference(context));
members.Add("_rightFoot", _rightFoot_Element.ToLinkReference(context));
members.Add("_leftKnee", _leftKnee_Element.ToLinkReference(context));
members.Add("_rightKnee", _rightKnee_Element.ToLinkReference(context));
members.Add("_headPos", _headPos_Element.ToLinkReference(context));
members.Add("_headRot", _headRot_Element.ToLinkReference(context));
members.Add("_leftHandPos", _leftHandPos_Element.ToLinkReference(context));
members.Add("_leftHandRot", _leftHandRot_Element.ToLinkReference(context));
members.Add("_rightHandPos", _rightHandPos_Element.ToLinkReference(context));
members.Add("_rightHandRot", _rightHandRot_Element.ToLinkReference(context));
members.Add("_hipsPos", _hipsPos_Element.ToLinkReference(context));
members.Add("_hipsRot", _hipsRot_Element.ToLinkReference(context));
members.Add("_chestPos", _chestPos_Element.ToLinkReference(context));
members.Add("_chestRot", _chestRot_Element.ToLinkReference(context));
members.Add("_leftFootPos", _leftFootPos_Element.ToLinkReference(context));
members.Add("_leftFootRot", _leftFootRot_Element.ToLinkReference(context));
members.Add("_rightFootPos", _rightFootPos_Element.ToLinkReference(context));
members.Add("_rightFootRot", _rightFootRot_Element.ToLinkReference(context));
members.Add("_leftKneePos", _leftKneePos_Element.ToLinkReference(context));
members.Add("_leftKneeRot", _leftKneeRot_Element.ToLinkReference(context));
members.Add("_rightKneePos", _rightKneePos_Element.ToLinkReference(context));
members.Add("_rightKneeRot", _rightKneeRot_Element.ToLinkReference(context));
members.Add("_leftElbowPos", _leftElbowPos_Element.ToLinkReference(context));
members.Add("_leftElbowRot", _leftElbowRot_Element.ToLinkReference(context));
members.Add("_rightElbowPos", _rightElbowPos_Element.ToLinkReference(context));
members.Add("_rightElbowRot", _rightElbowRot_Element.ToLinkReference(context));
members.Add("_ikWeight", _ikWeight_Element.ToLinkReference(context));
}

}
            }
}
