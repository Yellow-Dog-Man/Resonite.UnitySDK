
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectMesh<>
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectMesh<>")]
public partial class RectMesh<M> : global::FrooxEngine.UIX.Graphic
	where M : global::FrooxEngine.RectMeshSource, new()

{
    public M Mesh = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> Materials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh.ToLinkSyncObject(context));
members.Add("Materials", Materials.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
