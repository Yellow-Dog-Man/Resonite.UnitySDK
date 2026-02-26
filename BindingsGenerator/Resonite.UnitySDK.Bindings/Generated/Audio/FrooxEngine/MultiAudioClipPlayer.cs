
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiAudioClipPlayer
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiAudioClipPlayer")]
public partial class MultiAudioClipPlayer : global::FrooxEngine.AudioClipPlayerBase

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.MultiAudioClipPlayer.Track>, global::FrooxEngine.MultiAudioClipPlayer.Track> Tracks = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tracks", Tracks.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
