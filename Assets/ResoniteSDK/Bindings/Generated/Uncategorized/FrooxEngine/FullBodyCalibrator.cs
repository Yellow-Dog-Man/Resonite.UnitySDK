
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.User TargetUser;
public global::System.Boolean UseSymmetryForTrackers;
public global::System.Boolean UseSymmetryForAvatar;
public global::System.Boolean ShowBodyOverlay;
public global::System.Boolean ShowAvatarOverlay;
public global::System.Single HeightCompensation;
public global::System.Single AvatarHeightCompensation;
public global::System.Boolean _calibratingPose;
public UnityEngine.Vector3 _spaceOffset;
public global::FrooxEngine.Grabbable _grabbable;
public global::FrooxEngine.Slot _headReference;
public global::FrooxEngine.Slot _leftHandReference;
public global::FrooxEngine.Slot _rightHandReference;
public global::FrooxEngine.TrackedDevicePositioner _hipsSource;
public global::FrooxEngine.TrackedDevicePositioner _chestSource;
public global::FrooxEngine.TrackedDevicePositioner _leftFootSource;
public global::FrooxEngine.TrackedDevicePositioner _rightFootSource;
public global::FrooxEngine.TrackedDevicePositioner _leftElbowSource;
public global::FrooxEngine.TrackedDevicePositioner _rightElbowSource;
public global::FrooxEngine.TrackedDevicePositioner _leftKneeSource;
public global::FrooxEngine.TrackedDevicePositioner _rightKneeSource;
public global::FrooxEngine.FullBodyCalibratorDialog _dialog;
public global::FrooxEngine.FullBodyCalibrator.BodyReference _platformBody;
public global::FrooxEngine.FullBodyCalibrator.BodyReference _userBody;
public global::FrooxEngine.FullBodyCalibrator.BodyReference _customAvatar;
public global::FrooxEngine.Slot _leftHandOverride;
public global::FrooxEngine.Slot _rightHandOverride;
public global::FrooxEngine.FinalIK.VRIKAvatar _targetCustomAvatar;
public global::FrooxEngine.Slot _avatarHipsOffset;
public global::FrooxEngine.Slot _avatarLeftFootOffset;
public global::FrooxEngine.Slot _avatarRightFootOffset;
public global::FrooxEngine.Slot _avatarLeftKneeDefaultOffset;
public global::FrooxEngine.Slot _avatarRightKneeDefaultOffset;
public global::FrooxEngine.Slot _avatarHipHandle;
public global::FrooxEngine.Slot _avatarLeftFootHandle;
public global::FrooxEngine.Slot _avatarRightFootHandle;
public global::FrooxEngine.Slot _avatarLeftKneeHandle;
public global::FrooxEngine.Slot _avatarRightKneeHandle;
public global::FrooxEngine.IField<UnityEngine.Vector3> _avatarLeftKneeOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _avatarRightKneeOffset;
public System.Collections.Generic.List<global::FrooxEngine.MaterialSet> _platformBodyMaterialSets;
public global::FrooxEngine.Slot _ground;
public System.Collections.Generic.List<global::FrooxEngine.FullBodyCalibrator.Tracker> _trackers;
public global::FrooxEngine.Slot _visualizationRoot;
public global::FrooxEngine.FresnelMaterial _bodyNodeMaterial;
public global::FrooxEngine.OverlayFresnelMaterial _calibrationReferenceMaterial;
public global::FrooxEngine.OverlayFresnelMaterial _leftHandOverrideMaterial;
public global::FrooxEngine.OverlayFresnelMaterial _rightHandOverrideMaterial;
public global::FrooxEngine.IField<UnityEngine.ColorX> _leftHandOverrideFrontColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _leftHandOverrideBehindColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _rightHandOverrideFrontColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _rightHandOverrideBehindColor;
public global::FrooxEngine.StaticTexture2D _patternTex;
public global::FrooxEngine.TextRenderer _title;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("UseSymmetryForTrackers", UseSymmetryForTrackers.ToResoniteLinkField());
members.Add("UseSymmetryForAvatar", UseSymmetryForAvatar.ToResoniteLinkField());
members.Add("ShowBodyOverlay", ShowBodyOverlay.ToResoniteLinkField());
members.Add("ShowAvatarOverlay", ShowAvatarOverlay.ToResoniteLinkField());
members.Add("HeightCompensation", HeightCompensation.ToResoniteLinkField());
members.Add("AvatarHeightCompensation", AvatarHeightCompensation.ToResoniteLinkField());
members.Add("_calibratingPose", _calibratingPose.ToResoniteLinkField());
members.Add("_spaceOffset", _spaceOffset.ToResoniteLinkField());
members.Add("_grabbable", _grabbable.ToResoniteReference(context));
members.Add("_headReference", _headReference.ToResoniteReference(context));
members.Add("_leftHandReference", _leftHandReference.ToResoniteReference(context));
members.Add("_rightHandReference", _rightHandReference.ToResoniteReference(context));
members.Add("_hipsSource", _hipsSource.ToResoniteReference(context));
members.Add("_chestSource", _chestSource.ToResoniteReference(context));
members.Add("_leftFootSource", _leftFootSource.ToResoniteReference(context));
members.Add("_rightFootSource", _rightFootSource.ToResoniteReference(context));
members.Add("_leftElbowSource", _leftElbowSource.ToResoniteReference(context));
members.Add("_rightElbowSource", _rightElbowSource.ToResoniteReference(context));
members.Add("_leftKneeSource", _leftKneeSource.ToResoniteReference(context));
members.Add("_rightKneeSource", _rightKneeSource.ToResoniteReference(context));
members.Add("_dialog", _dialog.ToResoniteReference(context));
members.Add("_platformBody", new ResoniteLink.SyncObject() { Members = _platformBody.CollectMembers(context) });
members.Add("_userBody", new ResoniteLink.SyncObject() { Members = _userBody.CollectMembers(context) });
members.Add("_customAvatar", new ResoniteLink.SyncObject() { Members = _customAvatar.CollectMembers(context) });
members.Add("_leftHandOverride", _leftHandOverride.ToResoniteReference(context));
members.Add("_rightHandOverride", _rightHandOverride.ToResoniteReference(context));
members.Add("_targetCustomAvatar", _targetCustomAvatar.ToResoniteReference(context));
members.Add("_avatarHipsOffset", _avatarHipsOffset.ToResoniteReference(context));
members.Add("_avatarLeftFootOffset", _avatarLeftFootOffset.ToResoniteReference(context));
members.Add("_avatarRightFootOffset", _avatarRightFootOffset.ToResoniteReference(context));
members.Add("_avatarLeftKneeDefaultOffset", _avatarLeftKneeDefaultOffset.ToResoniteReference(context));
members.Add("_avatarRightKneeDefaultOffset", _avatarRightKneeDefaultOffset.ToResoniteReference(context));
members.Add("_avatarHipHandle", _avatarHipHandle.ToResoniteReference(context));
members.Add("_avatarLeftFootHandle", _avatarLeftFootHandle.ToResoniteReference(context));
members.Add("_avatarRightFootHandle", _avatarRightFootHandle.ToResoniteReference(context));
members.Add("_avatarLeftKneeHandle", _avatarLeftKneeHandle.ToResoniteReference(context));
members.Add("_avatarRightKneeHandle", _avatarRightKneeHandle.ToResoniteReference(context));
members.Add("_avatarLeftKneeOffset", _avatarLeftKneeOffset.ToResoniteReference(context));
members.Add("_avatarRightKneeOffset", _avatarRightKneeOffset.ToResoniteReference(context));
members.Add("_platformBodyMaterialSets", new ResoniteLink.SyncList()
{
    Elements = _platformBodyMaterialSets.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_ground", _ground.ToResoniteReference(context));
members.Add("_trackers", new ResoniteLink.SyncList()
{
    Elements = _trackers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_visualizationRoot", _visualizationRoot.ToResoniteReference(context));
members.Add("_bodyNodeMaterial", _bodyNodeMaterial.ToResoniteReference(context));
members.Add("_calibrationReferenceMaterial", _calibrationReferenceMaterial.ToResoniteReference(context));
members.Add("_leftHandOverrideMaterial", _leftHandOverrideMaterial.ToResoniteReference(context));
members.Add("_rightHandOverrideMaterial", _rightHandOverrideMaterial.ToResoniteReference(context));
members.Add("_leftHandOverrideFrontColor", _leftHandOverrideFrontColor.ToResoniteReference(context));
members.Add("_leftHandOverrideBehindColor", _leftHandOverrideBehindColor.ToResoniteReference(context));
members.Add("_rightHandOverrideFrontColor", _rightHandOverrideFrontColor.ToResoniteReference(context));
members.Add("_rightHandOverrideBehindColor", _rightHandOverrideBehindColor.ToResoniteReference(context));
members.Add("_patternTex", _patternTex.ToResoniteReference(context));
members.Add("_title", _title.ToResoniteReference(context));
}

}
}
