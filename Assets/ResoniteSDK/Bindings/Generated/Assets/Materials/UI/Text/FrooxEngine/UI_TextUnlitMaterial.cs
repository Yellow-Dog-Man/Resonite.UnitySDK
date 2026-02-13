
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_TextUnlitMaterial
// Generated on: pátek 13. února 2026 23:21:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_TextUnlitMaterial")]
public partial class UI_TextUnlitMaterial : global::FrooxEngine.TextUnlitMaterial, global::FrooxEngine.IUIX_Material

{
    public global::System.Boolean Overlay;
public UnityEngine.ColorX OverlayTint;
public UnityEngine.Rect Rect;
public global::System.Boolean RectClip;
public global::FrooxEngine.ColorMask ColorMask;
public global::FrooxEngine.StencilComparison StencilComparison;
public global::FrooxEngine.StencilOperation StencilOperation;
public global::System.Byte StencilID;
public global::System.Byte StencilWriteMask;
public global::System.Byte StencilReadMask;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Overlay", Overlay.ToResoniteLinkField());
members.Add("OverlayTint", OverlayTint.ToResoniteLinkField());
members.Add("Rect", Rect.ToResoniteLinkField());
members.Add("RectClip", RectClip.ToResoniteLinkField());
members.Add("ColorMask", ColorMask.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation.ToResoniteLinkField());
members.Add("StencilID", StencilID.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask.ToResoniteLinkField());
}

}
}
