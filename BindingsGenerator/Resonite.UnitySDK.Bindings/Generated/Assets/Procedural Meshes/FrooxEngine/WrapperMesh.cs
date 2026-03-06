
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WrapperMesh
// Generated on: pátek 6. března 2026 14:18:05
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WrapperMesh")]
public partial class WrapperMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
}

}
}
