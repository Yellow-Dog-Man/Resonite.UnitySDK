
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SyncPlaybackEditor
// Generated on: pátek 13. února 2026 23:23:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SyncPlaybackEditor")]
public partial class SyncPlaybackEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback _playback;
public global::FrooxEngine.IField<global::System.Single> _sliderValue;
public global::FrooxEngine.IField<System.Uri> _loopToggleSprite;
public global::FrooxEngine.FloatTextEditorParser _speedField;
public global::FrooxEngine.UIX.Slider<global::System.Single> _slider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_playback", new ResoniteLink.Reference() { });
members.Add("_sliderValue", new ResoniteLink.Reference() { });
members.Add("_loopToggleSprite", new ResoniteLink.Reference() { });
members.Add("_speedField", new ResoniteLink.Reference() { });
members.Add("_slider", new ResoniteLink.Reference() { });
}

}
}
