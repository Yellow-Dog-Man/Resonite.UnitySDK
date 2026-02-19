
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueNoiseClip
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueNoiseClip")]
public partial class ValueNoiseClip : global::FrooxEngine.ProceduralAudioClip

{
    public global::System.Single Duration;
public global::System.Int32 Seed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Duration", Duration.ToResoniteLinkField());
members.Add("Seed", Seed.ToResoniteLinkField());
}

}
}
