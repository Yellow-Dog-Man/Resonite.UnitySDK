
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SyncPlaybackEditor
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SyncPlaybackEditor")]
public partial class SyncPlaybackEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncPlayback _playback { get => _playback_Element.Data; set => _playback_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncPlayback>, global::FrooxEngine.SyncPlayback> _playback_Element = new();
public global::FrooxEngine.IField<global::System.Single> _sliderValue { get => _sliderValue_Element.Data; set => _sliderValue_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _sliderValue_Element = new();
public global::FrooxEngine.IField<System.Uri> _loopToggleSprite { get => _loopToggleSprite_Element.Data; set => _loopToggleSprite_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> _loopToggleSprite_Element = new();
public global::FrooxEngine.FloatTextEditorParser _speedField { get => _speedField_Element.Data; set => _speedField_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _speedField_Element = new();
public global::FrooxEngine.UIX.Slider<global::System.Single> _slider { get => _slider_Element.Data; set => _slider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _slider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_playback", _playback_Element.ToLinkReference(context));
members.Add("_sliderValue", _sliderValue_Element.ToLinkReference(context));
members.Add("_loopToggleSprite", _loopToggleSprite_Element.ToLinkReference(context));
members.Add("_speedField", _speedField_Element.ToLinkReference(context));
members.Add("_slider", _slider_Element.ToLinkReference(context));
}

}
}
