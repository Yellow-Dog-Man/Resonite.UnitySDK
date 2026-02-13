
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRenderer
// Generated on: pátek 13. února 2026 5:51:09
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Materials;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.MaterialPropertyBlock>> MaterialPropertyBlocks;
public global::Renderite.Shared.ShadowCastMode ShadowCastMode;
public global::Renderite.Shared.MotionVectorMode MotionVectorMode;
public global::System.Int32 SortingOrder;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.Reference() { });
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("MaterialPropertyBlocks", new ResoniteLink.SyncList()
{
    Elements = MaterialPropertyBlocks.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("ShadowCastMode", ShadowCastMode.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode.ToResoniteLinkField());
members.Add("SortingOrder", SortingOrder.ToResoniteLinkField());
}

}
}
