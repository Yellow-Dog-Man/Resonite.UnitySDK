
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StandaloneRectMesh<>
// Generated on: čtvrtek 26. února 2026 15:07:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StandaloneRectMesh<>")]
public partial class StandaloneRectMesh<M> : global::FrooxEngine.ProceduralMesh
	where M : global::FrooxEngine.RectMeshSource, new()

{
    public UnityEngine.Rect Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Rect_Element = new();
public M Mesh = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect_Element.ToLinkField(context));
members.Add("Mesh", Mesh.ToLinkSyncObject(context));
}

}
}
