
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ArcLayout
// Generated on: čtvrtek 19. února 2026 8:00:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ArcLayout")]
public partial class ArcLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single Arc;
public global::System.Single Offset;
public global::System.Single Separation;
public global::System.Boolean CenterAtSeparation;
public global::System.Boolean ProportionalSize;
public global::FrooxEngine.UIX.ArcLayout.Direction ItemDirection;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Separation", Separation.ToResoniteLinkField());
members.Add("CenterAtSeparation", CenterAtSeparation.ToResoniteLinkField());
members.Add("ProportionalSize", ProportionalSize.ToResoniteLinkField());
members.Add("ItemDirection", ItemDirection.ToResoniteLinkField());
}

}
}
