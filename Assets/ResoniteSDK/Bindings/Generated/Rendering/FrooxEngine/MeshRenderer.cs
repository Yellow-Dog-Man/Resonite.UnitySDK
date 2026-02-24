
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRenderer
// Generated on: úterý 24. února 2026 18:17:42
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh.ToResoniteReference(context));
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("MaterialPropertyBlocks", new ResoniteLink.SyncList()
{
    Elements = MaterialPropertyBlocks.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("ShadowCastMode", ShadowCastMode.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode.ToResoniteLinkField());
members.Add("SortingOrder", SortingOrder.ToResoniteLinkField());
}

}
}
