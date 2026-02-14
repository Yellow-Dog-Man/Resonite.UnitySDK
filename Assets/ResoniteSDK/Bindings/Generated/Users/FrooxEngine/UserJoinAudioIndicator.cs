
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserJoinAudioIndicator
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("JoinedClips", new ResoniteLink.SyncList()
{
    Elements = JoinedClips.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("LeftClips", new ResoniteLink.SyncList()
{
    Elements = LeftClips.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Spatialize", Spatialize.ToResoniteLinkField());
members.Add("Volume", Volume.ToResoniteLinkField());
}

}
}
