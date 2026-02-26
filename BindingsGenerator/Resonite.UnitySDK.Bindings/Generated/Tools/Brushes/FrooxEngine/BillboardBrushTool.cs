
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BillboardBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BillboardBrushTool")]
public partial class BillboardBrushTool : global::FrooxEngine.PointBrushTool

{
    public global::System.Single MinRotation { get => MinRotation_Element.Data; set => MinRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRotation_Element = new();
public global::System.Single MaxRotation { get => MaxRotation_Element.Data; set => MaxRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRotation_Element = new();
public global::System.Single RotationGap { get => RotationGap_Element.Data; set => RotationGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationGap_Element = new();
public global::System.Boolean UseRotation { get => UseRotation_Element.Data; set => UseRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseRotation_Element = new();
public global::System.Boolean UseSize { get => UseSize_Element.Data; set => UseSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSize_Element = new();
public global::System.Boolean UseUV { get => UseUV_Element.Data; set => UseUV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseUV_Element = new();
public global::FrooxEngine.MeshRenderer _previewRenderer { get => _previewRenderer_Element.Data; set => _previewRenderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _previewRenderer_Element = new();
public global::FrooxEngine.PointMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PointMesh>, global::FrooxEngine.PointMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinRotation", MinRotation_Element.Data.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation_Element.Data.ToResoniteLinkField());
members.Add("RotationGap", RotationGap_Element.Data.ToResoniteLinkField());
members.Add("UseRotation", UseRotation_Element.Data.ToResoniteLinkField());
members.Add("UseSize", UseSize_Element.Data.ToResoniteLinkField());
members.Add("UseUV", UseUV_Element.Data.ToResoniteLinkField());
members.Add("_previewRenderer", _previewRenderer_Element.Data.ToResoniteReference(context));
members.Add("_previewMesh", _previewMesh_Element.Data.ToResoniteReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.Data.ToResoniteReference(context));
}

}
}
