
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.GridLayout
// Generated on: pátek 13. února 2026 23:23:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.GridLayout")]
public partial class GridLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single PaddingTop;
public global::System.Single PaddingRight;
public global::System.Single PaddingBottom;
public global::System.Single PaddingLeft;
public UnityEngine.Vector2 CellSize;
public UnityEngine.Vector2 Spacing;
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign;
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign;
public global::System.Boolean ExpandWidthToFit;
public global::System.Boolean PreserveAspectOnExpand;
public global::System.Boolean AlignLastRowIndividually;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PaddingTop", PaddingTop.ToResoniteLinkField());
members.Add("PaddingRight", PaddingRight.ToResoniteLinkField());
members.Add("PaddingBottom", PaddingBottom.ToResoniteLinkField());
members.Add("PaddingLeft", PaddingLeft.ToResoniteLinkField());
members.Add("CellSize", CellSize.ToResoniteLinkField());
members.Add("Spacing", Spacing.ToResoniteLinkField());
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("ExpandWidthToFit", ExpandWidthToFit.ToResoniteLinkField());
members.Add("PreserveAspectOnExpand", PreserveAspectOnExpand.ToResoniteLinkField());
members.Add("AlignLastRowIndividually", AlignLastRowIndividually.ToResoniteLinkField());
}

}
}
