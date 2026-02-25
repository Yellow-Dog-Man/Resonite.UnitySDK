
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueNoiseClip
// Generated on: středa 25. února 2026 16:13:04
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
