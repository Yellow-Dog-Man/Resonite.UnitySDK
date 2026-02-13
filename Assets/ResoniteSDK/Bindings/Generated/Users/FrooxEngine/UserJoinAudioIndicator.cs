
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserJoinAudioIndicator
// Generated on: pátek 13. února 2026 5:52:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserJoinAudioIndicator")]
public partial class UserJoinAudioIndicator : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> JoinedClips;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> LeftClips;
public global::System.Boolean Spatialize;
public global::System.Single Volume;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("JoinedClips", new ResoniteLink.SyncList()
{
    Elements = JoinedClips.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("LeftClips", new ResoniteLink.SyncList()
{
    Elements = LeftClips.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Spatialize", Spatialize.ToResoniteLinkField());
members.Add("Volume", Volume.ToResoniteLinkField());
}

}
}
