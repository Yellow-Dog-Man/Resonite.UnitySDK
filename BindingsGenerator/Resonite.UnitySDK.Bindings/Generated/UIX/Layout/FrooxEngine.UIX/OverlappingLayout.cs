
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.OverlappingLayout
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.OverlappingLayout")]
public partial class OverlappingLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single PaddingTop { get => PaddingTop_Element.Data; set => PaddingTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingTop_Element = new();
public global::System.Single PaddingRight { get => PaddingRight_Element.Data; set => PaddingRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingRight_Element = new();
public global::System.Single PaddingBottom { get => PaddingBottom_Element.Data; set => PaddingBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingBottom_Element = new();
public global::System.Single PaddingLeft { get => PaddingLeft_Element.Data; set => PaddingLeft_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingLeft_Element = new();
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign { get => HorizontalAlign_Element.Data; set => HorizontalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutHorizontalAlignment>, global::FrooxEngine.UIX.LayoutHorizontalAlignment> HorizontalAlign_Element = new();
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign { get => VerticalAlign_Element.Data; set => VerticalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutVerticalAlignment>, global::FrooxEngine.UIX.LayoutVerticalAlignment> VerticalAlign_Element = new();
public global::System.Boolean ForceExpandWidth { get => ForceExpandWidth_Element.Data; set => ForceExpandWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceExpandWidth_Element = new();
public global::System.Boolean ForceExpandHeight { get => ForceExpandHeight_Element.Data; set => ForceExpandHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceExpandHeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PaddingTop", PaddingTop_Element.ToLinkField(context));
members.Add("PaddingRight", PaddingRight_Element.ToLinkField(context));
members.Add("PaddingBottom", PaddingBottom_Element.ToLinkField(context));
members.Add("PaddingLeft", PaddingLeft_Element.ToLinkField(context));
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("ForceExpandWidth", ForceExpandWidth_Element.ToLinkField(context));
members.Add("ForceExpandHeight", ForceExpandHeight_Element.ToLinkField(context));
}

}
}
