
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConvexHullBrushTool
// Generated on: čtvrtek 26. února 2026 12:28:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConvexHullBrushTool")]
public partial class ConvexHullBrushTool : global::FrooxEngine.BrushTool

{
    public global::System.Double MinHullPointDistance { get => MinHullPointDistance_Element.Data; set => MinHullPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> MinHullPointDistance_Element = new();
public global::System.Boolean FlatShading { get => FlatShading_Element.Data; set => FlatShading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlatShading_Element = new();
public global::System.Single PointSpread { get => PointSpread_Element.Data; set => PointSpread_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PointSpread_Element = new();
public global::FrooxEngine.Slot TipAnchor { get => TipAnchor_Element.Data; set => TipAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipAnchor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> MaterialPreviews = new();
public global::FrooxEngine.ConvexHullMesh _currentHull { get => _currentHull_Element.Data; set => _currentHull_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ConvexHullMesh>, global::FrooxEngine.ConvexHullMesh> _currentHull_Element = new();
public global::FrooxEngine.ConvexHullMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.ConvexHullMesh>, global::FrooxEngine.ConvexHullMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinHullPointDistance", MinHullPointDistance_Element.ToLinkField(context));
members.Add("FlatShading", FlatShading_Element.ToLinkField(context));
members.Add("PointSpread", PointSpread_Element.ToLinkField(context));
members.Add("TipAnchor", TipAnchor_Element.ToLinkReference(context));
members.Add("MaterialPreviews", MaterialPreviews.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_currentHull", _currentHull_Element.ToLinkReference(context));
members.Add("_previewMesh", _previewMesh_Element.ToLinkReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.ToLinkReference(context));
}

}
}
