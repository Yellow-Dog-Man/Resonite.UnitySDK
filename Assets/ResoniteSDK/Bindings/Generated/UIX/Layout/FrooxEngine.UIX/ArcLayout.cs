
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ArcLayout
// Generated on: pátek 13. února 2026 5:52:15
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ArcLayout")]
public partial class ArcLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::System.Single Arc;
public global::System.Single Offset;
public global::System.Single Separation;
public global::System.Boolean CenterAtSeparation;
public global::System.Boolean ProportionalSize;
public global::FrooxEngine.UIX.ArcLayout.Direction ItemDirection;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Separation", Separation.ToResoniteLinkField());
members.Add("CenterAtSeparation", CenterAtSeparation.ToResoniteLinkField());
members.Add("ProportionalSize", ProportionalSize.ToResoniteLinkField());
members.Add("ItemDirection", ItemDirection.ToResoniteLinkField());
}

}
}
