
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarAudioConfiguration
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarAudioConfiguration")]
public partial class AvatarAudioConfiguration : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.VoiceModeConfig Normal;
public global::FrooxEngine.VoiceModeConfig Shout;
public global::FrooxEngine.VoiceModeConfig Broadcast;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Normal", new ResoniteLink.SyncObject() { Members = Normal.CollectMembers() });
members.Add("Shout", new ResoniteLink.SyncObject() { Members = Shout.CollectMembers() });
members.Add("Broadcast", new ResoniteLink.SyncObject() { Members = Broadcast.CollectMembers() });
}

}
}
