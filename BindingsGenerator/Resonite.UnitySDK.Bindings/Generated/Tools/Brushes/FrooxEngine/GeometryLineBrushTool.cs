
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeometryLineBrushTool")]
public partial class GeometryLineBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor { get => TipAnchor_Element.Data; set => TipAnchor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipAnchor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GeometryLineBrushTool.Line>, global::FrooxEngine.GeometryLineBrushTool.Line> LineStyles = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();
public global::System.Boolean UseRelativeMinimumPointDistance { get => UseRelativeMinimumPointDistance_Element.Data; set => UseRelativeMinimumPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseRelativeMinimumPointDistance_Element = new();
public global::System.Single RelativeMinimumPointDistanceRatio { get => RelativeMinimumPointDistanceRatio_Element.Data; set => RelativeMinimumPointDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RelativeMinimumPointDistanceRatio_Element = new();
public global::System.Boolean PressureAffectsSize { get => PressureAffectsSize_Element.Data; set => PressureAffectsSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PressureAffectsSize_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> MaterialPreviews = new();
public global::FrooxEngine.MultiLineMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.MultiLineMesh>, global::FrooxEngine.MultiLineMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();
public global::FrooxEngine.Slot _sizeKnob { get => _sizeKnob_Element.Data; set => _sizeKnob_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _sizeKnob_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor_Element.ToLinkReference(context));
members.Add("LineStyles", LineStyles.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Profile", Profile_Element.ToLinkField(context));
members.Add("UseRelativeMinimumPointDistance", UseRelativeMinimumPointDistance_Element.ToLinkField(context));
members.Add("RelativeMinimumPointDistanceRatio", RelativeMinimumPointDistanceRatio_Element.ToLinkField(context));
members.Add("PressureAffectsSize", PressureAffectsSize_Element.ToLinkField(context));
members.Add("MaterialPreviews", MaterialPreviews.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_previewMesh", _previewMesh_Element.ToLinkReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.ToLinkReference(context));
members.Add("_sizeKnob", _sizeKnob_Element.ToLinkReference(context));
}

}
}
