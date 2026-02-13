
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleTrailsModule
// Generated on: pátek 13. února 2026 5:52:22
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleTrailsModule")]
public partial class ParticleTrailsModule : global::FrooxEngine.PhotonDust.TrailRendererModule<global::System.Object>

{
    public global::System.Single TrailsRatio;
public global::PhotonDust.ParticleFollowerDistribution Distribution;
public global::System.Int32 MaxTrails;
public global::FrooxEngine.RootSpace SimulationSpace;
public global::System.Single MinVertexDistance;
public global::System.Boolean TrailDiesWithParticle;
public global::PhotonDust.TrailParticleInheritance ParticleColorInheritance;
public global::PhotonDust.TrailParticleInheritance ParticleSizeInheritance;
public global::PhotonDust.UniformSizeMode SizeInheritanceMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TrailsRatio", TrailsRatio.ToResoniteLinkField());
members.Add("Distribution", Distribution.ToResoniteLinkField());
members.Add("MaxTrails", MaxTrails.ToResoniteLinkField());
members.Add("SimulationSpace", new ResoniteLink.SyncObject() { Members = SimulationSpace.CollectMembers() });
members.Add("MinVertexDistance", MinVertexDistance.ToResoniteLinkField());
members.Add("TrailDiesWithParticle", TrailDiesWithParticle.ToResoniteLinkField());
members.Add("ParticleColorInheritance", ParticleColorInheritance.ToResoniteLinkField());
members.Add("ParticleSizeInheritance", ParticleSizeInheritance.ToResoniteLinkField());
members.Add("SizeInheritanceMode", SizeInheritanceMode.ToResoniteLinkField());
}

}
}
