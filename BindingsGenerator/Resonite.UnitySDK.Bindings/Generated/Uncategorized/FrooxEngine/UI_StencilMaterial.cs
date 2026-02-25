
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_StencilMaterial
// Generated on: středa 25. února 2026 16:13:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_StencilMaterial")]
public abstract partial class UI_StencilMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IUIX_Material

{
    public UnityEngine.Rect Rect;
public global::System.Boolean RectClip;
public global::FrooxEngine.ColorMask ColorMask;
public global::FrooxEngine.StencilComparison StencilComparison;
public global::FrooxEngine.StencilOperation StencilOperation;
public global::System.Byte StencilID;
public global::System.Byte StencilWriteMask;
public global::System.Byte StencilReadMask;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("RectClip", RectClip.ToResoniteLinkField());
members.Add("ColorMask", ColorMask.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation.ToResoniteLinkField());
members.Add("StencilID", StencilID.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
