
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioZitaReverb+LegacyRangeMapper
// Generated on: čtvrtek 19. února 2026 8:00:29
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
    public partial class AudioZitaReverb
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioZitaReverb+LegacyRangeMapper")]
public partial class LegacyRangeMapper : global::FrooxEngine.Component

{
    public global::System.Single MinDistance;
public global::System.Single MaxDistance;
public global::FrooxEngine.IField<global::System.Single> Radius;
public global::FrooxEngine.IField<global::System.Single> BlendDistance;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteReference(context));
members.Add("BlendDistance", BlendDistance.ToResoniteReference(context));
}

}
            }
}
