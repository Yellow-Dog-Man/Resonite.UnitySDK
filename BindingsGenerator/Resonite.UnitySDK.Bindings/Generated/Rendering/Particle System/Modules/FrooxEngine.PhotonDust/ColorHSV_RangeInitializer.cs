
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_RangeInitializer
// Generated on: čtvrtek 26. února 2026 10:04:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_RangeInitializer")]
public partial class ColorHSV_RangeInitializer : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single HueMin { get => HueMin_Element.Data; set => HueMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HueMin_Element = new();
public global::System.Single HueMax { get => HueMax_Element.Data; set => HueMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HueMax_Element = new();
public global::System.Single SaturationMin { get => SaturationMin_Element.Data; set => SaturationMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SaturationMin_Element = new();
public global::System.Single SaturationMax { get => SaturationMax_Element.Data; set => SaturationMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SaturationMax_Element = new();
public global::System.Single ValueMin { get => ValueMin_Element.Data; set => ValueMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ValueMin_Element = new();
public global::System.Single ValueMax { get => ValueMax_Element.Data; set => ValueMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ValueMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HueMin", HueMin_Element.Data.ToResoniteLinkField());
members.Add("HueMax", HueMax_Element.Data.ToResoniteLinkField());
members.Add("SaturationMin", SaturationMin_Element.Data.ToResoniteLinkField());
members.Add("SaturationMax", SaturationMax_Element.Data.ToResoniteLinkField());
members.Add("ValueMin", ValueMin_Element.Data.ToResoniteLinkField());
members.Add("ValueMax", ValueMax_Element.Data.ToResoniteLinkField());
}

}
}
