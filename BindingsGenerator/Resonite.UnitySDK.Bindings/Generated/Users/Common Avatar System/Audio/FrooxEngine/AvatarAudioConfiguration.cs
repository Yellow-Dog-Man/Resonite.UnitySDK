
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarAudioConfiguration
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarAudioConfiguration")]
public partial class AvatarAudioConfiguration : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.VoiceModeConfig Normal = new();
public global::FrooxEngine.VoiceModeConfig Shout = new();
public global::FrooxEngine.VoiceModeConfig Broadcast = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Normal", new ResoniteLink.SyncObject() { Members = Normal.CollectMembers(context) });
members.Add("Shout", new ResoniteLink.SyncObject() { Members = Shout.CollectMembers(context) });
members.Add("Broadcast", new ResoniteLink.SyncObject() { Members = Broadcast.CollectMembers(context) });
}

}
}
