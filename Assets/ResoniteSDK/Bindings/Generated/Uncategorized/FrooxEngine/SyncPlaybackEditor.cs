
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SyncPlaybackEditor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SyncPlaybackEditor")]
public partial class SyncPlaybackEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback _playback;
public global::FrooxEngine.IField<global::System.Single> _sliderValue;
public global::FrooxEngine.IField<System.Uri> _loopToggleSprite;
public global::FrooxEngine.FloatTextEditorParser _speedField;
public global::FrooxEngine.UIX.Slider<global::System.Single> _slider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_playback", _playback.ToResoniteReference(context));
members.Add("_sliderValue", _sliderValue.ToResoniteReference(context));
members.Add("_loopToggleSprite", _loopToggleSprite.ToResoniteReference(context));
members.Add("_speedField", _speedField.ToResoniteReference(context));
members.Add("_slider", _slider.ToResoniteReference(context));
}

}
}
