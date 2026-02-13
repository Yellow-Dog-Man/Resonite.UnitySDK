
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioAccessibilitySettings
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioAccessibilitySettings")]
public partial class AudioAccessibilitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioAccessibilitySettings>

{
    public global::System.Single WhisperVolume;
public global::System.Single VoiceMessageVolume;
public global::System.Boolean ForceVoiceAudioEffectsOff;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("WhisperVolume", WhisperVolume.ToResoniteLinkField());
members.Add("VoiceMessageVolume", VoiceMessageVolume.ToResoniteLinkField());
members.Add("ForceVoiceAudioEffectsOff", ForceVoiceAudioEffectsOff.ToResoniteLinkField());
}

}
}
