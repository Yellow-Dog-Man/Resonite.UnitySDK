
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleSpray
// Generated on: středa 25. února 2026 16:14:25
// Resonite version: 2026.2.25.455
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
