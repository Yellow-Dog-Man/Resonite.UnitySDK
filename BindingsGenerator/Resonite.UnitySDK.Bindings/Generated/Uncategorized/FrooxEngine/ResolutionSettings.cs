
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ResolutionSettings
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ResolutionSettings")]
public partial class ResolutionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ResolutionSettings>

{
    public global::System.Boolean Fullscreen { get => Fullscreen_Element.Data; set => Fullscreen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Fullscreen_Element = new();
public UnityEngine.Vector2Int WindowResolution { get => WindowResolution_Element.Data; set => WindowResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> WindowResolution_Element = new();
public UnityEngine.Vector2Int FullscreenResolution { get => FullscreenResolution_Element.Data; set => FullscreenResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> FullscreenResolution_Element = new();
public UnityEngine.Vector2Int CommitedWindowResolution { get => CommitedWindowResolution_Element.Data; set => CommitedWindowResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> CommitedWindowResolution_Element = new();
public UnityEngine.Vector2Int CommitedFullscreenResolution { get => CommitedFullscreenResolution_Element.Data; set => CommitedFullscreenResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> CommitedFullscreenResolution_Element = new();
public global::System.Boolean NeedsToApplyResolution { get => NeedsToApplyResolution_Element.Data; set => NeedsToApplyResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NeedsToApplyResolution_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Fullscreen", Fullscreen_Element.ToLinkField(context));
members.Add("WindowResolution", WindowResolution_Element.ToLinkField(context));
members.Add("FullscreenResolution", FullscreenResolution_Element.ToLinkField(context));
members.Add("CommitedWindowResolution", CommitedWindowResolution_Element.ToLinkField(context));
members.Add("CommitedFullscreenResolution", CommitedFullscreenResolution_Element.ToLinkField(context));
members.Add("NeedsToApplyResolution", NeedsToApplyResolution_Element.ToLinkField(context));
}

}
}
