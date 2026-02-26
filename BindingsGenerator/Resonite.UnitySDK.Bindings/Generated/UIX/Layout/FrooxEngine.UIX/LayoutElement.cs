
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.LayoutElement
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.LayoutElement")]
public partial class LayoutElement : global::FrooxEngine.UIX.UIComputeComponent, global::FrooxEngine.UIX.ILayoutElement

{
    public global::System.Single MinWidth { get => MinWidth_Element.Data; set => MinWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinWidth_Element = new();
public global::System.Single PreferredWidth { get => PreferredWidth_Element.Data; set => PreferredWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PreferredWidth_Element = new();
public global::System.Single FlexibleWidth { get => FlexibleWidth_Element.Data; set => FlexibleWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FlexibleWidth_Element = new();
public global::System.Single MinHeight { get => MinHeight_Element.Data; set => MinHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinHeight_Element = new();
public global::System.Single PreferredHeight { get => PreferredHeight_Element.Data; set => PreferredHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PreferredHeight_Element = new();
public global::System.Single FlexibleHeight { get => FlexibleHeight_Element.Data; set => FlexibleHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FlexibleHeight_Element = new();
public global::System.Single Area { get => Area_Element.Data; set => Area_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Area_Element = new();
public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();
public global::System.Boolean UseZeroMetrics { get => UseZeroMetrics_Element.Data; set => UseZeroMetrics_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseZeroMetrics_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinWidth", MinWidth_Element.ToLinkField(context));
members.Add("PreferredWidth", PreferredWidth_Element.ToLinkField(context));
members.Add("FlexibleWidth", FlexibleWidth_Element.ToLinkField(context));
members.Add("MinHeight", MinHeight_Element.ToLinkField(context));
members.Add("PreferredHeight", PreferredHeight_Element.ToLinkField(context));
members.Add("FlexibleHeight", FlexibleHeight_Element.ToLinkField(context));
members.Add("Area", Area_Element.ToLinkField(context));
members.Add("Priority", Priority_Element.ToLinkField(context));
members.Add("UseZeroMetrics", UseZeroMetrics_Element.ToLinkField(context));
}

}
}
