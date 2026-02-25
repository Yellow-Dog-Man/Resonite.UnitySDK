
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleMesh
// Generated on: středa 25. února 2026 16:13:05
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
    public global::FrooxEngine.ProceduralMeshVertex Vertex0;
public global::FrooxEngine.ProceduralMeshVertex Vertex1;
public global::FrooxEngine.ProceduralMeshVertex Vertex2;
public global::System.Boolean AutoNormals;
public global::System.Boolean AutoTangents;
public global::System.Boolean DualSided;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertex0", new ResoniteLink.SyncObject() { Members = Vertex0.CollectMembers(context) });
members.Add("Vertex1", new ResoniteLink.SyncObject() { Members = Vertex1.CollectMembers(context) });
members.Add("Vertex2", new ResoniteLink.SyncObject() { Members = Vertex2.CollectMembers(context) });
members.Add("AutoNormals", AutoNormals.ToResoniteLinkField());
members.Add("AutoTangents", AutoTangents.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
}

}
}
