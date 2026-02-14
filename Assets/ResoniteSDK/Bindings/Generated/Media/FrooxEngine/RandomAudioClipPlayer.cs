
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomAudioClipPlayer
// Generated on: sobota 14. února 2026 8:57:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomAudioClipPlayer")]
public partial class RandomAudioClipPlayer : global::FrooxEngine.RandomAudioClipPlayerBase

{
    public System.Collections.Generic.List<global::FrooxEngine.RandomAudioClipPlayerBase.ClipData> Clips;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clips", new ResoniteLink.SyncList()
{
    Elements = Clips.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
