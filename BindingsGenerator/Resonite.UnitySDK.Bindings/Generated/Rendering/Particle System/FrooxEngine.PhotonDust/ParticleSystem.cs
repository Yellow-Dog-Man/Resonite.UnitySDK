
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem")]
public partial class ParticleSystem : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IRenderable

{
    public global::System.Int32 MaxParticleCount;
public global::FrooxEngine.PhotonDust.ParticleStyle Style;
public global::FrooxEngine.RootSpace SimulationSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxParticleCount", MaxParticleCount.ToResoniteLinkField());
members.Add("Style", Style.ToResoniteReference(context));
members.Add("SimulationSpace", new ResoniteLink.SyncObject() { Members = SimulationSpace.CollectMembers(context) });
}

}
}
