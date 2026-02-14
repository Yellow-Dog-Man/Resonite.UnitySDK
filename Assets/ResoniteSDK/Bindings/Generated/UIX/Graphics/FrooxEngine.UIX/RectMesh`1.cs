
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectMesh<>
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", new ResoniteLink.SyncObject() { Members = Mesh.CollectMembers(context) });
members.Add("Materials", new ResoniteLink.SyncList()
{
    Elements = Materials.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
