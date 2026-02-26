
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlideLocomotion
// Generated on: čtvrtek 26. února 2026 10:03:40
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlideLocomotion")]
public partial class SlideLocomotion : global::FrooxEngine.NoclipLocomotion

{
    public global::System.Single MaxSnapDistance { get => MaxSnapDistance_Element.Data; set => MaxSnapDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSnapDistance_Element = new();
public global::System.Single SnapCheckOffset { get => SnapCheckOffset_Element.Data; set => SnapCheckOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapCheckOffset_Element = new();
public global::System.Single SnapMinObjectSize { get => SnapMinObjectSize_Element.Data; set => SnapMinObjectSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapMinObjectSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSnapDistance", MaxSnapDistance_Element.Data.ToResoniteLinkField());
members.Add("SnapCheckOffset", SnapCheckOffset_Element.Data.ToResoniteLinkField());
members.Add("SnapMinObjectSize", SnapMinObjectSize_Element.Data.ToResoniteLinkField());
}

}
}
