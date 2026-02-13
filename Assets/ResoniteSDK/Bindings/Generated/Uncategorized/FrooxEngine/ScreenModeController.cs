
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenModeController
// Generated on: pátek 13. února 2026 23:23:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenModeController")]
public partial class ScreenModeController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserspaceRadiantDash _dash;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _muteSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _unmuteSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _startTalkSound;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _stopTalkSound;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_dash", new ResoniteLink.Reference() { });
members.Add("_muteSound", new ResoniteLink.Reference() { });
members.Add("_unmuteSound", new ResoniteLink.Reference() { });
members.Add("_startTalkSound", new ResoniteLink.Reference() { });
members.Add("_stopTalkSound", new ResoniteLink.Reference() { });
}

}
}
