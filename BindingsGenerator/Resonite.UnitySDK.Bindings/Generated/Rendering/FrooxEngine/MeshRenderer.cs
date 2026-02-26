
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRenderer
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRenderer")]
public partial class MeshRenderer : global::FrooxEngine.RenderableComponent, global::FrooxEngine.IBounded, global::FrooxEngine.IHighlightable, global::FrooxEngine.IRenderable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> Materials = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.MaterialPropertyBlock>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.MaterialPropertyBlock>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock>>> MaterialPropertyBlocks = new();
public global::Renderite.Shared.ShadowCastMode ShadowCastMode { get => ShadowCastMode_Element.Data; set => ShadowCastMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowCastMode>, global::Renderite.Shared.ShadowCastMode> ShadowCastMode_Element = new();
public global::Renderite.Shared.MotionVectorMode MotionVectorMode { get => MotionVectorMode_Element.Data; set => MotionVectorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.MotionVectorMode>, global::Renderite.Shared.MotionVectorMode> MotionVectorMode_Element = new();
public global::System.Int32 SortingOrder { get => SortingOrder_Element.Data; set => SortingOrder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SortingOrder_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
members.Add("Materials", Materials.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("MaterialPropertyBlocks", MaterialPropertyBlocks.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("ShadowCastMode", ShadowCastMode_Element.ToLinkField(context));
members.Add("MotionVectorMode", MotionVectorMode_Element.ToLinkField(context));
members.Add("SortingOrder", SortingOrder_Element.ToLinkField(context));
}

}
}
