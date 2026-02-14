
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioSettingSync
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioSettingSync")]
public partial class AudioSettingSync : global::FrooxEngine.Component

{
    public global::System.Int32 DefaultAudioInputDeviceIndex;
public global::System.Int32 DefaultAudioOutputDeviceIndex;
public global::System.Single MasterVolume;
public global::System.Single WhisperVoiceVolume;
public global::System.Single NoiseGateThreshold;
public global::System.Single NoiseGateAttack;
public global::System.Single NoiseGateHold;
public global::System.Single NoiseGateRelease;
public global::System.Single NormalizationThreshold;
public global::System.Boolean VoiceNormalization;
public global::System.Boolean NoiseSupression;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultAudioInputDeviceIndex", DefaultAudioInputDeviceIndex.ToResoniteLinkField());
members.Add("DefaultAudioOutputDeviceIndex", DefaultAudioOutputDeviceIndex.ToResoniteLinkField());
members.Add("MasterVolume", MasterVolume.ToResoniteLinkField());
members.Add("WhisperVoiceVolume", WhisperVoiceVolume.ToResoniteLinkField());
members.Add("NoiseGateThreshold", NoiseGateThreshold.ToResoniteLinkField());
members.Add("NoiseGateAttack", NoiseGateAttack.ToResoniteLinkField());
members.Add("NoiseGateHold", NoiseGateHold.ToResoniteLinkField());
members.Add("NoiseGateRelease", NoiseGateRelease.ToResoniteLinkField());
members.Add("NormalizationThreshold", NormalizationThreshold.ToResoniteLinkField());
members.Add("VoiceNormalization", VoiceNormalization.ToResoniteLinkField());
members.Add("NoiseSupression", NoiseSupression.ToResoniteLinkField());
}

}
}
