
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BillboardRenderBufferRenderer
// Generated on: středa 25. února 2026 16:14:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BillboardRenderBufferRenderer")]
public partial class BillboardRenderBufferRenderer : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.PointRenderBuffer> Buffer;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::Renderite.Shared.BillboardAlignment Alignment;
public global::Renderite.Shared.MotionVectorMode MotionVectorMode;
public global::System.Single MinBillboardScreenSize;
public global::System.Single MaxBillboardScreenSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Buffer", Buffer.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Alignment", Alignment.ToResoniteLinkField());
members.Add("MotionVectorMode", MotionVectorMode.ToResoniteLinkField());
members.Add("MinBillboardScreenSize", MinBillboardScreenSize.ToResoniteLinkField());
members.Add("MaxBillboardScreenSize", MaxBillboardScreenSize.ToResoniteLinkField());
}

}
}
