
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioSettingSync
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Int32 DefaultAudioInputDeviceIndex { get => DefaultAudioInputDeviceIndex_Element.Data; set => DefaultAudioInputDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DefaultAudioInputDeviceIndex_Element = new();
public global::System.Int32 DefaultAudioOutputDeviceIndex { get => DefaultAudioOutputDeviceIndex_Element.Data; set => DefaultAudioOutputDeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DefaultAudioOutputDeviceIndex_Element = new();
public global::System.Single MasterVolume { get => MasterVolume_Element.Data; set => MasterVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MasterVolume_Element = new();
public global::System.Single WhisperVoiceVolume { get => WhisperVoiceVolume_Element.Data; set => WhisperVoiceVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WhisperVoiceVolume_Element = new();
public global::System.Single NoiseGateThreshold { get => NoiseGateThreshold_Element.Data; set => NoiseGateThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateThreshold_Element = new();
public global::System.Single NoiseGateAttack { get => NoiseGateAttack_Element.Data; set => NoiseGateAttack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateAttack_Element = new();
public global::System.Single NoiseGateHold { get => NoiseGateHold_Element.Data; set => NoiseGateHold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateHold_Element = new();
public global::System.Single NoiseGateRelease { get => NoiseGateRelease_Element.Data; set => NoiseGateRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseGateRelease_Element = new();
public global::System.Single NormalizationThreshold { get => NormalizationThreshold_Element.Data; set => NormalizationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizationThreshold_Element = new();
public global::System.Boolean VoiceNormalization { get => VoiceNormalization_Element.Data; set => VoiceNormalization_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VoiceNormalization_Element = new();
public global::System.Boolean NoiseSupression { get => NoiseSupression_Element.Data; set => NoiseSupression_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NoiseSupression_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultAudioInputDeviceIndex", DefaultAudioInputDeviceIndex_Element.ToLinkField(context));
members.Add("DefaultAudioOutputDeviceIndex", DefaultAudioOutputDeviceIndex_Element.ToLinkField(context));
members.Add("MasterVolume", MasterVolume_Element.ToLinkField(context));
members.Add("WhisperVoiceVolume", WhisperVoiceVolume_Element.ToLinkField(context));
members.Add("NoiseGateThreshold", NoiseGateThreshold_Element.ToLinkField(context));
members.Add("NoiseGateAttack", NoiseGateAttack_Element.ToLinkField(context));
members.Add("NoiseGateHold", NoiseGateHold_Element.ToLinkField(context));
members.Add("NoiseGateRelease", NoiseGateRelease_Element.ToLinkField(context));
members.Add("NormalizationThreshold", NormalizationThreshold_Element.ToLinkField(context));
members.Add("VoiceNormalization", VoiceNormalization_Element.ToLinkField(context));
members.Add("NoiseSupression", NoiseSupression_Element.ToLinkField(context));
}

}
}
