
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyUIStyle
// Generated on: čtvrtek 19. února 2026 7:58:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyUIStyle")]
public partial class LegacyUIStyle : global::FrooxEngine.Component

{
    public UnityEngine.ColorX Color;
public UnityEngine.ColorX UserParentedColor;
public UnityEngine.ColorX PrivateColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("UserParentedColor", UserParentedColor.ToResoniteLinkField());
members.Add("PrivateColor", PrivateColor.ToResoniteLinkField());
}

}
}
