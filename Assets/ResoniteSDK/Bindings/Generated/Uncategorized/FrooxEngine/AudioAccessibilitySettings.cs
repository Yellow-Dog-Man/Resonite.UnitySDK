
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioAccessibilitySettings
// Generated on: úterý 24. února 2026 18:20:18
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Single WhisperVolume;
public global::System.Single VoiceMessageVolume;
public global::System.Boolean ForceVoiceAudioEffectsOff;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WhisperVolume", WhisperVolume.ToResoniteLinkField());
members.Add("VoiceMessageVolume", VoiceMessageVolume.ToResoniteLinkField());
members.Add("ForceVoiceAudioEffectsOff", ForceVoiceAudioEffectsOff.ToResoniteLinkField());
}

}
}
