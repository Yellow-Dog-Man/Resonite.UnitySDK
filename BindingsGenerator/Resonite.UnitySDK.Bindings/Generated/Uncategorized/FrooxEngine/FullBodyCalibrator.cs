
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyCalibrator")]
public partial class FullBodyCalibrator : global::FrooxEngine.Component

{
    public global::FrooxEngine.User TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> TargetUser_Element = new();
public global::System.Boolean UseSymmetryForTrackers { get => UseSymmetryForTrackers_Element.Data; set => UseSymmetryForTrackers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSymmetryForTrackers_Element = new();
public global::System.Boolean UseSymmetryForAvatar { get => UseSymmetryForAvatar_Element.Data; set => UseSymmetryForAvatar_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSymmetryForAvatar_Element = new();
public global::System.Boolean ShowBodyOverlay { get => ShowBodyOverlay_Element.Data; set => ShowBodyOverlay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowBodyOverlay_Element = new();
public global::System.Boolean ShowAvatarOverlay { get => ShowAvatarOverlay_Element.Data; set => ShowAvatarOverlay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowAvatarOverlay_Element = new();
public global::System.Single HeightCompensation { get => HeightCompensation_Element.Data; set => HeightCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightCompensation_Element = new();
public global::System.Single AvatarHeightCompensation { get => AvatarHeightCompensation_Element.Data; set => AvatarHeightCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AvatarHeightCompensation_Element = new();
public global::System.Boolean _calibratingPose { get => _calibratingPose_Element.Data; set => _calibratingPose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calibratingPose_Element = new();
public UnityEngine.Vector3 _spaceOffset { get => _spaceOffset_Element.Data; set => _spaceOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _spaceOffset_Element = new();
public global::FrooxEngine.Grabbable _grabbable { get => _grabbable_Element.Data; set => _grabbable_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabbable>, global::FrooxEngine.Grabbable> _grabbable_Element = new();
public global::FrooxEngine.Slot _headReference { get => _headReference_Element.Data; set => _headReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _headReference_Element = new();
public global::FrooxEngine.Slot _leftHandReference { get => _leftHandReference_Element.Data; set => _leftHandReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftHandReference_Element = new();
public global::FrooxEngine.Slot _rightHandReference { get => _rightHandReference_Element.Data; set => _rightHandReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightHandReference_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _hipsSource { get => _hipsSource_Element.Data; set => _hipsSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _hipsSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _chestSource { get => _chestSource_Element.Data; set => _chestSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _chestSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _leftFootSource { get => _leftFootSource_Element.Data; set => _leftFootSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _leftFootSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _rightFootSource { get => _rightFootSource_Element.Data; set => _rightFootSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _rightFootSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _leftElbowSource { get => _leftElbowSource_Element.Data; set => _leftElbowSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _leftElbowSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _rightElbowSource { get => _rightElbowSource_Element.Data; set => _rightElbowSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _rightElbowSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _leftKneeSource { get => _leftKneeSource_Element.Data; set => _leftKneeSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _leftKneeSource_Element = new();
public global::FrooxEngine.TrackedDevicePositioner _rightKneeSource { get => _rightKneeSource_Element.Data; set => _rightKneeSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> _rightKneeSource_Element = new();
public global::FrooxEngine.FullBodyCalibratorDialog _dialog { get => _dialog_Element.Data; set => _dialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FullBodyCalibratorDialog>, global::FrooxEngine.FullBodyCalibratorDialog> _dialog_Element = new();
public global::FrooxEngine.FullBodyCalibrator.BodyReference _platformBody = new();
public global::FrooxEngine.FullBodyCalibrator.BodyReference _userBody = new();
public global::FrooxEngine.FullBodyCalibrator.BodyReference _customAvatar = new();
public global::FrooxEngine.Slot _leftHandOverride { get => _leftHandOverride_Element.Data; set => _leftHandOverride_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _leftHandOverride_Element = new();
public global::FrooxEngine.Slot _rightHandOverride { get => _rightHandOverride_Element.Data; set => _rightHandOverride_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rightHandOverride_Element = new();
public global::FrooxEngine.FinalIK.VRIKAvatar _targetCustomAvatar { get => _targetCustomAvatar_Element.Data; set => _targetCustomAvatar_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FinalIK.VRIKAvatar>, global::FrooxEngine.FinalIK.VRIKAvatar> _targetCustomAvatar_Element = new();
public global::FrooxEngine.Slot _avatarHipsOffset { get => _avatarHipsOffset_Element.Data; set => _avatarHipsOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarHipsOffset_Element = new();
public global::FrooxEngine.Slot _avatarLeftFootOffset { get => _avatarLeftFootOffset_Element.Data; set => _avatarLeftFootOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarLeftFootOffset_Element = new();
public global::FrooxEngine.Slot _avatarRightFootOffset { get => _avatarRightFootOffset_Element.Data; set => _avatarRightFootOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarRightFootOffset_Element = new();
public global::FrooxEngine.Slot _avatarLeftKneeDefaultOffset { get => _avatarLeftKneeDefaultOffset_Element.Data; set => _avatarLeftKneeDefaultOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarLeftKneeDefaultOffset_Element = new();
public global::FrooxEngine.Slot _avatarRightKneeDefaultOffset { get => _avatarRightKneeDefaultOffset_Element.Data; set => _avatarRightKneeDefaultOffset_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarRightKneeDefaultOffset_Element = new();
public global::FrooxEngine.Slot _avatarHipHandle { get => _avatarHipHandle_Element.Data; set => _avatarHipHandle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarHipHandle_Element = new();
public global::FrooxEngine.Slot _avatarLeftFootHandle { get => _avatarLeftFootHandle_Element.Data; set => _avatarLeftFootHandle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarLeftFootHandle_Element = new();
public global::FrooxEngine.Slot _avatarRightFootHandle { get => _avatarRightFootHandle_Element.Data; set => _avatarRightFootHandle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarRightFootHandle_Element = new();
public global::FrooxEngine.Slot _avatarLeftKneeHandle { get => _avatarLeftKneeHandle_Element.Data; set => _avatarLeftKneeHandle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarLeftKneeHandle_Element = new();
public global::FrooxEngine.Slot _avatarRightKneeHandle { get => _avatarRightKneeHandle_Element.Data; set => _avatarRightKneeHandle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _avatarRightKneeHandle_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _avatarLeftKneeOffset { get => _avatarLeftKneeOffset_Element.Data; set => _avatarLeftKneeOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldHook<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _avatarLeftKneeOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _avatarRightKneeOffset { get => _avatarRightKneeOffset_Element.Data; set => _avatarRightKneeOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldHook<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _avatarRightKneeOffset_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MaterialSet>, global::FrooxEngine.MaterialSet, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MaterialSet>, global::FrooxEngine.MaterialSet>> _platformBodyMaterialSets = new();
public global::FrooxEngine.Slot _ground { get => _ground_Element.Data; set => _ground_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _ground_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FullBodyCalibrator.Tracker>, global::FrooxEngine.FullBodyCalibrator.Tracker> _trackers = new();
public global::FrooxEngine.Slot _visualizationRoot { get => _visualizationRoot_Element.Data; set => _visualizationRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualizationRoot_Element = new();
public global::FrooxEngine.FresnelMaterial _bodyNodeMaterial { get => _bodyNodeMaterial_Element.Data; set => _bodyNodeMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _bodyNodeMaterial_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _calibrationReferenceMaterial { get => _calibrationReferenceMaterial_Element.Data; set => _calibrationReferenceMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _calibrationReferenceMaterial_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _leftHandOverrideMaterial { get => _leftHandOverrideMaterial_Element.Data; set => _leftHandOverrideMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _leftHandOverrideMaterial_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _rightHandOverrideMaterial { get => _rightHandOverrideMaterial_Element.Data; set => _rightHandOverrideMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _rightHandOverrideMaterial_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _leftHandOverrideFrontColor { get => _leftHandOverrideFrontColor_Element.Data; set => _leftHandOverrideFrontColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _leftHandOverrideFrontColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _leftHandOverrideBehindColor { get => _leftHandOverrideBehindColor_Element.Data; set => _leftHandOverrideBehindColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _leftHandOverrideBehindColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _rightHandOverrideFrontColor { get => _rightHandOverrideFrontColor_Element.Data; set => _rightHandOverrideFrontColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _rightHandOverrideFrontColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _rightHandOverrideBehindColor { get => _rightHandOverrideBehindColor_Element.Data; set => _rightHandOverrideBehindColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _rightHandOverrideBehindColor_Element = new();
public global::FrooxEngine.StaticTexture2D _patternTex { get => _patternTex_Element.Data; set => _patternTex_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _patternTex_Element = new();
public global::FrooxEngine.TextRenderer _title { get => _title_Element.Data; set => _title_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _title_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("UseSymmetryForTrackers", UseSymmetryForTrackers_Element.ToLinkField(context));
members.Add("UseSymmetryForAvatar", UseSymmetryForAvatar_Element.ToLinkField(context));
members.Add("ShowBodyOverlay", ShowBodyOverlay_Element.ToLinkField(context));
members.Add("ShowAvatarOverlay", ShowAvatarOverlay_Element.ToLinkField(context));
members.Add("HeightCompensation", HeightCompensation_Element.ToLinkField(context));
members.Add("AvatarHeightCompensation", AvatarHeightCompensation_Element.ToLinkField(context));
members.Add("_calibratingPose", _calibratingPose_Element.ToLinkField(context));
members.Add("_spaceOffset", _spaceOffset_Element.ToLinkField(context));
members.Add("_grabbable", _grabbable_Element.ToLinkReference(context));
members.Add("_headReference", _headReference_Element.ToLinkReference(context));
members.Add("_leftHandReference", _leftHandReference_Element.ToLinkReference(context));
members.Add("_rightHandReference", _rightHandReference_Element.ToLinkReference(context));
members.Add("_hipsSource", _hipsSource_Element.ToLinkReference(context));
members.Add("_chestSource", _chestSource_Element.ToLinkReference(context));
members.Add("_leftFootSource", _leftFootSource_Element.ToLinkReference(context));
members.Add("_rightFootSource", _rightFootSource_Element.ToLinkReference(context));
members.Add("_leftElbowSource", _leftElbowSource_Element.ToLinkReference(context));
members.Add("_rightElbowSource", _rightElbowSource_Element.ToLinkReference(context));
members.Add("_leftKneeSource", _leftKneeSource_Element.ToLinkReference(context));
members.Add("_rightKneeSource", _rightKneeSource_Element.ToLinkReference(context));
members.Add("_dialog", _dialog_Element.ToLinkReference(context));
members.Add("_platformBody", _platformBody.ToLinkSyncObject(context));
members.Add("_userBody", _userBody.ToLinkSyncObject(context));
members.Add("_customAvatar", _customAvatar.ToLinkSyncObject(context));
members.Add("_leftHandOverride", _leftHandOverride_Element.ToLinkReference(context));
members.Add("_rightHandOverride", _rightHandOverride_Element.ToLinkReference(context));
members.Add("_targetCustomAvatar", _targetCustomAvatar_Element.ToLinkReference(context));
members.Add("_avatarHipsOffset", _avatarHipsOffset_Element.ToLinkReference(context));
members.Add("_avatarLeftFootOffset", _avatarLeftFootOffset_Element.ToLinkReference(context));
members.Add("_avatarRightFootOffset", _avatarRightFootOffset_Element.ToLinkReference(context));
members.Add("_avatarLeftKneeDefaultOffset", _avatarLeftKneeDefaultOffset_Element.ToLinkReference(context));
members.Add("_avatarRightKneeDefaultOffset", _avatarRightKneeDefaultOffset_Element.ToLinkReference(context));
members.Add("_avatarHipHandle", _avatarHipHandle_Element.ToLinkReference(context));
members.Add("_avatarLeftFootHandle", _avatarLeftFootHandle_Element.ToLinkReference(context));
members.Add("_avatarRightFootHandle", _avatarRightFootHandle_Element.ToLinkReference(context));
members.Add("_avatarLeftKneeHandle", _avatarLeftKneeHandle_Element.ToLinkReference(context));
members.Add("_avatarRightKneeHandle", _avatarRightKneeHandle_Element.ToLinkReference(context));
members.Add("_avatarLeftKneeOffset", _avatarLeftKneeOffset_Element.ToLinkReference(context));
members.Add("_avatarRightKneeOffset", _avatarRightKneeOffset_Element.ToLinkReference(context));
members.Add("_platformBodyMaterialSets", _platformBodyMaterialSets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_ground", _ground_Element.ToLinkReference(context));
members.Add("_trackers", _trackers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_visualizationRoot", _visualizationRoot_Element.ToLinkReference(context));
members.Add("_bodyNodeMaterial", _bodyNodeMaterial_Element.ToLinkReference(context));
members.Add("_calibrationReferenceMaterial", _calibrationReferenceMaterial_Element.ToLinkReference(context));
members.Add("_leftHandOverrideMaterial", _leftHandOverrideMaterial_Element.ToLinkReference(context));
members.Add("_rightHandOverrideMaterial", _rightHandOverrideMaterial_Element.ToLinkReference(context));
members.Add("_leftHandOverrideFrontColor", _leftHandOverrideFrontColor_Element.ToLinkReference(context));
members.Add("_leftHandOverrideBehindColor", _leftHandOverrideBehindColor_Element.ToLinkReference(context));
members.Add("_rightHandOverrideFrontColor", _rightHandOverrideFrontColor_Element.ToLinkReference(context));
members.Add("_rightHandOverrideBehindColor", _rightHandOverrideBehindColor_Element.ToLinkReference(context));
members.Add("_patternTex", _patternTex_Element.ToLinkReference(context));
members.Add("_title", _title_Element.ToLinkReference(context));
}

}
}
