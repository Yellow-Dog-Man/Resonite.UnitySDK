
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshPlaneBrushTool
// Generated on: pátek 13. února 2026 5:52:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshPlaneBrushTool")]
public partial class MeshPlaneBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> MaterialPreviews;
public global::FrooxEngine.ConstrainedDelaunayMesh _currentMesh;
public global::FrooxEngine.ConstrainedDelaunayMesh.Hole _currentHole;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TipAnchor", new ResoniteLink.Reference() { });
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_currentMesh", new ResoniteLink.Reference() { });
members.Add("_currentHole", new ResoniteLink.Reference() { });
}

}
}
