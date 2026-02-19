
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshParticleRenderer
// Generated on: čtvrtek 19. února 2026 8:00:21
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Mesh", Mesh.ToResoniteReference(context));
members.Add("Alignment", Alignment.ToResoniteLinkField());
}

}
}
