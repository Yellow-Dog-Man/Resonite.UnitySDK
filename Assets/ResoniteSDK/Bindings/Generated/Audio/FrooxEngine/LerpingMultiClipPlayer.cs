
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LerpingMultiClipPlayer
// Generated on: pátek 13. února 2026 5:51:10
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LerpingMultiClipPlayer")]
public partial class LerpingMultiClipPlayer : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Single Lerp;
public System.Collections.Generic.List<global::FrooxEngine.LerpingMultiClipPlayer.Track> Tracks;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("Tracks", new ResoniteLink.SyncList()
{
    Elements = Tracks.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
