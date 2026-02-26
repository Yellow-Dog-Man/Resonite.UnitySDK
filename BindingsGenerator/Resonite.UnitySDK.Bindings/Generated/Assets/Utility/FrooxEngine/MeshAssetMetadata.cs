
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshAssetMetadata
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshAssetMetadata")]
public partial class MeshAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh { get => Mesh_Element.Data; set => Mesh_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh>> Mesh_Element = new();
public global::System.Int32 VertexCount { get => VertexCount_Element.Data; set => VertexCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> VertexCount_Element = new();
public global::System.Int32 TriangleCount { get => TriangleCount_Element.Data; set => TriangleCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TriangleCount_Element = new();
public global::System.Int32 PointCount { get => PointCount_Element.Data; set => PointCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> PointCount_Element = new();
public global::System.Int32 SubmeshCount { get => SubmeshCount_Element.Data; set => SubmeshCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> SubmeshCount_Element = new();
public global::System.Int32 BoneCount { get => BoneCount_Element.Data; set => BoneCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BoneCount_Element = new();
public global::System.Int32 BlendshapeCount { get => BlendshapeCount_Element.Data; set => BlendshapeCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BlendshapeCount_Element = new();
public global::System.Boolean HasNormals { get => HasNormals_Element.Data; set => HasNormals_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasNormals_Element = new();
public global::System.Boolean HasTangents { get => HasTangents_Element.Data; set => HasTangents_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasTangents_Element = new();
public global::System.Boolean HasVertexColors { get => HasVertexColors_Element.Data; set => HasVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasVertexColors_Element = new();
public global::System.Boolean HasUV0s { get => HasUV0s_Element.Data; set => HasUV0s_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasUV0s_Element = new();
public global::System.Boolean HasUV1s { get => HasUV1s_Element.Data; set => HasUV1s_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasUV1s_Element = new();
public global::System.Boolean HasUV2s { get => HasUV2s_Element.Data; set => HasUV2s_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasUV2s_Element = new();
public global::System.Boolean HasUV3s { get => HasUV3s_Element.Data; set => HasUV3s_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasUV3s_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mesh", Mesh_Element.ToLinkReference(context));
members.Add("VertexCount", VertexCount_Element.ToLinkField(context));
members.Add("TriangleCount", TriangleCount_Element.ToLinkField(context));
members.Add("PointCount", PointCount_Element.ToLinkField(context));
members.Add("SubmeshCount", SubmeshCount_Element.ToLinkField(context));
members.Add("BoneCount", BoneCount_Element.ToLinkField(context));
members.Add("BlendshapeCount", BlendshapeCount_Element.ToLinkField(context));
members.Add("HasNormals", HasNormals_Element.ToLinkField(context));
members.Add("HasTangents", HasTangents_Element.ToLinkField(context));
members.Add("HasVertexColors", HasVertexColors_Element.ToLinkField(context));
members.Add("HasUV0s", HasUV0s_Element.ToLinkField(context));
members.Add("HasUV1s", HasUV1s_Element.ToLinkField(context));
members.Add("HasUV2s", HasUV2s_Element.ToLinkField(context));
members.Add("HasUV3s", HasUV3s_Element.ToLinkField(context));
}

}
}
