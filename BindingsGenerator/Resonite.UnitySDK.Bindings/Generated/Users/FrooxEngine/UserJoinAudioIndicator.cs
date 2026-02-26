
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserJoinAudioIndicator
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserJoinAudioIndicator")]
public partial class UserJoinAudioIndicator : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>>> JoinedClips = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>>> LeftClips = new();
public global::System.Boolean Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Spatialize_Element = new();
public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Volume_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("JoinedClips", JoinedClips.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("LeftClips", LeftClips.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Spatialize", Spatialize_Element.ToLinkField(context));
members.Add("Volume", Volume_Element.ToLinkField(context));
}

}
}
