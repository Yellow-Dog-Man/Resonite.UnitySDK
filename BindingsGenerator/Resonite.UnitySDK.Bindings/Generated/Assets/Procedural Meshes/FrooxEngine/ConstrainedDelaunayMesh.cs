
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh
// Generated on: středa 25. února 2026 16:13:04
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
    public System.Collections.Generic.List<global::FrooxEngine.ProceduralMeshVertex> Vertices;
public System.Collections.Generic.List<global::FrooxEngine.ConstrainedDelaunayMesh.Hole> Holes;
public global::System.Boolean AutoTriangulationPlane;
public UnityEngine.Vector3 TriangulationCenter;
public UnityEngine.Vector3 TriangulationPlaneNormal;
public global::System.Boolean AutoNormals;
public global::System.Boolean AutoTangents;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertices", new ResoniteLink.SyncList()
{
    Elements = Vertices.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Holes", new ResoniteLink.SyncList()
{
    Elements = Holes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("AutoTriangulationPlane", AutoTriangulationPlane.ToResoniteLinkField());
members.Add("TriangulationCenter", TriangulationCenter.ToResoniteLinkField());
members.Add("TriangulationPlaneNormal", TriangulationPlaneNormal.ToResoniteLinkField());
members.Add("AutoNormals", AutoNormals.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents.ToResoniteLinkField());
}

}
}
