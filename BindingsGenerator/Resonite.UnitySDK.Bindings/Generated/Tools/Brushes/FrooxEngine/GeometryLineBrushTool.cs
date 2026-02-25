
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeometryLineBrushTool")]
public partial class GeometryLineBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor;
public System.Collections.Generic.List<global::FrooxEngine.GeometryLineBrushTool.Line> LineStyles;
public global::Renderite.Shared.ColorProfile Profile;
public global::System.Boolean UseRelativeMinimumPointDistance;
public global::System.Single RelativeMinimumPointDistanceRatio;
public global::System.Boolean PressureAffectsSize;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> MaterialPreviews;
public global::FrooxEngine.MultiLineMesh _previewMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset;
public global::FrooxEngine.Slot _sizeKnob;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor.ToResoniteReference(context));
members.Add("LineStyles", new ResoniteLink.SyncList()
{
    Elements = LineStyles.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Profile", Profile.ToResoniteLinkField());
members.Add("UseRelativeMinimumPointDistance", UseRelativeMinimumPointDistance.ToResoniteLinkField());
members.Add("RelativeMinimumPointDistanceRatio", RelativeMinimumPointDistanceRatio.ToResoniteLinkField());
members.Add("PressureAffectsSize", PressureAffectsSize.ToResoniteLinkField());
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_previewMesh", _previewMesh.ToResoniteReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset.ToResoniteReference(context));
members.Add("_sizeKnob", _sizeKnob.ToResoniteReference(context));
}

}
}
