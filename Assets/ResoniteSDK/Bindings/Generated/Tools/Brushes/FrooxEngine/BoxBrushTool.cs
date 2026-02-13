
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxBrushTool")]
public partial class BoxBrushTool : global::FrooxEngine.ParticleBrushTool

{
    public UnityEngine.Vector3 Pivot;
public UnityEngine.ColorX MinColor;
public UnityEngine.ColorX MaxColor;
public global::System.Single ColorGap;
public global::System.Boolean UniformSize;
public UnityEngine.Vector3 MinSize;
public UnityEngine.Vector3 MaxSize;
public global::System.Single SizeGap;
public UnityEngine.Vector3 MinRotation;
public UnityEngine.Vector3 MaxRotation;
public UnityEngine.Vector3 MinUVScale;
public UnityEngine.Vector3 MaxUVScale;
public global::System.Single UVScaleGap;
public global::FrooxEngine.RootSpace RotationSpace;
public global::System.Boolean UseColor;
public global::System.Boolean ScaleUVWithSize;
public global::FrooxEngine.MeshRenderer _previewRenderer;
public global::FrooxEngine.BoxArrayMesh _previewMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _previewMeshRotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Pivot", Pivot.ToResoniteLinkField());
members.Add("MinColor", MinColor.ToResoniteLinkField());
members.Add("MaxColor", MaxColor.ToResoniteLinkField());
members.Add("ColorGap", ColorGap.ToResoniteLinkField());
members.Add("UniformSize", UniformSize.ToResoniteLinkField());
members.Add("MinSize", MinSize.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("SizeGap", SizeGap.ToResoniteLinkField());
members.Add("MinRotation", MinRotation.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation.ToResoniteLinkField());
members.Add("MinUVScale", MinUVScale.ToResoniteLinkField());
members.Add("MaxUVScale", MaxUVScale.ToResoniteLinkField());
members.Add("UVScaleGap", UVScaleGap.ToResoniteLinkField());
members.Add("RotationSpace", new ResoniteLink.SyncObject() { Members = RotationSpace.CollectMembers() });
members.Add("UseColor", UseColor.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize.ToResoniteLinkField());
members.Add("_previewRenderer", new ResoniteLink.Reference() { });
members.Add("_previewMesh", new ResoniteLink.Reference() { });
members.Add("_previewMeshOffset", new ResoniteLink.Reference() { });
members.Add("_previewMeshRotation", new ResoniteLink.Reference() { });
}

}
}
