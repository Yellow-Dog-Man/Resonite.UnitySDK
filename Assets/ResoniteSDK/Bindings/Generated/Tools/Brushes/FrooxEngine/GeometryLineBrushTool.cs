
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeometryLineBrushTool
// Generated on: pátek 13. února 2026 23:23:08
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TipAnchor", new ResoniteLink.Reference() { });
members.Add("LineStyles", new ResoniteLink.SyncList()
{
    Elements = LineStyles.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("Profile", Profile.ToResoniteLinkField());
members.Add("UseRelativeMinimumPointDistance", UseRelativeMinimumPointDistance.ToResoniteLinkField());
members.Add("RelativeMinimumPointDistanceRatio", RelativeMinimumPointDistanceRatio.ToResoniteLinkField());
members.Add("PressureAffectsSize", PressureAffectsSize.ToResoniteLinkField());
members.Add("MaterialPreviews", new ResoniteLink.SyncList()
{
    Elements = MaterialPreviews.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_previewMesh", new ResoniteLink.Reference() { });
members.Add("_previewMeshOffset", new ResoniteLink.Reference() { });
members.Add("_sizeKnob", new ResoniteLink.Reference() { });
}

}
}
