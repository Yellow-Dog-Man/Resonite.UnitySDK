
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshParticleRenderer
// Generated on: středa 25. února 2026 16:14:19
// Resonite version: 2026.2.25.455
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
