
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAudioOutputManager
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAudioOutputManager")]
public partial class AvatarAudioOutputManager : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.AudioOutput AudioOutput { get => AudioOutput_Element.Data; set => AudioOutput_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioOutput>, global::FrooxEngine.AudioOutput> AudioOutput_Element = new();
public global::System.Boolean IsViewVoice { get => IsViewVoice_Element.Data; set => IsViewVoice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsViewVoice_Element = new();
public global::FrooxEngine.VoiceModeConfig WhisperConfig = new();
public global::FrooxEngine.VoiceModeConfig NormalConfig = new();
public global::FrooxEngine.VoiceModeConfig ShoutConfig = new();
public global::FrooxEngine.VoiceModeConfig BroadcastConfig = new();
public global::System.Single __legacyWhisperVolume { get => __legacyWhisperVolume_Element.Data; set => __legacyWhisperVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyWhisperVolume_Element = new();
public global::System.Single __legacyNormalVolume { get => __legacyNormalVolume_Element.Data; set => __legacyNormalVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyNormalVolume_Element = new();
public global::System.Single __legacyShoutVolume { get => __legacyShoutVolume_Element.Data; set => __legacyShoutVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyShoutVolume_Element = new();
public global::System.Single __legacyBroadcastVolume { get => __legacyBroadcastVolume_Element.Data; set => __legacyBroadcastVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyBroadcastVolume_Element = new();
public global::System.Single __legacyNormalDopplerLevel { get => __legacyNormalDopplerLevel_Element.Data; set => __legacyNormalDopplerLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyNormalDopplerLevel_Element = new();
public global::System.Single __legacyShoutDopplerLevel { get => __legacyShoutDopplerLevel_Element.Data; set => __legacyShoutDopplerLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyShoutDopplerLevel_Element = new();
public global::System.Single __legacyWhisperRange { get => __legacyWhisperRange_Element.Data; set => __legacyWhisperRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> __legacyWhisperRange_Element = new();
public global::FrooxEngine.User _activeUser { get => _activeUser_Element.Data; set => _activeUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _activeUser_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _enabled { get => _enabled_Element.Data; set => _enabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _enabled_Element = new();
public global::FrooxEngine.IField<global::System.Single> _volume { get => _volume_Element.Data; set => _volume_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _volume_Element = new();
public global::FrooxEngine.IField<global::System.Single> _doppler { get => _doppler_Element.Data; set => _doppler_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _doppler_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _spatialize { get => _spatialize_Element.Data; set => _spatialize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _spatialize_Element = new();
public global::FrooxEngine.IField<global::System.Single> _spatialBlend { get => _spatialBlend_Element.Data; set => _spatialBlend_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _spatialBlend_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _ignoreAudioEffects { get => _ignoreAudioEffects_Element.Data; set => _ignoreAudioEffects_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _ignoreAudioEffects_Element = new();
public global::FrooxEngine.IField<global::System.Single> _minDistance { get => _minDistance_Element.Data; set => _minDistance_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _minDistance_Element = new();
public global::FrooxEngine.IField<global::System.Single> _maxDistance { get => _maxDistance_Element.Data; set => _maxDistance_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _maxDistance_Element = new();
public global::FrooxEngine.IField<global::Awwdio.AudioRolloffCurve> _rollOffMode { get => _rollOffMode_Element.Data; set => _rollOffMode_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::Awwdio.AudioRolloffCurve>, global::FrooxEngine.IField<global::Awwdio.AudioRolloffCurve>> _rollOffMode_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.AudioDistanceSpace> _distanceSpace { get => _distanceSpace_Element.Data; set => _distanceSpace_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::FrooxEngine.AudioDistanceSpace>, global::FrooxEngine.IField<global::FrooxEngine.AudioDistanceSpace>> _distanceSpace_Element = new();
public global::FrooxEngine.IField<global::System.Single> _minScale { get => _minScale_Element.Data; set => _minScale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _minScale_Element = new();
public global::FrooxEngine.IField<global::System.Single> _maxScale { get => _maxScale_Element.Data; set => _maxScale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _maxScale_Element = new();
public global::System.Single _scaleCompensation { get => _scaleCompensation_Element.Data; set => _scaleCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _scaleCompensation_Element = new();
public global::FrooxEngine.AvatarAudioConfiguration _audioConfiguration { get => _audioConfiguration_Element.Data; set => _audioConfiguration_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AvatarAudioConfiguration>, global::FrooxEngine.AvatarAudioConfiguration> _audioConfiguration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioOutput", AudioOutput_Element.ToLinkReference(context));
members.Add("IsViewVoice", IsViewVoice_Element.ToLinkField(context));
members.Add("WhisperConfig", WhisperConfig.ToLinkSyncObject(context));
members.Add("NormalConfig", NormalConfig.ToLinkSyncObject(context));
members.Add("ShoutConfig", ShoutConfig.ToLinkSyncObject(context));
members.Add("BroadcastConfig", BroadcastConfig.ToLinkSyncObject(context));
members.Add("__legacyWhisperVolume", __legacyWhisperVolume_Element.ToLinkField(context));
members.Add("__legacyNormalVolume", __legacyNormalVolume_Element.ToLinkField(context));
members.Add("__legacyShoutVolume", __legacyShoutVolume_Element.ToLinkField(context));
members.Add("__legacyBroadcastVolume", __legacyBroadcastVolume_Element.ToLinkField(context));
members.Add("__legacyNormalDopplerLevel", __legacyNormalDopplerLevel_Element.ToLinkField(context));
members.Add("__legacyShoutDopplerLevel", __legacyShoutDopplerLevel_Element.ToLinkField(context));
members.Add("__legacyWhisperRange", __legacyWhisperRange_Element.ToLinkField(context));
members.Add("_activeUser", _activeUser_Element.ToLinkReference(context));
members.Add("_enabled", _enabled_Element.ToLinkReference(context));
members.Add("_volume", _volume_Element.ToLinkReference(context));
members.Add("_doppler", _doppler_Element.ToLinkReference(context));
members.Add("_spatialize", _spatialize_Element.ToLinkReference(context));
members.Add("_spatialBlend", _spatialBlend_Element.ToLinkReference(context));
members.Add("_ignoreAudioEffects", _ignoreAudioEffects_Element.ToLinkReference(context));
members.Add("_minDistance", _minDistance_Element.ToLinkReference(context));
members.Add("_maxDistance", _maxDistance_Element.ToLinkReference(context));
members.Add("_rollOffMode", _rollOffMode_Element.ToLinkReference(context));
members.Add("_distanceSpace", _distanceSpace_Element.ToLinkReference(context));
members.Add("_minScale", _minScale_Element.ToLinkReference(context));
members.Add("_maxScale", _maxScale_Element.ToLinkReference(context));
members.Add("_scaleCompensation", _scaleCompensation_Element.ToLinkField(context));
members.Add("_audioConfiguration", _audioConfiguration_Element.ToLinkReference(context));
}

}
}
