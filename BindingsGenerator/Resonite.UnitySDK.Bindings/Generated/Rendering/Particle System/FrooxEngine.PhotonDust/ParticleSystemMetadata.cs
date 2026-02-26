
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystemMetadata
// Generated on: čtvrtek 26. února 2026 12:28:03
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleSystemMetadata")]
public partial class ParticleSystemMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.ParticleSystem System { get => System_Element.Data; set => System_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleSystem>, global::FrooxEngine.PhotonDust.ParticleSystem> System_Element = new();
public global::System.Int32 ParticleCount { get => ParticleCount_Element.Data; set => ParticleCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> ParticleCount_Element = new();
public global::System.Single ParticlesFPS { get => ParticlesFPS_Element.Data; set => ParticlesFPS_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ParticlesFPS_Element = new();
public global::System.Single LastSimulationTime { get => LastSimulationTime_Element.Data; set => LastSimulationTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LastSimulationTime_Element = new();
public global::System.Single LastSubmissionTime { get => LastSubmissionTime_Element.Data; set => LastSubmissionTime_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LastSubmissionTime_Element = new();
public global::System.Int32 RenderDataReallocationCount { get => RenderDataReallocationCount_Element.Data; set => RenderDataReallocationCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> RenderDataReallocationCount_Element = new();
public global::System.Int32 TrailCount { get => TrailCount_Element.Data; set => TrailCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TrailCount_Element = new();
public global::System.Int32 TrailCapacity { get => TrailCapacity_Element.Data; set => TrailCapacity_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TrailCapacity_Element = new();
public global::System.Int32 TrailPointCapacity { get => TrailPointCapacity_Element.Data; set => TrailPointCapacity_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TrailPointCapacity_Element = new();
public global::System.Int32 TrailsDataReallocationCount { get => TrailsDataReallocationCount_Element.Data; set => TrailsDataReallocationCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TrailsDataReallocationCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("System", System_Element.ToLinkReference(context));
members.Add("ParticleCount", ParticleCount_Element.ToLinkField(context));
members.Add("ParticlesFPS", ParticlesFPS_Element.ToLinkField(context));
members.Add("LastSimulationTime", LastSimulationTime_Element.ToLinkField(context));
members.Add("LastSubmissionTime", LastSubmissionTime_Element.ToLinkField(context));
members.Add("RenderDataReallocationCount", RenderDataReallocationCount_Element.ToLinkField(context));
members.Add("TrailCount", TrailCount_Element.ToLinkField(context));
members.Add("TrailCapacity", TrailCapacity_Element.ToLinkField(context));
members.Add("TrailPointCapacity", TrailPointCapacity_Element.ToLinkField(context));
members.Add("TrailsDataReallocationCount", TrailsDataReallocationCount_Element.ToLinkField(context));
}

}
}
