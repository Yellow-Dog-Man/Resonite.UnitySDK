
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.OverlappingLayout
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.OverlappingLayout")]
public partial class OverlappingLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single PaddingTop;
public global::System.Single PaddingRight;
public global::System.Single PaddingBottom;
public global::System.Single PaddingLeft;
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign;
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign;
public global::System.Boolean ForceExpandWidth;
public global::System.Boolean ForceExpandHeight;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PaddingTop", PaddingTop.ToResoniteLinkField());
members.Add("PaddingRight", PaddingRight.ToResoniteLinkField());
members.Add("PaddingBottom", PaddingBottom.ToResoniteLinkField());
members.Add("PaddingLeft", PaddingLeft.ToResoniteLinkField());
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("ForceExpandWidth", ForceExpandWidth.ToResoniteLinkField());
members.Add("ForceExpandHeight", ForceExpandHeight.ToResoniteLinkField());
}

}
}
