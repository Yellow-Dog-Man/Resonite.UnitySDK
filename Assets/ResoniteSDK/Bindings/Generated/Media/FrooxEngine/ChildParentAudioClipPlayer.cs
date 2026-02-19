
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChildParentAudioClipPlayer
// Generated on: čtvrtek 19. února 2026 7:59:00
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ChildParentAudioClipPlayer")]
public partial class ChildParentAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase

{
    public global::FrooxEngine.ChildParentAudioClipPlayer.PointMode PlayPointMode;
public global::System.Int32 ChildLimit;
public global::System.String FilterTag;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> ParentedClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> UnparentedClips;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PlayPointMode", PlayPointMode.ToResoniteLinkField());
members.Add("ChildLimit", ChildLimit.ToResoniteLinkField());
members.Add("FilterTag", FilterTag.ToResoniteLinkField());
members.Add("ParentedClips", new ResoniteLink.SyncList()
{
    Elements = ParentedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("UnparentedClips", new ResoniteLink.SyncList()
{
    Elements = UnparentedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
