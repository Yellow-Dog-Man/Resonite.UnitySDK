
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_RangeInitializer
// Generated on: pátek 13. února 2026 5:52:22
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::System.Single HueMin;
public global::System.Single HueMax;
public global::System.Single SaturationMin;
public global::System.Single SaturationMax;
public global::System.Single ValueMin;
public global::System.Single ValueMax;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HueMin", HueMin.ToResoniteLinkField());
members.Add("HueMax", HueMax.ToResoniteLinkField());
members.Add("SaturationMin", SaturationMin.ToResoniteLinkField());
members.Add("SaturationMax", SaturationMax.ToResoniteLinkField());
members.Add("ValueMin", ValueMin.ToResoniteLinkField());
members.Add("ValueMax", ValueMax.ToResoniteLinkField());
}

}
}
