
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.OutlinedArc
// Generated on: pátek 13. února 2026 23:22:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.OutlinedArc")]
public partial class OutlinedArc : global::FrooxEngine.UIX.Graphic, global::FrooxEngine.UIX.ILayoutElement

{
    public global::System.Single Arc;
public global::System.Single Offset;
public global::System.Single OuterRadiusRatio;
public global::System.Single InnerRadiusRatio;
public global::System.Single RoundedCornerRadius;
public UnityEngine.ColorX FillColor;
public UnityEngine.ColorX OutlineColor;
public global::System.Single OutlineThickness;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("OuterRadiusRatio", OuterRadiusRatio.ToResoniteLinkField());
members.Add("InnerRadiusRatio", InnerRadiusRatio.ToResoniteLinkField());
members.Add("RoundedCornerRadius", RoundedCornerRadius.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("OutlineThickness", OutlineThickness.ToResoniteLinkField());
members.Add("Material", new ResoniteLink.Reference() { });
}

}
}
