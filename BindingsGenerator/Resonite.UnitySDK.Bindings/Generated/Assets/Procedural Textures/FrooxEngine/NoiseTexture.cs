
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoiseTexture
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoiseTexture")]
public partial class NoiseTexture : global::FrooxEngine.ProceduralTexture

{
    public global::System.Int32 Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Seed_Element = new();
public global::System.Boolean Monochrome { get => Monochrome_Element.Data; set => Monochrome_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Monochrome_Element = new();
public UnityEngine.ColorX MonochromeMax { get => MonochromeMax_Element.Data; set => MonochromeMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MonochromeMax_Element = new();
public UnityEngine.ColorX MonochromeMin { get => MonochromeMin_Element.Data; set => MonochromeMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MonochromeMin_Element = new();
public global::System.Single Bias { get => Bias_Element.Data; set => Bias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Bias_Element = new();
public global::System.Single Gain { get => Gain_Element.Data; set => Gain_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Gain_Element = new();
public global::System.Boolean Clamp { get => Clamp_Element.Data; set => Clamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Clamp_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Seed", Seed_Element.ToLinkField(context));
members.Add("Monochrome", Monochrome_Element.ToLinkField(context));
members.Add("MonochromeMax", MonochromeMax_Element.ToLinkField(context));
members.Add("MonochromeMin", MonochromeMin_Element.ToLinkField(context));
members.Add("Bias", Bias_Element.ToLinkField(context));
members.Add("Gain", Gain_Element.ToLinkField(context));
members.Add("Clamp", Clamp_Element.ToLinkField(context));
}

}
}
