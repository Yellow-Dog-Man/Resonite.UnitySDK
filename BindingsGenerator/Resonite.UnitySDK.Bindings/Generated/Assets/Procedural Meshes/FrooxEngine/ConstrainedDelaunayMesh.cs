
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh")]
public partial class ConstrainedDelaunayMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ProceduralMeshVertex>, global::FrooxEngine.ProceduralMeshVertex> Vertices = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ConstrainedDelaunayMesh.Hole>, global::FrooxEngine.ConstrainedDelaunayMesh.Hole> Holes = new();
public global::System.Boolean AutoTriangulationPlane { get => AutoTriangulationPlane_Element.Data; set => AutoTriangulationPlane_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoTriangulationPlane_Element = new();
public UnityEngine.Vector3 TriangulationCenter { get => TriangulationCenter_Element.Data; set => TriangulationCenter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TriangulationCenter_Element = new();
public UnityEngine.Vector3 TriangulationPlaneNormal { get => TriangulationPlaneNormal_Element.Data; set => TriangulationPlaneNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TriangulationPlaneNormal_Element = new();
public global::System.Boolean AutoNormals { get => AutoNormals_Element.Data; set => AutoNormals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoNormals_Element = new();
public global::System.Boolean AutoTangents { get => AutoTangents_Element.Data; set => AutoTangents_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoTangents_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertices", new ResoniteLink.SyncList()
{
    Elements = Vertices.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Holes", new ResoniteLink.SyncList()
{
    Elements = Holes.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("AutoTriangulationPlane", AutoTriangulationPlane_Element.Data.ToResoniteLinkField());
members.Add("TriangulationCenter", TriangulationCenter_Element.Data.ToResoniteLinkField());
members.Add("TriangulationPlaneNormal", TriangulationPlaneNormal_Element.Data.ToResoniteLinkField());
members.Add("AutoNormals", AutoNormals_Element.Data.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents_Element.Data.ToResoniteLinkField());
}

}
}
