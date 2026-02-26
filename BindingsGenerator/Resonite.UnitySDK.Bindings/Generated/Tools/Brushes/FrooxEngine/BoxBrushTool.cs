
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxBrushTool")]
public partial class BoxBrushTool : global::FrooxEngine.ParticleBrushTool

{
    public UnityEngine.Vector3 Pivot { get => Pivot_Element.Data; set => Pivot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Pivot_Element = new();
public UnityEngine.ColorX MinColor { get => MinColor_Element.Data; set => MinColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MinColor_Element = new();
public UnityEngine.ColorX MaxColor { get => MaxColor_Element.Data; set => MaxColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MaxColor_Element = new();
public global::System.Single ColorGap { get => ColorGap_Element.Data; set => ColorGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorGap_Element = new();
public global::System.Boolean UniformSize { get => UniformSize_Element.Data; set => UniformSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UniformSize_Element = new();
public UnityEngine.Vector3 MinSize { get => MinSize_Element.Data; set => MinSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MinSize_Element = new();
public UnityEngine.Vector3 MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MaxSize_Element = new();
public global::System.Single SizeGap { get => SizeGap_Element.Data; set => SizeGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SizeGap_Element = new();
public UnityEngine.Vector3 MinRotation { get => MinRotation_Element.Data; set => MinRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MinRotation_Element = new();
public UnityEngine.Vector3 MaxRotation { get => MaxRotation_Element.Data; set => MaxRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MaxRotation_Element = new();
public UnityEngine.Vector3 MinUVScale { get => MinUVScale_Element.Data; set => MinUVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MinUVScale_Element = new();
public UnityEngine.Vector3 MaxUVScale { get => MaxUVScale_Element.Data; set => MaxUVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MaxUVScale_Element = new();
public global::System.Single UVScaleGap { get => UVScaleGap_Element.Data; set => UVScaleGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UVScaleGap_Element = new();
public global::FrooxEngine.RootSpace RotationSpace = new();
public global::System.Boolean UseColor { get => UseColor_Element.Data; set => UseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseColor_Element = new();
public global::System.Boolean ScaleUVWithSize { get => ScaleUVWithSize_Element.Data; set => ScaleUVWithSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUVWithSize_Element = new();
public global::FrooxEngine.MeshRenderer _previewRenderer { get => _previewRenderer_Element.Data; set => _previewRenderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _previewRenderer_Element = new();
public global::FrooxEngine.BoxArrayMesh _previewMesh { get => _previewMesh_Element.Data; set => _previewMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BoxArrayMesh>, global::FrooxEngine.BoxArrayMesh> _previewMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset { get => _previewMeshOffset_Element.Data; set => _previewMeshOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _previewMeshOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _previewMeshRotation { get => _previewMeshRotation_Element.Data; set => _previewMeshRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _previewMeshRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Pivot", Pivot_Element.ToLinkField(context));
members.Add("MinColor", MinColor_Element.ToLinkField(context));
members.Add("MaxColor", MaxColor_Element.ToLinkField(context));
members.Add("ColorGap", ColorGap_Element.ToLinkField(context));
members.Add("UniformSize", UniformSize_Element.ToLinkField(context));
members.Add("MinSize", MinSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("SizeGap", SizeGap_Element.ToLinkField(context));
members.Add("MinRotation", MinRotation_Element.ToLinkField(context));
members.Add("MaxRotation", MaxRotation_Element.ToLinkField(context));
members.Add("MinUVScale", MinUVScale_Element.ToLinkField(context));
members.Add("MaxUVScale", MaxUVScale_Element.ToLinkField(context));
members.Add("UVScaleGap", UVScaleGap_Element.ToLinkField(context));
members.Add("RotationSpace", RotationSpace.ToLinkSyncObject(context));
members.Add("UseColor", UseColor_Element.ToLinkField(context));
members.Add("ScaleUVWithSize", ScaleUVWithSize_Element.ToLinkField(context));
members.Add("_previewRenderer", _previewRenderer_Element.ToLinkReference(context));
members.Add("_previewMesh", _previewMesh_Element.ToLinkReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset_Element.ToLinkReference(context));
members.Add("_previewMeshRotation", _previewMeshRotation_Element.ToLinkReference(context));
}

}
}
