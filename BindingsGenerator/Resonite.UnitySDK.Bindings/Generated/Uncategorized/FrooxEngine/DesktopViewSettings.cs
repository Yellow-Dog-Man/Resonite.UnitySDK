
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopViewSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean FollowCursor { get => FollowCursor_Element.Data; set => FollowCursor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FollowCursor_Element = new();
public global::System.Single Brightness { get => Brightness_Element.Data; set => Brightness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Brightness_Element = new();
public global::System.Single Opacity { get => Opacity_Element.Data; set => Opacity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Opacity_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FollowCursor", FollowCursor_Element.ToLinkField(context));
members.Add("Brightness", Brightness_Element.ToLinkField(context));
members.Add("Opacity", Opacity_Element.ToLinkField(context));
}

}
}
