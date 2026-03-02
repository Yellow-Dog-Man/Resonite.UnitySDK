
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiAudioClipPlayer
// Generated on: pondělí 2. března 2026 17:52:27
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
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
