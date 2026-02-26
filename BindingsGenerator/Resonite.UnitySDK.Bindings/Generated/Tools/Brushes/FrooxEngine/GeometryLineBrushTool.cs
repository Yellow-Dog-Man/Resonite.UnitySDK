
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeometryLineBrushTool")]
public partial class GeometryLineBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor { get => TipAnchor_Element.Data; set => TipAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipAnchor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GeometryLineBrushTool.Line>, global::FrooxEngine.GeometryLineBrushTool.Line> LineStyles = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();
public global::System.Boolean UseRelativeMinimumPointDistance { get => UseRelativeMinimumPointDistance_Element.Data; set => UseRelativeMinimumPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseRelativeMinimumPointDistance_Element = new();
public global::System.Single RelativeMinimumPointDistanceRatio { get => RelativeMinimumPointDistanceRatio_Element.Data; set => RelativeMinimumPointDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelativeMinimumPointDistanceRatio_Element = new();
public global::System.Boolean PressureAffectsSize { get => PressureAffectsSize_Element.Data; set => PressureAffectsSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsSize_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> MaterialPreviews = new();
public global::FrooxEngine.MultiLineMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.MultiLineMesh>, global::FrooxEngine.MultiLineMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();
public global::FrooxEngine.Slot _sizeKnob { get => _sizeKnob_Element.Data; set => _sizeKnob_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _sizeKnob_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor_Element.Data.ToResoniteReference(context));
members.Add("LineStyles", new ResoniteLink.SyncList()
{
    Elements = LineStyles.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Profile", Profile_Element.Data.ToResoniteLinkField());
members.Add("UseRelativeMinimumPointDistance", UseRelativeMinimumPointDistance_Element.Data.ToResoniteLinkField());
members.Add("RelativeMinimumPointDistanceRatio", RelativeMinimumPointDistanceRatio_Element.Data.ToResoniteLinkField());
members.Add("PressureAffectsSize", PressureAffectsSize_Element.Data.ToResoniteLinkField());
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_previewMesh", _previewMesh_Element.Data.ToResoniteReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.Data.ToResoniteReference(context));
members.Add("_sizeKnob", _sizeKnob_Element.Data.ToResoniteReference(context));
}

}
}
