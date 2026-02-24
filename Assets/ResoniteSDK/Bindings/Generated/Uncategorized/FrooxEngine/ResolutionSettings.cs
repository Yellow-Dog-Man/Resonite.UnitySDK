
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ResolutionSettings
// Generated on: úterý 24. února 2026 18:20:28
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ResolutionSettings")]
public partial class ResolutionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ResolutionSettings>

{
    public global::System.Boolean Fullscreen;
public UnityEngine.Vector2Int WindowResolution;
public UnityEngine.Vector2Int FullscreenResolution;
public UnityEngine.Vector2Int CommitedWindowResolution;
public UnityEngine.Vector2Int CommitedFullscreenResolution;
public global::System.Boolean NeedsToApplyResolution;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Fullscreen", Fullscreen.ToResoniteLinkField());
members.Add("WindowResolution", WindowResolution.ToResoniteLinkField());
members.Add("FullscreenResolution", FullscreenResolution.ToResoniteLinkField());
members.Add("CommitedWindowResolution", CommitedWindowResolution.ToResoniteLinkField());
members.Add("CommitedFullscreenResolution", CommitedFullscreenResolution.ToResoniteLinkField());
members.Add("NeedsToApplyResolution", NeedsToApplyResolution.ToResoniteLinkField());
}

}
}
