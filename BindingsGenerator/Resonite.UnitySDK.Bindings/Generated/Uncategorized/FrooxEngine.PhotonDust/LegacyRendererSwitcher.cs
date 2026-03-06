
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher
// Generated on: pátek 6. března 2026 14:19:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher")]
public partial class LegacyRendererSwitcher : global::FrooxEngine.Component

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh { get => ParticleMesh_Element.Data; set => ParticleMesh_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>>, global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>> ParticleMesh_Element = new();
public global::FrooxEngine.PhotonDust.BillboardParticleRenderer BillboardRenderer { get => BillboardRenderer_Element.Data; set => BillboardRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.BillboardParticleRenderer>, global::FrooxEngine.PhotonDust.BillboardParticleRenderer> BillboardRenderer_Element = new();
public global::FrooxEngine.PhotonDust.MeshParticleRenderer MeshRenderer { get => MeshRenderer_Element.Data; set => MeshRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.MeshParticleRenderer>, global::FrooxEngine.PhotonDust.MeshParticleRenderer> MeshRenderer_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleRenderer> RendererDrive { get => RendererDrive_Element.Data; set => RendererDrive_Element.Data = value; }
public Reference<global::FrooxEngine.RefDrive<global::FrooxEngine.PhotonDust.IParticleRenderer>, global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleRenderer>> RendererDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParticleMesh", ParticleMesh_Element.ToLinkReference(context));
members.Add("BillboardRenderer", BillboardRenderer_Element.ToLinkReference(context));
members.Add("MeshRenderer", MeshRenderer_Element.ToLinkReference(context));
members.Add("RendererDrive", RendererDrive_Element.ToLinkReference(context));
}

}
}
