
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConstrainedDelaunayMesh
// Generated on: pátek 13. února 2026 5:51:08
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Vertices", new ResoniteLink.SyncList()
{
    Elements = Vertices.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("Holes", new ResoniteLink.SyncList()
{
    Elements = Holes.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("AutoTriangulationPlane", AutoTriangulationPlane.ToResoniteLinkField());
members.Add("TriangulationCenter", TriangulationCenter.ToResoniteLinkField());
members.Add("TriangulationPlaneNormal", TriangulationPlaneNormal.ToResoniteLinkField());
members.Add("AutoNormals", AutoNormals.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents.ToResoniteLinkField());
}

}
}
