
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BillboardBrushTool
// Generated on: pátek 13. února 2026 5:52:25
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BillboardBrushTool")]
public partial class BillboardBrushTool : global::FrooxEngine.PointBrushTool

{
    public global::System.Single MinRotation;
public global::System.Single MaxRotation;
public global::System.Single RotationGap;
public global::System.Boolean UseRotation;
public global::System.Boolean UseSize;
public global::System.Boolean UseUV;
public global::FrooxEngine.MeshRenderer _previewRenderer;
public global::FrooxEngine.PointMesh _previewMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _previewMeshOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinRotation", MinRotation.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation.ToResoniteLinkField());
members.Add("RotationGap", RotationGap.ToResoniteLinkField());
members.Add("UseRotation", UseRotation.ToResoniteLinkField());
members.Add("UseSize", UseSize.ToResoniteLinkField());
members.Add("UseUV", UseUV.ToResoniteLinkField());
members.Add("_previewRenderer", new ResoniteLink.Reference() { });
members.Add("_previewMesh", new ResoniteLink.Reference() { });
members.Add("_previewMeshOffset", new ResoniteLink.Reference() { });
}

}
}
