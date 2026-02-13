
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeBoxMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeBoxMesh")]
public partial class TubeBoxMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Size;
public global::System.Single TubeRadius;
public global::System.Int32 SegmentPoints;
public UnityEngine.Vector2 UVScale;
public UnityEngine.Vector2 UVOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("TubeRadius", TubeRadius.ToResoniteLinkField());
members.Add("SegmentPoints", SegmentPoints.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
}

}
}
