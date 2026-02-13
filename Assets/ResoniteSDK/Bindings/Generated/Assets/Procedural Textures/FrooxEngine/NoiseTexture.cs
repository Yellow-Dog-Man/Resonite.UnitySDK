
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoiseTexture
// Generated on: pátek 13. února 2026 5:51:09
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
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
