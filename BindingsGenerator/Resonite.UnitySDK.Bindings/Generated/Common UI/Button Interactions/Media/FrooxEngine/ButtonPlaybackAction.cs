
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonPlaybackAction
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonPlaybackAction")]
public partial class ButtonPlaybackAction : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.IPlayable Playback { get => Playback_Element.Data; set => Playback_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPlayable>, global::FrooxEngine.IPlayable> Playback_Element = new();
public global::FrooxEngine.PlaybackAction OnHover { get => OnHover_Element.Data; set => OnHover_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PlaybackAction>, global::FrooxEngine.PlaybackAction> OnHover_Element = new();
public global::FrooxEngine.PlaybackAction OnLeave { get => OnLeave_Element.Data; set => OnLeave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PlaybackAction>, global::FrooxEngine.PlaybackAction> OnLeave_Element = new();
public global::FrooxEngine.PlaybackAction OnPress { get => OnPress_Element.Data; set => OnPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PlaybackAction>, global::FrooxEngine.PlaybackAction> OnPress_Element = new();
public global::FrooxEngine.PlaybackAction OnRelease { get => OnRelease_Element.Data; set => OnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PlaybackAction>, global::FrooxEngine.PlaybackAction> OnRelease_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playback", Playback_Element.ToLinkReference(context));
members.Add("OnHover", OnHover_Element.ToLinkField(context));
members.Add("OnLeave", OnLeave_Element.ToLinkField(context));
members.Add("OnPress", OnPress_Element.ToLinkField(context));
members.Add("OnRelease", OnRelease_Element.ToLinkField(context));
}

}
}
