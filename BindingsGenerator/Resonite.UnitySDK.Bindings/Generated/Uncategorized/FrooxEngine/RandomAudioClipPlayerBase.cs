
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomAudioClipPlayerBase")]
public abstract partial class RandomAudioClipPlayerBase : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ParentUnder;
public global::System.Nullable<global::System.Single> MinDistance;
public global::System.Nullable<global::System.Single> MaxDistance;
public global::System.Nullable<global::Awwdio.AudioRolloffCurve> RolloffMode;
public global::System.Boolean IgnoreAudioEffects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParentUnder", ParentUnder.ToResoniteReference(context));
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteLinkField());
}

}
}
