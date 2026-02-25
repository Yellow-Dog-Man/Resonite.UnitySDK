
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TubeMesh")]
public partial class TubeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.TubePoint[] Points;
public global::System.Int32 SegmentPoints;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToResoniteLinkArray());
members.Add("SegmentPoints", SegmentPoints.ToResoniteLinkField());
}

}
}
