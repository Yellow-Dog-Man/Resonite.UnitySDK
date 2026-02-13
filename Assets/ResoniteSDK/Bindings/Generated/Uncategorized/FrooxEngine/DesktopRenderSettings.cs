
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopRenderSettings
// Generated on: pátek 13. února 2026 5:52:30
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopRenderSettings")]
public partial class DesktopRenderSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DesktopRenderSettings>

{
    public global::System.Single FieldOfView;
public global::System.Boolean SprintFieldOfViewZoom;
public global::System.Boolean VSync;
public global::System.Boolean LimitFramerateWhenUnfocused;
public global::System.Int32 MaximumBackgroundFramerate;
public global::System.Boolean FramePacingOptionsEnabled;
public global::System.Boolean BackgroundFramerateEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("SprintFieldOfViewZoom", SprintFieldOfViewZoom.ToResoniteLinkField());
members.Add("VSync", VSync.ToResoniteLinkField());
members.Add("LimitFramerateWhenUnfocused", LimitFramerateWhenUnfocused.ToResoniteLinkField());
members.Add("MaximumBackgroundFramerate", MaximumBackgroundFramerate.ToResoniteLinkField());
members.Add("FramePacingOptionsEnabled", FramePacingOptionsEnabled.ToResoniteLinkField());
members.Add("BackgroundFramerateEnabled", BackgroundFramerateEnabled.ToResoniteLinkField());
}

}
}
