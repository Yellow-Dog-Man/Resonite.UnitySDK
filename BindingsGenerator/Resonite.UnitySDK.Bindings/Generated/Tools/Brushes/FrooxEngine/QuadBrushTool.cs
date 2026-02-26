
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuadBrushTool")]
public partial class QuadBrushTool : global::FrooxEngine.PointBrushTool

{
    public UnityEngine.Vector3 Pivot { get => Pivot_Element.Data; set => Pivot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Pivot_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public UnityEngine.Vector3 MinRotation { get => MinRotation_Element.Data; set => MinRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MinRotation_Element = new();
public UnityEngine.Vector3 MaxRotation { get => MaxRotation_Element.Data; set => MaxRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MaxRotation_Element = new();
public global::FrooxEngine.RootSpace RotationSpace = new();
public global::FrooxEngine.MeshRenderer _previewRenderer { get => _previewRenderer_Element.Data; set => _previewRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _previewRenderer_Element = new();
public global::FrooxEngine.QuadArrayMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.QuadArrayMesh>, global::FrooxEngine.QuadArrayMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _previewMeshRotation { get => _previewMeshRotation_Element.Data; set => _previewMeshRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _previewMeshRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Pivot", Pivot_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
members.Add("MinRotation", MinRotation_Element.ToLinkField(context));
members.Add("MaxRotation", MaxRotation_Element.ToLinkField(context));
members.Add("RotationSpace", RotationSpace.ToLinkSyncObject(context));
members.Add("_previewRenderer", _previewRenderer_Element.ToLinkReference(context));
members.Add("_previewMesh", _previewMesh_Element.ToLinkReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.ToLinkReference(context));
members.Add("_previewMeshRotation", _previewMeshRotation_Element.ToLinkReference(context));
}

}
}
