
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonPlaybackAction
// Generated on: úterý 24. února 2026 18:17:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonPlaybackAction")]
public partial class ButtonPlaybackAction : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.IPlayable Playback;
public global::FrooxEngine.PlaybackAction OnHover;
public global::FrooxEngine.PlaybackAction OnLeave;
public global::FrooxEngine.PlaybackAction OnPress;
public global::FrooxEngine.PlaybackAction OnRelease;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playback", Playback.ToResoniteReference(context));
members.Add("OnHover", OnHover.ToResoniteLinkField());
members.Add("OnLeave", OnLeave.ToResoniteLinkField());
members.Add("OnPress", OnPress.ToResoniteLinkField());
members.Add("OnRelease", OnRelease.ToResoniteLinkField());
}

}
}
