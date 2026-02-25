
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAudioOutputManager
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.AudioOutput AudioOutput;
public global::System.Boolean IsViewVoice;
public global::FrooxEngine.VoiceModeConfig WhisperConfig;
public global::FrooxEngine.VoiceModeConfig NormalConfig;
public global::FrooxEngine.VoiceModeConfig ShoutConfig;
public global::FrooxEngine.VoiceModeConfig BroadcastConfig;
public global::System.Single __legacyWhisperVolume;
public global::System.Single __legacyNormalVolume;
public global::System.Single __legacyShoutVolume;
public global::System.Single __legacyBroadcastVolume;
public global::System.Single __legacyNormalDopplerLevel;
public global::System.Single __legacyShoutDopplerLevel;
public global::System.Single __legacyWhisperRange;
public global::FrooxEngine.User _activeUser;
public global::FrooxEngine.IField<global::System.Boolean> _enabled;
public global::FrooxEngine.IField<global::System.Single> _volume;
public global::FrooxEngine.IField<global::System.Single> _doppler;
public global::FrooxEngine.IField<global::System.Boolean> _spatialize;
public global::FrooxEngine.IField<global::System.Single> _spatialBlend;
public global::FrooxEngine.IField<global::System.Boolean> _ignoreAudioEffects;
public global::FrooxEngine.IField<global::System.Single> _minDistance;
public global::FrooxEngine.IField<global::System.Single> _maxDistance;
public global::FrooxEngine.IField<global::Awwdio.AudioRolloffCurve> _rollOffMode;
public global::FrooxEngine.IField<global::FrooxEngine.AudioDistanceSpace> _distanceSpace;
public global::FrooxEngine.IField<global::System.Single> _minScale;
public global::FrooxEngine.IField<global::System.Single> _maxScale;
public global::System.Single _scaleCompensation;
public global::FrooxEngine.AvatarAudioConfiguration _audioConfiguration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioOutput", AudioOutput.ToResoniteReference(context));
members.Add("IsViewVoice", IsViewVoice.ToResoniteLinkField());
members.Add("WhisperConfig", new ResoniteLink.SyncObject() { Members = WhisperConfig.CollectMembers(context) });
members.Add("NormalConfig", new ResoniteLink.SyncObject() { Members = NormalConfig.CollectMembers(context) });
members.Add("ShoutConfig", new ResoniteLink.SyncObject() { Members = ShoutConfig.CollectMembers(context) });
members.Add("BroadcastConfig", new ResoniteLink.SyncObject() { Members = BroadcastConfig.CollectMembers(context) });
members.Add("__legacyWhisperVolume", __legacyWhisperVolume.ToResoniteLinkField());
members.Add("__legacyNormalVolume", __legacyNormalVolume.ToResoniteLinkField());
members.Add("__legacyShoutVolume", __legacyShoutVolume.ToResoniteLinkField());
members.Add("__legacyBroadcastVolume", __legacyBroadcastVolume.ToResoniteLinkField());
members.Add("__legacyNormalDopplerLevel", __legacyNormalDopplerLevel.ToResoniteLinkField());
members.Add("__legacyShoutDopplerLevel", __legacyShoutDopplerLevel.ToResoniteLinkField());
members.Add("__legacyWhisperRange", __legacyWhisperRange.ToResoniteLinkField());
members.Add("_activeUser", _activeUser.ToResoniteReference(context));
members.Add("_enabled", _enabled.ToResoniteReference(context));
members.Add("_volume", _volume.ToResoniteReference(context));
members.Add("_doppler", _doppler.ToResoniteReference(context));
members.Add("_spatialize", _spatialize.ToResoniteReference(context));
members.Add("_spatialBlend", _spatialBlend.ToResoniteReference(context));
members.Add("_ignoreAudioEffects", _ignoreAudioEffects.ToResoniteReference(context));
members.Add("_minDistance", _minDistance.ToResoniteReference(context));
members.Add("_maxDistance", _maxDistance.ToResoniteReference(context));
members.Add("_rollOffMode", _rollOffMode.ToResoniteReference(context));
members.Add("_distanceSpace", _distanceSpace.ToResoniteReference(context));
members.Add("_minScale", _minScale.ToResoniteReference(context));
members.Add("_maxScale", _maxScale.ToResoniteReference(context));
members.Add("_scaleCompensation", _scaleCompensation.ToResoniteLinkField());
members.Add("_audioConfiguration", _audioConfiguration.ToResoniteReference(context));
}

}
}
