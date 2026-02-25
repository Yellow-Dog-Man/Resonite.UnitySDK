
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LerpingMultiClipPlayer
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LerpingMultiClipPlayer")]
public partial class LerpingMultiClipPlayer : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::System.Single Lerp;
public System.Collections.Generic.List<global::FrooxEngine.LerpingMultiClipPlayer.Track> Tracks;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("Tracks", new ResoniteLink.SyncList()
{
    Elements = Tracks.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
