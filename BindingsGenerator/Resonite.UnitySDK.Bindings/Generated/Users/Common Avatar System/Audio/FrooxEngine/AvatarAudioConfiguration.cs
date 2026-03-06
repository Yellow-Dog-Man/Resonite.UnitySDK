
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarAudioConfiguration
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
members.Add("Normal", Normal.ToLinkSyncObject(context));
members.Add("Shout", Shout.ToLinkSyncObject(context));
members.Add("Broadcast", Broadcast.ToLinkSyncObject(context));
}

}
}
