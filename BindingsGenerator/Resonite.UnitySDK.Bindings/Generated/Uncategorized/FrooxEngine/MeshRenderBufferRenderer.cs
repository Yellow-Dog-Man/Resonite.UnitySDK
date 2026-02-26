
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRenderBufferRenderer
// Generated on: čtvrtek 26. února 2026 15:09:13
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.PointRenderBuffer> Buffer { get => Buffer_Element.Data; set => Buffer_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.PointRenderBuffer>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.PointRenderBuffer>> Buffer_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();
public global::Renderite.Shared.MeshAlignment Alignment { get => Alignment_Element.Data; set => Alignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.MeshAlignment>, global::Renderite.Shared.MeshAlignment> Alignment_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Buffer", Buffer_Element.ToLinkReference(context));
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
members.Add("Alignment", Alignment_Element.ToLinkField(context));
}

}
}
