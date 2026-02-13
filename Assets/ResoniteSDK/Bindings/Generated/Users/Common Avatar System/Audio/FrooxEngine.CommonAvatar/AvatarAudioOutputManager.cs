
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAudioOutputManager
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AudioOutput", new ResoniteLink.Reference() { });
members.Add("IsViewVoice", IsViewVoice.ToResoniteLinkField());
members.Add("WhisperConfig", new ResoniteLink.SyncObject() { Members = WhisperConfig.CollectMembers() });
members.Add("NormalConfig", new ResoniteLink.SyncObject() { Members = NormalConfig.CollectMembers() });
members.Add("ShoutConfig", new ResoniteLink.SyncObject() { Members = ShoutConfig.CollectMembers() });
members.Add("BroadcastConfig", new ResoniteLink.SyncObject() { Members = BroadcastConfig.CollectMembers() });
members.Add("__legacyWhisperVolume", __legacyWhisperVolume.ToResoniteLinkField());
members.Add("__legacyNormalVolume", __legacyNormalVolume.ToResoniteLinkField());
members.Add("__legacyShoutVolume", __legacyShoutVolume.ToResoniteLinkField());
members.Add("__legacyBroadcastVolume", __legacyBroadcastVolume.ToResoniteLinkField());
members.Add("__legacyNormalDopplerLevel", __legacyNormalDopplerLevel.ToResoniteLinkField());
members.Add("__legacyShoutDopplerLevel", __legacyShoutDopplerLevel.ToResoniteLinkField());
members.Add("__legacyWhisperRange", __legacyWhisperRange.ToResoniteLinkField());
members.Add("_activeUser", new ResoniteLink.Reference() { });
members.Add("_enabled", new ResoniteLink.Reference() { });
members.Add("_volume", new ResoniteLink.Reference() { });
members.Add("_doppler", new ResoniteLink.Reference() { });
members.Add("_spatialize", new ResoniteLink.Reference() { });
members.Add("_spatialBlend", new ResoniteLink.Reference() { });
members.Add("_ignoreAudioEffects", new ResoniteLink.Reference() { });
members.Add("_minDistance", new ResoniteLink.Reference() { });
members.Add("_maxDistance", new ResoniteLink.Reference() { });
members.Add("_rollOffMode", new ResoniteLink.Reference() { });
members.Add("_distanceSpace", new ResoniteLink.Reference() { });
members.Add("_minScale", new ResoniteLink.Reference() { });
members.Add("_maxScale", new ResoniteLink.Reference() { });
members.Add("_scaleCompensation", _scaleCompensation.ToResoniteLinkField());
members.Add("_audioConfiguration", new ResoniteLink.Reference() { });
}

}
}
