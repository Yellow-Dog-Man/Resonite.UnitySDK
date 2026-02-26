
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem
// Generated on: čtvrtek 26. února 2026 10:04:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem")]
public partial class ParticleSystem : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IRenderable

{
    public global::System.Int32 MaxParticleCount { get => MaxParticleCount_Element.Data; set => MaxParticleCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxParticleCount_Element = new();
public global::FrooxEngine.PhotonDust.ParticleStyle Style { get => Style_Element.Data; set => Style_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleStyle>, global::FrooxEngine.PhotonDust.ParticleStyle> Style_Element = new();
public global::FrooxEngine.RootSpace SimulationSpace = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxParticleCount", MaxParticleCount_Element.Data.ToResoniteLinkField());
members.Add("Style", Style_Element.Data.ToResoniteReference(context));
members.Add("SimulationSpace", new ResoniteLink.SyncObject() { Members = SimulationSpace.CollectMembers(context) });
}

}
}
