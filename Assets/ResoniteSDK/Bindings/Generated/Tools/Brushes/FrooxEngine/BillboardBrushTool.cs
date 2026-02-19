
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BillboardBrushTool
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinRotation", MinRotation.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation.ToResoniteLinkField());
members.Add("RotationGap", RotationGap.ToResoniteLinkField());
members.Add("UseRotation", UseRotation.ToResoniteLinkField());
members.Add("UseSize", UseSize.ToResoniteLinkField());
members.Add("UseUV", UseUV.ToResoniteLinkField());
members.Add("_previewRenderer", _previewRenderer.ToResoniteReference(context));
members.Add("_previewMesh", _previewMesh.ToResoniteReference(context));
members.Add("_previewMeshOffset", _previewMeshOffset.ToResoniteReference(context));
}

}
}
