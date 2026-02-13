
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMaxHSV
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMaxHSV")]
public partial class ColorBySpeedMinMaxHSV : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single MinSpeed;
public global::System.Single MaxSpeed;
public global::System.Single MinHue;
public global::System.Single MaxHue;
public global::System.Single MinSaturation;
public global::System.Single MaxSaturation;
public global::System.Single MinValue;
public global::System.Single MaxValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("MinHue", MinHue.ToResoniteLinkField());
members.Add("MaxHue", MaxHue.ToResoniteLinkField());
members.Add("MinSaturation", MinSaturation.ToResoniteLinkField());
members.Add("MaxSaturation", MaxSaturation.ToResoniteLinkField());
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
}

}
}
