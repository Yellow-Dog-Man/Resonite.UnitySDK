
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleEmitter
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.PhotonDust.ParticleSystem System { get => System_Element.Data; set => System_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleSystem>, global::FrooxEngine.PhotonDust.ParticleSystem> System_Element = new();
public global::System.Single Rate { get => Rate_Element.Data; set => Rate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Rate_Element = new();
public global::System.Single BurstOnActivatedMin { get => BurstOnActivatedMin_Element.Data; set => BurstOnActivatedMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BurstOnActivatedMin_Element = new();
public global::System.Single BurstOnActivatedMax { get => BurstOnActivatedMax_Element.Data; set => BurstOnActivatedMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BurstOnActivatedMax_Element = new();
public global::System.Boolean BurstOnStart { get => BurstOnStart_Element.Data; set => BurstOnStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BurstOnStart_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("System", System_Element.ToLinkReference(context));
members.Add("Rate", Rate_Element.ToLinkField(context));
members.Add("BurstOnActivatedMin", BurstOnActivatedMin_Element.ToLinkField(context));
members.Add("BurstOnActivatedMax", BurstOnActivatedMax_Element.ToLinkField(context));
members.Add("BurstOnStart", BurstOnStart_Element.ToLinkField(context));
}

}
}
