
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonAudioClipPlayer
// Generated on: čtvrtek 26. února 2026 12:26:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonAudioClipPlayer")]
public partial class ButtonAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> PressedClips = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> ReleasedClips = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverEnterClips = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData>, global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverLeaveClips = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PressedClips", PressedClips.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ReleasedClips", ReleasedClips.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("HoverEnterClips", HoverEnterClips.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("HoverLeaveClips", HoverLeaveClips.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
