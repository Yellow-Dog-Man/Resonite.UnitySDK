
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleMesh
// Generated on: čtvrtek 26. února 2026 10:03:36
// Resonite version: 2026.2.25.455
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
members.Add("Vertex0", new ResoniteLink.SyncObject() { Members = Vertex0.CollectMembers(context) });
members.Add("Vertex1", new ResoniteLink.SyncObject() { Members = Vertex1.CollectMembers(context) });
members.Add("Vertex2", new ResoniteLink.SyncObject() { Members = Vertex2.CollectMembers(context) });
members.Add("AutoNormals", AutoNormals_Element.Data.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents_Element.Data.ToResoniteLinkField());
members.Add("DualSided", DualSided_Element.Data.ToResoniteLinkField());
}

}
}
