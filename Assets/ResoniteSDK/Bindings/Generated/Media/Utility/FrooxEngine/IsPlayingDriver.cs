
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.IsPlayingDriver
// Generated on: čtvrtek 19. února 2026 7:59:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.IsPlayingDriver")]
public partial class IsPlayingDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback Playback;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> Targets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playback", Playback.ToResoniteReference(context));
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
