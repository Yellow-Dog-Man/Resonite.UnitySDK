
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TubeMesh
// Generated on: čtvrtek 26. února 2026 15:07:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::SyncArray<global::FrooxEngine.SyncArray<global::FrooxEngine.TubePoint>, global::FrooxEngine.TubePoint> Points = new();
public global::System.Int32 SegmentPoints { get => SegmentPoints_Element.Data; set => SegmentPoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SegmentPoints_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Points", Points.ToLinkArray(context));
members.Add("SegmentPoints", SegmentPoints_Element.ToLinkField(context));
}

}
}
