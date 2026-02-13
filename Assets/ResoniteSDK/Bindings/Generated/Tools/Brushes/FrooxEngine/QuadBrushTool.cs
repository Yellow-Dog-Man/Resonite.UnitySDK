
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadBrushTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuadBrushTool")]
public partial class QuadBrushTool : global::FrooxEngine.PointBrushTool

{
    public UnityEngine.Vector3 Pivot;
public global::System.Boolean DualSided;
public UnityEngine.Vector3 MinRotation;
public UnityEngine.Vector3 MaxRotation;
public global::FrooxEngine.RootSpace RotationSpace;
public global::FrooxEngine.MeshRenderer _previewRenderer;
public global::FrooxEngine.QuadArrayMesh _previewMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _previewMeshRotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Pivot", Pivot.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("MinRotation", MinRotation.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation.ToResoniteLinkField());
members.Add("RotationSpace", new ResoniteLink.SyncObject() { Members = RotationSpace.CollectMembers() });
members.Add("_previewRenderer", new ResoniteLink.Reference() { });
members.Add("_previewMesh", new ResoniteLink.Reference() { });
members.Add("_previewMeshOffset", new ResoniteLink.Reference() { });
members.Add("_previewMeshRotation", new ResoniteLink.Reference() { });
}

}
}
