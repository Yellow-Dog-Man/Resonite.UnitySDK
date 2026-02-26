
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.MeshEmitter
// Generated on: čtvrtek 26. února 2026 12:28:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.MeshEmitter")]
public partial class MeshEmitter : global::FrooxEngine.PhotonDust.MeshEmitterBase<global::System.Object>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
}

}
}
