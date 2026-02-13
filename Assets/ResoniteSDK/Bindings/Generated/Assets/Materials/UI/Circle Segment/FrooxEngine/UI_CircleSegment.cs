
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_CircleSegment
// Generated on: pátek 13. února 2026 5:51:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_CircleSegment")]
public partial class UI_CircleSegment : global::FrooxEngine.SingleShaderUI_StencilMaterial

{
    public UnityEngine.ColorX FillTint;
public UnityEngine.ColorX OutlineTint;
public global::System.Boolean Overlay;
public UnityEngine.ColorX OverlayTint;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FillTint", FillTint.ToResoniteLinkField());
members.Add("OutlineTint", OutlineTint.ToResoniteLinkField());
members.Add("Overlay", Overlay.ToResoniteLinkField());
members.Add("OverlayTint", OverlayTint.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
}

}
}
