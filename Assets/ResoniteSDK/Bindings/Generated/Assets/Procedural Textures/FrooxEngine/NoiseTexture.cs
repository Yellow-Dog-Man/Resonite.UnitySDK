
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoiseTexture
// Generated on: čtvrtek 19. února 2026 7:58:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoiseTexture")]
public partial class NoiseTexture : global::FrooxEngine.ProceduralTexture

{
    public global::System.Int32 Seed;
public global::System.Boolean Monochrome;
public UnityEngine.ColorX MonochromeMax;
public UnityEngine.ColorX MonochromeMin;
public global::System.Single Bias;
public global::System.Single Gain;
public global::System.Boolean Clamp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Seed", Seed.ToResoniteLinkField());
members.Add("Monochrome", Monochrome.ToResoniteLinkField());
members.Add("MonochromeMax", MonochromeMax.ToResoniteLinkField());
members.Add("MonochromeMin", MonochromeMin.ToResoniteLinkField());
members.Add("Bias", Bias.ToResoniteLinkField());
members.Add("Gain", Gain.ToResoniteLinkField());
members.Add("Clamp", Clamp.ToResoniteLinkField());
}

}
}
