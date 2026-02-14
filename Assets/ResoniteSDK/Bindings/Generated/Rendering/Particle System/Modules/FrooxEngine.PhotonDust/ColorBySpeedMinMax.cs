
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMax
// Generated on: sobota 14. února 2026 8:58:35
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMax")]
public partial class ColorBySpeedMinMax : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single MinSpeed;
public global::System.Single MaxSpeed;
public UnityEngine.ColorX MinColor;
public UnityEngine.ColorX MaxColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("MinColor", MinColor.ToResoniteLinkField());
members.Add("MaxColor", MaxColor.ToResoniteLinkField());
}

}
}
