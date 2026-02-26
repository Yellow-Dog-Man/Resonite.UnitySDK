
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioAccessibilitySettings
// Generated on: čtvrtek 26. února 2026 10:04:43
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioAccessibilitySettings")]
public partial class AudioAccessibilitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioAccessibilitySettings>

{
    public global::System.Single WhisperVolume { get => WhisperVolume_Element.Data; set => WhisperVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WhisperVolume_Element = new();
public global::System.Single VoiceMessageVolume { get => VoiceMessageVolume_Element.Data; set => VoiceMessageVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VoiceMessageVolume_Element = new();
public global::System.Boolean ForceVoiceAudioEffectsOff { get => ForceVoiceAudioEffectsOff_Element.Data; set => ForceVoiceAudioEffectsOff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceVoiceAudioEffectsOff_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WhisperVolume", WhisperVolume_Element.Data.ToResoniteLinkField());
members.Add("VoiceMessageVolume", VoiceMessageVolume_Element.Data.ToResoniteLinkField());
members.Add("ForceVoiceAudioEffectsOff", ForceVoiceAudioEffectsOff_Element.Data.ToResoniteLinkField());
}

}
}
