
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleMesh
// Generated on: pátek 13. února 2026 23:21:36
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleMesh")]
public partial class TriangleMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.ProceduralMeshVertex Vertex0;
public global::FrooxEngine.ProceduralMeshVertex Vertex1;
public global::FrooxEngine.ProceduralMeshVertex Vertex2;
public global::System.Boolean AutoNormals;
public global::System.Boolean AutoTangents;
public global::System.Boolean DualSided;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Vertex0", new ResoniteLink.SyncObject() { Members = Vertex0.CollectMembers() });
members.Add("Vertex1", new ResoniteLink.SyncObject() { Members = Vertex1.CollectMembers() });
members.Add("Vertex2", new ResoniteLink.SyncObject() { Members = Vertex2.CollectMembers() });
members.Add("AutoNormals", AutoNormals.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
}

}
}
