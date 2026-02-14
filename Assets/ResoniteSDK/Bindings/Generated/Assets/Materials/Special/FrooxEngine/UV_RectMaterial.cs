
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UV_RectMaterial
// Generated on: sobota 14. února 2026 8:56:57
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UV_RectMaterial")]
public partial class UV_RectMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.Rect Rect;
public UnityEngine.ColorX OuterColor;
public UnityEngine.ColorX InnerColor;
public global::System.Nullable<UnityEngine.Rect> ClipRect;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("OuterColor", OuterColor.ToResoniteLinkField());
members.Add("InnerColor", InnerColor.ToResoniteLinkField());
members.Add("ClipRect", ClipRect.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
