
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioVolumeSettings
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioVolumeSettings")]
public partial class AudioVolumeSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioVolumeSettings>

{
    public global::System.Single MasterVolume;
public global::System.Single SoundEffectVolume;
public global::System.Single MultimediaVolume;
public global::System.Single VoiceVolume;
public global::System.Single UserInterfaceVolume;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MasterVolume", MasterVolume.ToResoniteLinkField());
members.Add("SoundEffectVolume", SoundEffectVolume.ToResoniteLinkField());
members.Add("MultimediaVolume", MultimediaVolume.ToResoniteLinkField());
members.Add("VoiceVolume", VoiceVolume.ToResoniteLinkField());
members.Add("UserInterfaceVolume", UserInterfaceVolume.ToResoniteLinkField());
}

}
}
