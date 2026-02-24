
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarAudioConfiguration
// Generated on: úterý 24. února 2026 18:20:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarAudioConfiguration")]
public partial class AvatarAudioConfiguration : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.VoiceModeConfig Normal;
public global::FrooxEngine.VoiceModeConfig Shout;
public global::FrooxEngine.VoiceModeConfig Broadcast;

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
