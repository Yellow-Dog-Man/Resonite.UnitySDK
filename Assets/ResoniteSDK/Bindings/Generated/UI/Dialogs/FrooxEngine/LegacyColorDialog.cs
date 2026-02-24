
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyColorDialog
// Generated on: úterý 24. února 2026 18:20:16
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Realtime", Realtime.ToResoniteLinkField());
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("_originalColor", _originalColor.ToResoniteLinkField());
members.Add("_hue", _hue.ToResoniteLinkField());
members.Add("_saturation", _saturation.ToResoniteLinkField());
members.Add("_value", _value.ToResoniteLinkField());
members.Add("_alpha", _alpha.ToResoniteLinkField());
members.Add("_profile", _profile.ToResoniteLinkField());
members.Add("_gain", _gain.ToResoniteLinkField());
members.Add("_rSlider", _rSlider.ToResoniteReference(context));
members.Add("_gSlider", _gSlider.ToResoniteReference(context));
members.Add("_bSlider", _bSlider.ToResoniteReference(context));
members.Add("_aSlider", _aSlider.ToResoniteReference(context));
members.Add("_gainSlider", _gainSlider.ToResoniteReference(context));
members.Add("_rValue", _rValue.ToResoniteReference(context));
members.Add("_gValue", _gValue.ToResoniteReference(context));
members.Add("_bValue", _bValue.ToResoniteReference(context));
members.Add("_aValue", _aValue.ToResoniteReference(context));
members.Add("_gainValue", _gainValue.ToResoniteReference(context));
members.Add("_colorWheelMesh", _colorWheelMesh.ToResoniteReference(context));
members.Add("_okButton", _okButton.ToResoniteReference(context));
members.Add("_cancelButton", _cancelButton.ToResoniteReference(context));
members.Add("_style", _style.ToResoniteReference(context));
}

}
}
