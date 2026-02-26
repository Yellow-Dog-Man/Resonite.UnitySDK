
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioVolumeSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single MasterVolume { get => MasterVolume_Element.Data; set => MasterVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MasterVolume_Element = new();
public global::System.Single SoundEffectVolume { get => SoundEffectVolume_Element.Data; set => SoundEffectVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SoundEffectVolume_Element = new();
public global::System.Single MultimediaVolume { get => MultimediaVolume_Element.Data; set => MultimediaVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MultimediaVolume_Element = new();
public global::System.Single VoiceVolume { get => VoiceVolume_Element.Data; set => VoiceVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VoiceVolume_Element = new();
public global::System.Single UserInterfaceVolume { get => UserInterfaceVolume_Element.Data; set => UserInterfaceVolume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserInterfaceVolume_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MasterVolume", MasterVolume_Element.ToLinkField(context));
members.Add("SoundEffectVolume", SoundEffectVolume_Element.ToLinkField(context));
members.Add("MultimediaVolume", MultimediaVolume_Element.ToLinkField(context));
members.Add("VoiceVolume", VoiceVolume_Element.ToLinkField(context));
members.Add("UserInterfaceVolume", UserInterfaceVolume_Element.ToLinkField(context));
}

}
}
