
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.GridLayout
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.GridLayout")]
public partial class GridLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single PaddingTop { get => PaddingTop_Element.Data; set => PaddingTop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingTop_Element = new();
public global::System.Single PaddingRight { get => PaddingRight_Element.Data; set => PaddingRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingRight_Element = new();
public global::System.Single PaddingBottom { get => PaddingBottom_Element.Data; set => PaddingBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingBottom_Element = new();
public global::System.Single PaddingLeft { get => PaddingLeft_Element.Data; set => PaddingLeft_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PaddingLeft_Element = new();
public UnityEngine.Vector2 CellSize { get => CellSize_Element.Data; set => CellSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> CellSize_Element = new();
public UnityEngine.Vector2 Spacing { get => Spacing_Element.Data; set => Spacing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Spacing_Element = new();
public global::FrooxEngine.UIX.LayoutHorizontalAlignment HorizontalAlign { get => HorizontalAlign_Element.Data; set => HorizontalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutHorizontalAlignment>, global::FrooxEngine.UIX.LayoutHorizontalAlignment> HorizontalAlign_Element = new();
public global::FrooxEngine.UIX.LayoutVerticalAlignment VerticalAlign { get => VerticalAlign_Element.Data; set => VerticalAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.LayoutVerticalAlignment>, global::FrooxEngine.UIX.LayoutVerticalAlignment> VerticalAlign_Element = new();
public global::System.Boolean ExpandWidthToFit { get => ExpandWidthToFit_Element.Data; set => ExpandWidthToFit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExpandWidthToFit_Element = new();
public global::System.Boolean PreserveAspectOnExpand { get => PreserveAspectOnExpand_Element.Data; set => PreserveAspectOnExpand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveAspectOnExpand_Element = new();
public global::System.Boolean AlignLastRowIndividually { get => AlignLastRowIndividually_Element.Data; set => AlignLastRowIndividually_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlignLastRowIndividually_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PaddingTop", PaddingTop_Element.ToLinkField(context));
members.Add("PaddingRight", PaddingRight_Element.ToLinkField(context));
members.Add("PaddingBottom", PaddingBottom_Element.ToLinkField(context));
members.Add("PaddingLeft", PaddingLeft_Element.ToLinkField(context));
members.Add("CellSize", CellSize_Element.ToLinkField(context));
members.Add("Spacing", Spacing_Element.ToLinkField(context));
members.Add("HorizontalAlign", HorizontalAlign_Element.ToLinkField(context));
members.Add("VerticalAlign", VerticalAlign_Element.ToLinkField(context));
members.Add("ExpandWidthToFit", ExpandWidthToFit_Element.ToLinkField(context));
members.Add("PreserveAspectOnExpand", PreserveAspectOnExpand_Element.ToLinkField(context));
members.Add("AlignLastRowIndividually", AlignLastRowIndividually_Element.ToLinkField(context));
}

}
}
