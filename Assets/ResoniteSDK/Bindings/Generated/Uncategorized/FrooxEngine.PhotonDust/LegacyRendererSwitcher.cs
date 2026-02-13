
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher
// Generated on: pátek 13. února 2026 23:23:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRendererSwitcher")]
public partial class LegacyRendererSwitcher : global::FrooxEngine.Component

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh;
public global::FrooxEngine.PhotonDust.BillboardParticleRenderer BillboardRenderer;
public global::FrooxEngine.PhotonDust.MeshParticleRenderer MeshRenderer;
public global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleRenderer> RendererDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ParticleMesh", new ResoniteLink.Reference() { });
members.Add("BillboardRenderer", new ResoniteLink.Reference() { });
members.Add("MeshRenderer", new ResoniteLink.Reference() { });
members.Add("RendererDrive", new ResoniteLink.Reference() { });
}

}
}
