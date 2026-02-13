
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyColorDialog
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyColorDialog")]
public partial class LegacyColorDialog : global::FrooxEngine.Component, global::FrooxEngine.IValueSource<UnityEngine.ColorX>, global::FrooxEngine.IValueSource

{
    public global::System.Boolean Realtime;
public global::FrooxEngine.IField<UnityEngine.ColorX> TargetField;
public UnityEngine.ColorX _originalColor;
public global::System.Single _hue;
public global::System.Single _saturation;
public global::System.Single _value;
public global::System.Single _alpha;
public global::Renderite.Shared.ColorProfile _profile;
public global::System.Single _gain;
public global::FrooxEngine.LegacySlider _rSlider;
public global::FrooxEngine.LegacySlider _gSlider;
public global::FrooxEngine.LegacySlider _bSlider;
public global::FrooxEngine.LegacySlider _aSlider;
public global::FrooxEngine.LegacySlider _gainSlider;
public global::FrooxEngine.IField<global::System.Single> _rValue;
public global::FrooxEngine.IField<global::System.Single> _gValue;
public global::FrooxEngine.IField<global::System.Single> _bValue;
public global::FrooxEngine.IField<global::System.Single> _aValue;
public global::FrooxEngine.IField<global::System.Single> _gainValue;
public global::FrooxEngine.ColorWheelTriangleMesh _colorWheelMesh;
public global::FrooxEngine.LegacyButton _okButton;
public global::FrooxEngine.LegacyButton _cancelButton;
public global::FrooxEngine.LegacyUIStyle _style;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Realtime", Realtime.ToResoniteLinkField());
members.Add("TargetField", new ResoniteLink.Reference() { });
members.Add("_originalColor", _originalColor.ToResoniteLinkField());
members.Add("_hue", _hue.ToResoniteLinkField());
members.Add("_saturation", _saturation.ToResoniteLinkField());
members.Add("_value", _value.ToResoniteLinkField());
members.Add("_alpha", _alpha.ToResoniteLinkField());
members.Add("_profile", _profile.ToResoniteLinkField());
members.Add("_gain", _gain.ToResoniteLinkField());
members.Add("_rSlider", new ResoniteLink.Reference() { });
members.Add("_gSlider", new ResoniteLink.Reference() { });
members.Add("_bSlider", new ResoniteLink.Reference() { });
members.Add("_aSlider", new ResoniteLink.Reference() { });
members.Add("_gainSlider", new ResoniteLink.Reference() { });
members.Add("_rValue", new ResoniteLink.Reference() { });
members.Add("_gValue", new ResoniteLink.Reference() { });
members.Add("_bValue", new ResoniteLink.Reference() { });
members.Add("_aValue", new ResoniteLink.Reference() { });
members.Add("_gainValue", new ResoniteLink.Reference() { });
members.Add("_colorWheelMesh", new ResoniteLink.Reference() { });
members.Add("_okButton", new ResoniteLink.Reference() { });
members.Add("_cancelButton", new ResoniteLink.Reference() { });
members.Add("_style", new ResoniteLink.Reference() { });
}

}
}
