
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonLoopSet
// Generated on: pátek 13. února 2026 23:21:38
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonLoopSet")]
public partial class ButtonLoopSet : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.IButtonHoverReceiver

{
    public global::FrooxEngine.IPlayable Playback;
public global::FrooxEngine.LoopSetOptions OnPress;
public global::FrooxEngine.LoopSetOptions OnRelease;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Playback", new ResoniteLink.Reference() { });
members.Add("OnPress", OnPress.ToResoniteLinkField());
members.Add("OnRelease", OnRelease.ToResoniteLinkField());
}

}
}
