
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleTrailsModule
// Generated on: čtvrtek 26. února 2026 15:09:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleTrailsModule")]
public partial class ParticleTrailsModule : global::FrooxEngine.PhotonDust.TrailRendererModule<global::System.Object>

{
    public global::System.Single TrailsRatio { get => TrailsRatio_Element.Data; set => TrailsRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TrailsRatio_Element = new();
public global::PhotonDust.ParticleFollowerDistribution Distribution { get => Distribution_Element.Data; set => Distribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ParticleFollowerDistribution>, global::PhotonDust.ParticleFollowerDistribution> Distribution_Element = new();
public global::System.Int32 MaxTrails { get => MaxTrails_Element.Data; set => MaxTrails_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxTrails_Element = new();
public global::FrooxEngine.RootSpace SimulationSpace = new();
public global::System.Single MinVertexDistance { get => MinVertexDistance_Element.Data; set => MinVertexDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinVertexDistance_Element = new();
public global::System.Boolean TrailDiesWithParticle { get => TrailDiesWithParticle_Element.Data; set => TrailDiesWithParticle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TrailDiesWithParticle_Element = new();
public global::PhotonDust.TrailParticleInheritance ParticleColorInheritance { get => ParticleColorInheritance_Element.Data; set => ParticleColorInheritance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.TrailParticleInheritance>, global::PhotonDust.TrailParticleInheritance> ParticleColorInheritance_Element = new();
public global::PhotonDust.TrailParticleInheritance ParticleSizeInheritance { get => ParticleSizeInheritance_Element.Data; set => ParticleSizeInheritance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.TrailParticleInheritance>, global::PhotonDust.TrailParticleInheritance> ParticleSizeInheritance_Element = new();
public global::PhotonDust.UniformSizeMode SizeInheritanceMode { get => SizeInheritanceMode_Element.Data; set => SizeInheritanceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.UniformSizeMode>, global::PhotonDust.UniformSizeMode> SizeInheritanceMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TrailsRatio", TrailsRatio_Element.ToLinkField(context));
members.Add("Distribution", Distribution_Element.ToLinkField(context));
members.Add("MaxTrails", MaxTrails_Element.ToLinkField(context));
members.Add("SimulationSpace", SimulationSpace.ToLinkSyncObject(context));
members.Add("MinVertexDistance", MinVertexDistance_Element.ToLinkField(context));
members.Add("TrailDiesWithParticle", TrailDiesWithParticle_Element.ToLinkField(context));
members.Add("ParticleColorInheritance", ParticleColorInheritance_Element.ToLinkField(context));
members.Add("ParticleSizeInheritance", ParticleSizeInheritance_Element.ToLinkField(context));
members.Add("SizeInheritanceMode", SizeInheritanceMode_Element.ToLinkField(context));
}

}
}
