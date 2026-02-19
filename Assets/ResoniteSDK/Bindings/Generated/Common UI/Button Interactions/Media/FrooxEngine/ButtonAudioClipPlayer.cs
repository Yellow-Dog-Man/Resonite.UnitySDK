
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonAudioClipPlayer
// Generated on: čtvrtek 19. února 2026 7:58:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonAudioClipPlayer")]
public partial class ButtonAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> PressedClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> ReleasedClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverEnterClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverLeaveClips;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PressedClips", new ResoniteLink.SyncList()
{
    Elements = PressedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("ReleasedClips", new ResoniteLink.SyncList()
{
    Elements = ReleasedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("HoverEnterClips", new ResoniteLink.SyncList()
{
    Elements = HoverEnterClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("HoverLeaveClips", new ResoniteLink.SyncList()
{
    Elements = HoverLeaveClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
