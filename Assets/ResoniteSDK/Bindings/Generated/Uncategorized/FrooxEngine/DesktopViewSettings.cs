
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopViewSettings
// Generated on: sobota 14. února 2026 8:58:42
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
