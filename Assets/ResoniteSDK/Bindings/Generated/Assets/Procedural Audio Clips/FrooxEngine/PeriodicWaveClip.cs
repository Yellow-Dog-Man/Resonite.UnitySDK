
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PeriodicWaveClip
// Generated on: čtvrtek 19. února 2026 7:58:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PeriodicWaveClip")]
public abstract partial class PeriodicWaveClip : global::FrooxEngine.ProceduralAudioClip

{
    public global::System.Single Frequency;
public global::System.Single Amplitude;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Frequency", Frequency.ToResoniteLinkField());
members.Add("Amplitude", Amplitude.ToResoniteLinkField());
}

}
}
