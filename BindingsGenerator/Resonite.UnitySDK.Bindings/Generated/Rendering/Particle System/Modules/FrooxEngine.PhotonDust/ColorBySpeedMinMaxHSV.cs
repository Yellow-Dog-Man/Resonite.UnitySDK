
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMaxHSV
// Generated on: středa 25. února 2026 16:14:18
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
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
