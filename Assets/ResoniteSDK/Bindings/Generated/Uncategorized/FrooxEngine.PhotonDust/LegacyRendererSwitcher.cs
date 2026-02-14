
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher")]
public partial class LegacyRendererSwitcher : global::FrooxEngine.Component

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh;
public global::FrooxEngine.PhotonDust.BillboardParticleRenderer BillboardRenderer;
public global::FrooxEngine.PhotonDust.MeshParticleRenderer MeshRenderer;
public global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleRenderer> RendererDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParticleMesh", ParticleMesh.ToResoniteReference(context));
members.Add("BillboardRenderer", BillboardRenderer.ToResoniteReference(context));
members.Add("MeshRenderer", MeshRenderer.ToResoniteReference(context));
members.Add("RendererDrive", RendererDrive.ToResoniteReference(context));
}

}
}
