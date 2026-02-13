
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvexHullBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConvexHullBrushTool")]
public partial class ConvexHullBrushTool : global::FrooxEngine.BrushTool

{
    public global::System.Double MinHullPointDistance;
public global::System.Boolean FlatShading;
public global::System.Single PointSpread;
public global::FrooxEngine.Slot TipAnchor;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> MaterialPreviews;
public global::FrooxEngine.ConvexHullMesh _currentHull;
public global::FrooxEngine.ConvexHullMesh _previewMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinHullPointDistance", MinHullPointDistance.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("PointSpread", PointSpread.ToResoniteLinkField());
members.Add("TipAnchor", new ResoniteLink.Reference() { });
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_currentHull", new ResoniteLink.Reference() { });
members.Add("_previewMesh", new ResoniteLink.Reference() { });
members.Add("_previewMeshOffset", new ResoniteLink.Reference() { });
}

}
}
