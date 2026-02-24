
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenModeController
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenModeController")]
public partial class ScreenModeController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserspaceRadiantDash _dash;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _muteSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _unmuteSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _startTalkSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _stopTalkSound;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_dash", _dash.ToResoniteReference(context));
members.Add("_muteSound", _muteSound.ToResoniteReference(context));
members.Add("_unmuteSound", _unmuteSound.ToResoniteReference(context));
members.Add("_startTalkSound", _startTalkSound.ToResoniteReference(context));
members.Add("_stopTalkSound", _stopTalkSound.ToResoniteReference(context));
}

}
}
