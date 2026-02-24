
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleDiagnosticMesh
// Generated on: úterý 24. února 2026 18:17:41
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleDiagnosticMesh")]
public partial class TriangleDiagnosticMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 TriangleIndex;
public UnityEngine.Color Vertex0Color;
public UnityEngine.Color Vertex1Color;
public UnityEngine.Color Vertex2Color;
public global::Renderite.Shared.ColorProfile VertexColorProfile;
public global::System.Single Displace;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TriangleIndex", TriangleIndex.ToResoniteLinkField());
members.Add("Vertex0Color", Vertex0Color.ToResoniteLinkField());
members.Add("Vertex1Color", Vertex1Color.ToResoniteLinkField());
members.Add("Vertex2Color", Vertex2Color.ToResoniteLinkField());
members.Add("VertexColorProfile", VertexColorProfile.ToResoniteLinkField());
members.Add("Displace", Displace.ToResoniteLinkField());
members.Add("Mesh", Mesh.ToResoniteReference(context));
}

}
}
