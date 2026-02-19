
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopViewSettings
// Generated on: čtvrtek 19. února 2026 8:00:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopViewSettings")]
public partial class DesktopViewSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DesktopViewSettings>

{
    public global::System.Boolean FollowCursor;
public global::System.Single Brightness;
public global::System.Single Opacity;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FollowCursor", FollowCursor.ToResoniteLinkField());
members.Add("Brightness", Brightness.ToResoniteLinkField());
members.Add("Opacity", Opacity.ToResoniteLinkField());
}

}
}
