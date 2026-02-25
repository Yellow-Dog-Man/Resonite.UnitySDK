
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleEmitter
// Generated on: středa 25. února 2026 16:14:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleEmitter")]
public abstract partial class ParticleEmitter : global::FrooxEngine.Component, global::FrooxEngine.PhotonDust.IParticleSystemSubsystem

{
    public global::FrooxEngine.PhotonDust.ParticleSystem System;
public global::System.Single Rate;
public global::System.Single BurstOnActivatedMin;
public global::System.Single BurstOnActivatedMax;
public global::System.Boolean BurstOnStart;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("System", System.ToResoniteReference(context));
members.Add("Rate", Rate.ToResoniteLinkField());
members.Add("BurstOnActivatedMin", BurstOnActivatedMin.ToResoniteLinkField());
members.Add("BurstOnActivatedMax", BurstOnActivatedMax.ToResoniteLinkField());
members.Add("BurstOnStart", BurstOnStart.ToResoniteLinkField());
}

}
}
