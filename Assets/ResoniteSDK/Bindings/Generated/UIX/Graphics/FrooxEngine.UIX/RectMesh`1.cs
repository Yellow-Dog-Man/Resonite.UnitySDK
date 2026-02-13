
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectMesh<>
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
	where M : global::FrooxEngine.RectMeshSource

{
    public M Mesh;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Materials;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.SyncObject() { Members = Mesh.CollectMembers() });
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
