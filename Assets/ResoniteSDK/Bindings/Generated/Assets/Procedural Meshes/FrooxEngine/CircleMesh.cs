
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CircleMesh
// Generated on: úterý 24. února 2026 18:17:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CircleMesh")]
public partial class CircleMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Rotation;
public global::System.Int32 Segments;
public global::System.Single Radius;
public global::System.Single Arc;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean ScaleUVWithSize;
public global::System.Boolean TriangleFan;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize.ToResoniteLinkField());
members.Add("TriangleFan", TriangleFan.ToResoniteLinkField());
}

}
}
