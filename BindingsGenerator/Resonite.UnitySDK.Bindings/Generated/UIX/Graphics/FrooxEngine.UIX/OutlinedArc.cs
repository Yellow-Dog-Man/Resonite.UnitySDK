
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.OutlinedArc
// Generated on: čtvrtek 26. února 2026 10:04:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.OutlinedArc")]
public partial class OutlinedArc : global::FrooxEngine.UIX.Graphic, global::FrooxEngine.UIX.ILayoutElement

{
    public global::System.Single Arc { get => Arc_Element.Data; set => Arc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Arc_Element = new();
public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::System.Single OuterRadiusRatio { get => OuterRadiusRatio_Element.Data; set => OuterRadiusRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterRadiusRatio_Element = new();
public global::System.Single InnerRadiusRatio { get => InnerRadiusRatio_Element.Data; set => InnerRadiusRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerRadiusRatio_Element = new();
public global::System.Single RoundedCornerRadius { get => RoundedCornerRadius_Element.Data; set => RoundedCornerRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RoundedCornerRadius_Element = new();
public UnityEngine.ColorX FillColor { get => FillColor_Element.Data; set => FillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillColor_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public global::System.Single OutlineThickness { get => OutlineThickness_Element.Data; set => OutlineThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineThickness_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> Material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arc", Arc_Element.Data.ToResoniteLinkField());
members.Add("Offset", Offset_Element.Data.ToResoniteLinkField());
members.Add("OuterRadiusRatio", OuterRadiusRatio_Element.Data.ToResoniteLinkField());
members.Add("InnerRadiusRatio", InnerRadiusRatio_Element.Data.ToResoniteLinkField());
members.Add("RoundedCornerRadius", RoundedCornerRadius_Element.Data.ToResoniteLinkField());
members.Add("FillColor", FillColor_Element.Data.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor_Element.Data.ToResoniteLinkField());
members.Add("OutlineThickness", OutlineThickness_Element.Data.ToResoniteLinkField());
members.Add("Material", Material_Element.Data.ToResoniteReference(context));
}

}
}
