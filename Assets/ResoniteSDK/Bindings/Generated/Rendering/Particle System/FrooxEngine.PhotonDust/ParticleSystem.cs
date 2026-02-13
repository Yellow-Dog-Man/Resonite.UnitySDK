
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem
// Generated on: pátek 13. února 2026 23:23:04
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem")]
public partial class ParticleSystem : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IRenderable

{
    public global::System.Int32 MaxParticleCount;
public global::FrooxEngine.PhotonDust.ParticleStyle Style;
public global::FrooxEngine.RootSpace SimulationSpace;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MaxParticleCount", MaxParticleCount.ToResoniteLinkField());
members.Add("Style", new ResoniteLink.Reference() { });
members.Add("SimulationSpace", new ResoniteLink.SyncObject() { Members = SimulationSpace.CollectMembers() });
}

}
}
