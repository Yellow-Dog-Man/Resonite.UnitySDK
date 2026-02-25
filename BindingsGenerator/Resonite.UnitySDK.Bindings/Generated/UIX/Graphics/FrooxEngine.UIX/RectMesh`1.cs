
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectMesh<>
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
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
