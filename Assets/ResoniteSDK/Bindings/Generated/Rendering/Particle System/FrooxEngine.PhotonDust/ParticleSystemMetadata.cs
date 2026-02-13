
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystemMetadata
// Generated on: pátek 13. února 2026 5:52:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleSystemMetadata")]
public partial class ParticleSystemMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.ParticleSystem System;
public global::System.Int32 ParticleCount;
public global::System.Single ParticlesFPS;
public global::System.Single LastSimulationTime;
public global::System.Single LastSubmissionTime;
public global::System.Int32 RenderDataReallocationCount;
public global::System.Int32 TrailCount;
public global::System.Int32 TrailCapacity;
public global::System.Int32 TrailPointCapacity;
public global::System.Int32 TrailsDataReallocationCount;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("System", new ResoniteLink.Reference() { });
members.Add("ParticleCount", ParticleCount.ToResoniteLinkField());
members.Add("ParticlesFPS", ParticlesFPS.ToResoniteLinkField());
members.Add("LastSimulationTime", LastSimulationTime.ToResoniteLinkField());
members.Add("LastSubmissionTime", LastSubmissionTime.ToResoniteLinkField());
members.Add("RenderDataReallocationCount", RenderDataReallocationCount.ToResoniteLinkField());
members.Add("TrailCount", TrailCount.ToResoniteLinkField());
members.Add("TrailCapacity", TrailCapacity.ToResoniteLinkField());
members.Add("TrailPointCapacity", TrailPointCapacity.ToResoniteLinkField());
members.Add("TrailsDataReallocationCount", TrailsDataReallocationCount.ToResoniteLinkField());
}

}
}
