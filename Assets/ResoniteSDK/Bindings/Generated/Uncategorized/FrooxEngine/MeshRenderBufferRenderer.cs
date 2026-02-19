
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRenderBufferRenderer
// Generated on: čtvrtek 19. února 2026 8:00:29
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRenderBufferRenderer")]
public partial class MeshRenderBufferRenderer : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.PointRenderBuffer> Buffer;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;
public global::Renderite.Shared.MeshAlignment Alignment;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Buffer", Buffer.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Mesh", Mesh.ToResoniteReference(context));
members.Add("Alignment", Alignment.ToResoniteLinkField());
}

}
}
