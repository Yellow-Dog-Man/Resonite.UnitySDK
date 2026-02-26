
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioClipPlayerBase
// Generated on: čtvrtek 26. února 2026 10:03:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioClipPlayerBase")]
public abstract partial class AudioClipPlayerBase : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource, global::FrooxEngine.IPlayable

{
    public PlaybackState playback { get => playback_Element.Data; set => playback_Element.Data = value; }
public Field<global::FrooxEngine.SyncPlayback, PlaybackState> playback_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("playback", playback_Element.Data.ToResoniteLink());
}

}
}
