
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeBoxMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeBoxMesh")]
public partial class TubeBoxMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Size;
public global::System.Single TubeRadius;
public global::System.Int32 SegmentPoints;
public UnityEngine.Vector2 UVScale;
public UnityEngine.Vector2 UVOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("TubeRadius", TubeRadius.ToResoniteLinkField());
members.Add("SegmentPoints", SegmentPoints.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
}

}
}
