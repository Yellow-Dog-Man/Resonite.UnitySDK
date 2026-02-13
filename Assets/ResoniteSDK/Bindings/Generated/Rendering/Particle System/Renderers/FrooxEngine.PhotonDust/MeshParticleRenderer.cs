
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshParticleRenderer
// Generated on: pátek 13. února 2026 23:23:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.MeshParticleRenderer")]
public partial class MeshParticleRenderer : global::FrooxEngine.PhotonDust.ParticleRenderer<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;
public global::Renderite.Shared.MeshAlignment Alignment;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Mesh", new ResoniteLink.Reference() { });
members.Add("Alignment", Alignment.ToResoniteLinkField());
}

}
}
