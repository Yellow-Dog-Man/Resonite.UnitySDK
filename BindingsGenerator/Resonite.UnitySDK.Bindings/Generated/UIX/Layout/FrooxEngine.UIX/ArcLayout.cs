
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ArcLayout
// Generated on: čtvrtek 26. února 2026 15:08:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ArcLayout")]
public partial class ArcLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single Arc { get => Arc_Element.Data; set => Arc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Arc_Element = new();
public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::System.Single Separation { get => Separation_Element.Data; set => Separation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Separation_Element = new();
public global::System.Boolean CenterAtSeparation { get => CenterAtSeparation_Element.Data; set => CenterAtSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CenterAtSeparation_Element = new();
public global::System.Boolean ProportionalSize { get => ProportionalSize_Element.Data; set => ProportionalSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProportionalSize_Element = new();
public global::FrooxEngine.UIX.ArcLayout.Direction ItemDirection { get => ItemDirection_Element.Data; set => ItemDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.ArcLayout.Direction>, global::FrooxEngine.UIX.ArcLayout.Direction> ItemDirection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arc", Arc_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Separation", Separation_Element.ToLinkField(context));
members.Add("CenterAtSeparation", CenterAtSeparation_Element.ToLinkField(context));
members.Add("ProportionalSize", ProportionalSize_Element.ToLinkField(context));
members.Add("ItemDirection", ItemDirection_Element.ToLinkField(context));
}

}
}
