
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackStateDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackStateDriver")]
public partial class PlaybackStateDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Source;
public global::FrooxEngine.IField<global::System.Boolean> IsPlaying;
public global::FrooxEngine.IField<global::System.Boolean> IsNotPlaying;
public global::FrooxEngine.IField<global::System.Boolean> IsPaused;
public global::FrooxEngine.IField<global::System.Boolean> IsStopped;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("IsPlaying", IsPlaying.ToResoniteReference(context));
members.Add("IsNotPlaying", IsNotPlaying.ToResoniteReference(context));
members.Add("IsPaused", IsPaused.ToResoniteReference(context));
members.Add("IsStopped", IsStopped.ToResoniteReference(context));
}

}
}
