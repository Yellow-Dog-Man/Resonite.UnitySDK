
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase")]
public abstract partial class RandomAudioClipPlayerBase : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ParentUnder;
public global::System.Nullable<global::System.Single> MinDistance;
public global::System.Nullable<global::System.Single> MaxDistance;
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode;
public global::System.Boolean IgnoreAudioEffects;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ParentUnder", new ResoniteLink.Reference() { });
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteLinkField());
}

}
}
