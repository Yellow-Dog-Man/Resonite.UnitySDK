
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StandaloneRectMesh<>
// Generated on: sobota 14. února 2026 8:57:00
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StandaloneRectMesh<>")]
public partial class StandaloneRectMesh<M> : global::FrooxEngine.ProceduralMesh
	where M : global::FrooxEngine.RectMeshSource

{
    public UnityEngine.Rect Rect;
public M Mesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("Mesh", new ResoniteLink.SyncObject() { Members = Mesh.CollectMembers(context) });
}

}
}
