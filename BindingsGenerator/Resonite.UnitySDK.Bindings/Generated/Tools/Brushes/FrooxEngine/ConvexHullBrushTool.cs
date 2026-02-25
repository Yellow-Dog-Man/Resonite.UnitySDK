
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvexHullBrushTool
// Generated on: středa 25. února 2026 16:14:28
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinHullPointDistance", MinHullPointDistance.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("PointSpread", PointSpread.ToResoniteLinkField());
members.Add("TipAnchor", TipAnchor.ToResoniteReference(context));
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_currentHull", _currentHull.ToResoniteReference(context));
members.Add("_previewMesh", _previewMesh.ToResoniteReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset.ToResoniteReference(context));
}

}
}
