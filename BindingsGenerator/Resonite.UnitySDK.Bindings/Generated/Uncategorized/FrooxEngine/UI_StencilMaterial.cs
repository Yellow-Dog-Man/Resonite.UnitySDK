
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_StencilMaterial
// Generated on: čtvrtek 26. února 2026 12:26:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_StencilMaterial")]
public abstract partial class UI_StencilMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IUIX_Material

{
    public UnityEngine.Rect Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Rect_Element = new();
public global::System.Boolean RectClip { get => RectClip_Element.Data; set => RectClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RectClip_Element = new();
public global::FrooxEngine.ColorMask ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ColorMask>, global::FrooxEngine.ColorMask> ColorMask_Element = new();
public global::FrooxEngine.StencilComparison StencilComparison { get => StencilComparison_Element.Data; set => StencilComparison_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilComparison>, global::FrooxEngine.StencilComparison> StencilComparison_Element = new();
public global::FrooxEngine.StencilOperation StencilOperation { get => StencilOperation_Element.Data; set => StencilOperation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilOperation>, global::FrooxEngine.StencilOperation> StencilOperation_Element = new();
public global::System.Byte StencilID { get => StencilID_Element.Data; set => StencilID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilID_Element = new();
public global::System.Byte StencilWriteMask { get => StencilWriteMask_Element.Data; set => StencilWriteMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilWriteMask_Element = new();
public global::System.Byte StencilReadMask { get => StencilReadMask_Element.Data; set => StencilReadMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilReadMask_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect_Element.ToLinkField(context));
members.Add("RectClip", RectClip_Element.ToLinkField(context));
members.Add("ColorMask", ColorMask_Element.ToLinkField(context));
members.Add("StencilComparison", StencilComparison_Element.ToLinkField(context));
members.Add("StencilOperation", StencilOperation_Element.ToLinkField(context));
members.Add("StencilID", StencilID_Element.ToLinkField(context));
members.Add("StencilWriteMask", StencilWriteMask_Element.ToLinkField(context));
members.Add("StencilReadMask", StencilReadMask_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
