
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.LayoutElement
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.LayoutElement")]
public partial class LayoutElement : global::FrooxEngine.UIX.UIComputeComponent, global::FrooxEngine.UIX.ILayoutElement

{
    public global::System.Single MinWidth;
public global::System.Single PreferredWidth;
public global::System.Single FlexibleWidth;
public global::System.Single MinHeight;
public global::System.Single PreferredHeight;
public global::System.Single FlexibleHeight;
public global::System.Single Area;
public global::System.Int32 Priority;
public global::System.Boolean UseZeroMetrics;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinWidth", MinWidth.ToResoniteLinkField());
members.Add("PreferredWidth", PreferredWidth.ToResoniteLinkField());
members.Add("FlexibleWidth", FlexibleWidth.ToResoniteLinkField());
members.Add("MinHeight", MinHeight.ToResoniteLinkField());
members.Add("PreferredHeight", PreferredHeight.ToResoniteLinkField());
members.Add("FlexibleHeight", FlexibleHeight.ToResoniteLinkField());
members.Add("Area", Area.ToResoniteLinkField());
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("UseZeroMetrics", UseZeroMetrics.ToResoniteLinkField());
}

}
}
