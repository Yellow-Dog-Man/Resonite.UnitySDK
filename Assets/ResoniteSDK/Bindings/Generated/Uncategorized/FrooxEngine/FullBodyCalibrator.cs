
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetUser", new ResoniteLink.Reference() { });
members.Add("UseSymmetryForTrackers", UseSymmetryForTrackers.ToResoniteLinkField());
members.Add("UseSymmetryForAvatar", UseSymmetryForAvatar.ToResoniteLinkField());
members.Add("ShowBodyOverlay", ShowBodyOverlay.ToResoniteLinkField());
members.Add("ShowAvatarOverlay", ShowAvatarOverlay.ToResoniteLinkField());
members.Add("HeightCompensation", HeightCompensation.ToResoniteLinkField());
members.Add("AvatarHeightCompensation", AvatarHeightCompensation.ToResoniteLinkField());
members.Add("_calibratingPose", _calibratingPose.ToResoniteLinkField());
members.Add("_spaceOffset", _spaceOffset.ToResoniteLinkField());
members.Add("_grabbable", new ResoniteLink.Reference() { });
members.Add("_headReference", new ResoniteLink.Reference() { });
members.Add("_leftHandReference", new ResoniteLink.Reference() { });
members.Add("_rightHandReference", new ResoniteLink.Reference() { });
members.Add("_hipsSource", new ResoniteLink.Reference() { });
members.Add("_chestSource", new ResoniteLink.Reference() { });
members.Add("_leftFootSource", new ResoniteLink.Reference() { });
members.Add("_rightFootSource", new ResoniteLink.Reference() { });
members.Add("_leftElbowSource", new ResoniteLink.Reference() { });
members.Add("_rightElbowSource", new ResoniteLink.Reference() { });
members.Add("_leftKneeSource", new ResoniteLink.Reference() { });
members.Add("_rightKneeSource", new ResoniteLink.Reference() { });
members.Add("_dialog", new ResoniteLink.Reference() { });
members.Add("_platformBody", new ResoniteLink.SyncObject() { Members = _platformBody.CollectMembers() });
members.Add("_userBody", new ResoniteLink.SyncObject() { Members = _userBody.CollectMembers() });
members.Add("_customAvatar", new ResoniteLink.SyncObject() { Members = _customAvatar.CollectMembers() });
members.Add("_leftHandOverride", new ResoniteLink.Reference() { });
members.Add("_rightHandOverride", new ResoniteLink.Reference() { });
members.Add("_targetCustomAvatar", new ResoniteLink.Reference() { });
members.Add("_avatarHipsOffset", new ResoniteLink.Reference() { });
members.Add("_avatarLeftFootOffset", new ResoniteLink.Reference() { });
members.Add("_avatarRightFootOffset", new ResoniteLink.Reference() { });
members.Add("_avatarLeftKneeDefaultOffset", new ResoniteLink.Reference() { });
members.Add("_avatarRightKneeDefaultOffset", new ResoniteLink.Reference() { });
members.Add("_avatarHipHandle", new ResoniteLink.Reference() { });
members.Add("_avatarLeftFootHandle", new ResoniteLink.Reference() { });
members.Add("_avatarRightFootHandle", new ResoniteLink.Reference() { });
members.Add("_avatarLeftKneeHandle", new ResoniteLink.Reference() { });
members.Add("_avatarRightKneeHandle", new ResoniteLink.Reference() { });
members.Add("_avatarLeftKneeOffset", new ResoniteLink.Reference() { });
members.Add("_avatarRightKneeOffset", new ResoniteLink.Reference() { });
members.Add("_platformBodyMaterialSets", new ResoniteLink.SyncList()
{
    Elements = _platformBodyMaterialSets.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_ground", new ResoniteLink.Reference() { });
members.Add("_trackers", new ResoniteLink.SyncList()
{
    Elements = _trackers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("_visualizationRoot", new ResoniteLink.Reference() { });
members.Add("_bodyNodeMaterial", new ResoniteLink.Reference() { });
members.Add("_calibrationReferenceMaterial", new ResoniteLink.Reference() { });
members.Add("_leftHandOverrideMaterial", new ResoniteLink.Reference() { });
members.Add("_rightHandOverrideMaterial", new ResoniteLink.Reference() { });
members.Add("_leftHandOverrideFrontColor", new ResoniteLink.Reference() { });
members.Add("_leftHandOverrideBehindColor", new ResoniteLink.Reference() { });
members.Add("_rightHandOverrideFrontColor", new ResoniteLink.Reference() { });
members.Add("_rightHandOverrideBehindColor", new ResoniteLink.Reference() { });
members.Add("_patternTex", new ResoniteLink.Reference() { });
members.Add("_title", new ResoniteLink.Reference() { });
}

}
}
