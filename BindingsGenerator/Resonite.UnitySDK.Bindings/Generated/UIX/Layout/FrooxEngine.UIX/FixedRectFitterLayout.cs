
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.FixedRectFitterLayout
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign { get => HorizontalAlign_Element.Data; set => HorizontalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutHorizontalAlignment>, global::FrooxEngine.UIX.LayoutHorizontalAlignment> HorizontalAlign_Element = new();
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign { get => VerticalAlign_Element.Data; set => VerticalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutVerticalAlignment>, global::FrooxEngine.UIX.LayoutVerticalAlignment> VerticalAlign_Element = new();
public global::FrooxEngine.UIX.FixedRectFitterLayout.FitMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.FixedRectFitterLayout.FitMode>, global::FrooxEngine.UIX.FixedRectFitterLayout.FitMode> Mode_Element = new();
public global::System.Boolean AllowShrink { get => AllowShrink_Element.Data; set => AllowShrink_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowShrink_Element = new();
public global::System.Boolean AllowGrow { get => AllowGrow_Element.Data; set => AllowGrow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowGrow_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("AllowShrink", AllowShrink_Element.ToLinkField(context));
members.Add("AllowGrow", AllowGrow_Element.ToLinkField(context));
}

}
}
