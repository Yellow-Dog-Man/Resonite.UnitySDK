
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BillboardBrushTool
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _previewRenderer_Element = new();
public global::FrooxEngine.PointMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PointMesh>, global::FrooxEngine.PointMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinRotation", MinRotation_Element.ToLinkField(context));
members.Add("MaxRotation", MaxRotation_Element.ToLinkField(context));
members.Add("RotationGap", RotationGap_Element.ToLinkField(context));
members.Add("UseRotation", UseRotation_Element.ToLinkField(context));
members.Add("UseSize", UseSize_Element.ToLinkField(context));
members.Add("UseUV", UseUV_Element.ToLinkField(context));
members.Add("_previewRenderer", _previewRenderer_Element.ToLinkReference(context));
members.Add("_previewMesh", _previewMesh_Element.ToLinkReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.ToLinkReference(context));
}

}
}
