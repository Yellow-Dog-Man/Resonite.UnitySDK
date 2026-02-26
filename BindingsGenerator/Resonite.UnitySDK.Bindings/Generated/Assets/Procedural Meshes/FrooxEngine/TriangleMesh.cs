
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleMesh
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleMesh")]
public partial class TriangleMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.ProceduralMeshVertex Vertex0 = new();
public global::FrooxEngine.ProceduralMeshVertex Vertex1 = new();
public global::FrooxEngine.ProceduralMeshVertex Vertex2 = new();
public global::System.Boolean AutoNormals { get => AutoNormals_Element.Data; set => AutoNormals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoNormals_Element = new();
public global::System.Boolean AutoTangents { get => AutoTangents_Element.Data; set => AutoTangents_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoTangents_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertex0", Vertex0.ToLinkSyncObject(context));
members.Add("Vertex1", Vertex1.ToLinkSyncObject(context));
members.Add("Vertex2", Vertex2.ToLinkSyncObject(context));
members.Add("AutoNormals", AutoNormals_Element.ToLinkField(context));
members.Add("AutoTangents", AutoTangents_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
}

}
}
