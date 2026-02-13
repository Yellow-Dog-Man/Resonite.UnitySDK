
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleSpray
// Generated on: pátek 13. února 2026 23:23:07
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Rate", Rate.ToResoniteLinkField());
members.Add("RateExp", RateExp.ToResoniteLinkField());
members.Add("MinSpeed", MinSpeed.ToResoniteLinkField());
members.Add("MaxSpeed", MaxSpeed.ToResoniteLinkField());
members.Add("partStyle", new ResoniteLink.Reference() { });
members.Add("partSpeed", new ResoniteLink.Reference() { });
members.Add("partEmitter", new ResoniteLink.Reference() { });
}

}
}
