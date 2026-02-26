
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChildParentAudioClipPlayer
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ChildParentAudioClipPlayer")]
public partial class ChildParentAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase

{
    public global::FrooxEngine.ChildParentAudioClipPlayer.PointMode PlayPointMode { get => PlayPointMode_Element.Data; set => PlayPointMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ChildParentAudioClipPlayer.PointMode>, global::FrooxEngine.ChildParentAudioClipPlayer.PointMode> PlayPointMode_Element = new();
public global::System.Int32 ChildLimit { get => ChildLimit_Element.Data; set => ChildLimit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ChildLimit_Element = new();
public global::System.String FilterTag { get => FilterTag_Element.Data; set => FilterTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> FilterTag_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> ParentedClips = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> UnparentedClips = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PlayPointMode", PlayPointMode_Element.Data.ToResoniteLinkField());
members.Add("ChildLimit", ChildLimit_Element.Data.ToResoniteLinkField());
members.Add("FilterTag", FilterTag_Element.Data.ToResoniteLinkField());
members.Add("ParentedClips", new ResoniteLink.SyncList()
{
    Elements = ParentedClips.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("UnparentedClips", new ResoniteLink.SyncList()
{
    Elements = UnparentedClips.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
