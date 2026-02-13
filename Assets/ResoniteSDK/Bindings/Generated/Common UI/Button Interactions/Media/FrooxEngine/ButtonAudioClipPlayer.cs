
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonAudioClipPlayer
// Generated on: pátek 13. února 2026 23:21:38
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonAudioClipPlayer")]
public partial class ButtonAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> PressedClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> ReleasedClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverEnterClips;
public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> HoverLeaveClips;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PressedClips", new ResoniteLink.SyncList()
{
    Elements = PressedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("ReleasedClips", new ResoniteLink.SyncList()
{
    Elements = ReleasedClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("HoverEnterClips", new ResoniteLink.SyncList()
{
    Elements = HoverEnterClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("HoverLeaveClips", new ResoniteLink.SyncList()
{
    Elements = HoverLeaveClips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
