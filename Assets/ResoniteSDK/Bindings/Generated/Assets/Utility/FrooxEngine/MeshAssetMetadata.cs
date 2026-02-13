
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshAssetMetadata
// Generated on: pátek 13. února 2026 5:51:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshAssetMetadata")]
public partial class MeshAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Mesh> Mesh;
public global::System.Int32 VertexCount;
public global::System.Int32 TriangleCount;
public global::System.Int32 PointCount;
public global::System.Int32 SubmeshCount;
public global::System.Int32 BoneCount;
public global::System.Int32 BlendshapeCount;
public global::System.Boolean HasNormals;
public global::System.Boolean HasTangents;
public global::System.Boolean HasVertexColors;
public global::System.Boolean HasUV0s;
public global::System.Boolean HasUV1s;
public global::System.Boolean HasUV2s;
public global::System.Boolean HasUV3s;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mesh", new ResoniteLink.Reference() { });
members.Add("VertexCount", VertexCount.ToResoniteLinkField());
members.Add("TriangleCount", TriangleCount.ToResoniteLinkField());
members.Add("PointCount", PointCount.ToResoniteLinkField());
members.Add("SubmeshCount", SubmeshCount.ToResoniteLinkField());
members.Add("BoneCount", BoneCount.ToResoniteLinkField());
members.Add("BlendshapeCount", BlendshapeCount.ToResoniteLinkField());
members.Add("HasNormals", HasNormals.ToResoniteLinkField());
members.Add("HasTangents", HasTangents.ToResoniteLinkField());
members.Add("HasVertexColors", HasVertexColors.ToResoniteLinkField());
members.Add("HasUV0s", HasUV0s.ToResoniteLinkField());
members.Add("HasUV1s", HasUV1s.ToResoniteLinkField());
members.Add("HasUV2s", HasUV2s.ToResoniteLinkField());
members.Add("HasUV3s", HasUV3s.ToResoniteLinkField());
}

}
}
