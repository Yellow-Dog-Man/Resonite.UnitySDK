
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DisplayInfo
// Generated on: čtvrtek 19. února 2026 7:58:58
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DisplayInfo")]
public partial class DisplayInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DisplayIndex;
public UnityEngine.Vector2Int Resolution;
public UnityEngine.Vector2Int Offset;
public UnityEngine.Vector2 DPI;
public global::System.Double RefreshRate;
public global::Renderite.Shared.RectOrientation Orientation;
public global::System.Boolean IsPrimary;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayIndex", DisplayIndex.ToResoniteLinkField());
members.Add("Resolution", Resolution.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("DPI", DPI.ToResoniteLinkField());
members.Add("RefreshRate", RefreshRate.ToResoniteLinkField());
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("IsPrimary", IsPrimary.ToResoniteLinkField());
}

}
}
