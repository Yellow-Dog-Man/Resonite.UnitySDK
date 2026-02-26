
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceInfo
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarVoiceInfo")]
public partial class AvatarVoiceInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.IWorldAudioDataSource AudioSource { get => AudioSource_Element.Data; set => AudioSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>, global::FrooxEngine.IWorldAudioDataSource> AudioSource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioSource", AudioSource_Element.ToLinkReference(context));
}

}
}
