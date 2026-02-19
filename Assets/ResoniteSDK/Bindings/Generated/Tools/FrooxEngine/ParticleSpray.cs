
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleSpray
// Generated on: čtvrtek 19. února 2026 8:00:22
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParticleSpray")]
public partial class ParticleSpray : global::FrooxEngine.Tool

{
    public global::System.Single Rate;
public global::System.Single RateExp;
public global::System.Single MinSpeed;
public global::System.Single MaxSpeed;
public global::FrooxEngine.PhotonDust.ParticleStyle partStyle;
public global::FrooxEngine.PhotonDust.SpeedRangeInitializer partSpeed;
public global::FrooxEngine.PhotonDust.ParticleEmitter partEmitter;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rate", Rate.ToResoniteLinkField());
members.Add("RateExp", RateExp.ToResoniteLinkField());
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("partStyle", partStyle.ToResoniteReference(context));
members.Add("partSpeed", partSpeed.ToResoniteReference(context));
members.Add("partEmitter", partEmitter.ToResoniteReference(context));
}

}
}
