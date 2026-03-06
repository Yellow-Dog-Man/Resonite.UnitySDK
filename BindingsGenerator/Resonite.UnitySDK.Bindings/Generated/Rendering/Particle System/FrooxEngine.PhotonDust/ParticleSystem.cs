
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleSystem
// Generated on: pátek 6. března 2026 14:19:04
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleStyle>, global::FrooxEngine.PhotonDust.ParticleStyle> Style_Element = new();
public global::FrooxEngine.RootSpace SimulationSpace = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxParticleCount", MaxParticleCount_Element.ToLinkField(context));
members.Add("Style", Style_Element.ToLinkReference(context));
members.Add("SimulationSpace", SimulationSpace.ToLinkSyncObject(context));
}

}
}
