
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.FixedRectFitterLayout
// Generated on: středa 25. února 2026 16:14:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.FixedRectFitterLayout")]
public partial class FixedRectFitterLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign;
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign;
public global::FrooxEngine.UIX.FixedRectFitterLayout.FitMode Mode;
public global::System.Boolean AllowShrink;
public global::System.Boolean AllowGrow;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HorizontalAlign", HorizontalAlign.ToResoniteLinkField());
members.Add("VerticalAlign", VerticalAlign.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("AllowShrink", AllowShrink.ToResoniteLinkField());
members.Add("AllowGrow", AllowGrow.ToResoniteLinkField());
}

}
}
