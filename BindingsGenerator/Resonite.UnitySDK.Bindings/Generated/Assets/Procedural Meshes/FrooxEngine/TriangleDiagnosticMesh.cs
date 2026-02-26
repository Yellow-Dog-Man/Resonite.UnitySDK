
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TriangleDiagnosticMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TriangleDiagnosticMesh")]
public partial class TriangleDiagnosticMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Int32 TriangleIndex { get => TriangleIndex_Element.Data; set => TriangleIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TriangleIndex_Element = new();
public UnityEngine.Color Vertex0Color { get => Vertex0Color_Element.Data; set => Vertex0Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> Vertex0Color_Element = new();
public UnityEngine.Color Vertex1Color { get => Vertex1Color_Element.Data; set => Vertex1Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> Vertex1Color_Element = new();
public UnityEngine.Color Vertex2Color { get => Vertex2Color_Element.Data; set => Vertex2Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Color>, UnityEngine.Color> Vertex2Color_Element = new();
public global::Renderite.Shared.ColorProfile VertexColorProfile { get => VertexColorProfile_Element.Data; set => VertexColorProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> VertexColorProfile_Element = new();
public global::System.Single Displace { get => Displace_Element.Data; set => Displace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Displace_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TriangleIndex", TriangleIndex_Element.Data.ToResoniteLinkField());
members.Add("Vertex0Color", Vertex0Color_Element.Data.ToResoniteLinkField());
members.Add("Vertex1Color", Vertex1Color_Element.Data.ToResoniteLinkField());
members.Add("Vertex2Color", Vertex2Color_Element.Data.ToResoniteLinkField());
members.Add("VertexColorProfile", VertexColorProfile_Element.Data.ToResoniteLinkField());
members.Add("Displace", Displace_Element.Data.ToResoniteLinkField());
members.Add("Mesh", Mesh_Element.Data.ToResoniteReference(context));
}

}
}
