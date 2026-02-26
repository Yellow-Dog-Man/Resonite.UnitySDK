
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyColorDialog
// Generated on: čtvrtek 26. února 2026 10:04:42
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyColorDialog")]
public partial class LegacyColorDialog : global::FrooxEngine.Component, global::FrooxEngine.IValueSource<UnityEngine.ColorX>, global::FrooxEngine.IValueSource

{
    public global::System.Boolean Realtime { get => Realtime_Element.Data; set => Realtime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Realtime_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>> TargetField_Element = new();
public UnityEngine.ColorX _originalColor { get => _originalColor_Element.Data; set => _originalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _originalColor_Element = new();
public global::System.Single _hue { get => _hue_Element.Data; set => _hue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _hue_Element = new();
public global::System.Single _saturation { get => _saturation_Element.Data; set => _saturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _saturation_Element = new();
public global::System.Single _value { get => _value_Element.Data; set => _value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _value_Element = new();
public global::System.Single _alpha { get => _alpha_Element.Data; set => _alpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _alpha_Element = new();
public global::Renderite.Shared.ColorProfile _profile { get => _profile_Element.Data; set => _profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> _profile_Element = new();
public global::System.Single _gain { get => _gain_Element.Data; set => _gain_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _gain_Element = new();
public global::FrooxEngine.LegacySlider _rSlider { get => _rSlider_Element.Data; set => _rSlider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _rSlider_Element = new();
public global::FrooxEngine.LegacySlider _gSlider { get => _gSlider_Element.Data; set => _gSlider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _gSlider_Element = new();
public global::FrooxEngine.LegacySlider _bSlider { get => _bSlider_Element.Data; set => _bSlider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _bSlider_Element = new();
public global::FrooxEngine.LegacySlider _aSlider { get => _aSlider_Element.Data; set => _aSlider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _aSlider_Element = new();
public global::FrooxEngine.LegacySlider _gainSlider { get => _gainSlider_Element.Data; set => _gainSlider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySlider>, global::FrooxEngine.LegacySlider> _gainSlider_Element = new();
public global::FrooxEngine.IField<global::System.Single> _rValue { get => _rValue_Element.Data; set => _rValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _rValue_Element = new();
public global::FrooxEngine.IField<global::System.Single> _gValue { get => _gValue_Element.Data; set => _gValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _gValue_Element = new();
public global::FrooxEngine.IField<global::System.Single> _bValue { get => _bValue_Element.Data; set => _bValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _bValue_Element = new();
public global::FrooxEngine.IField<global::System.Single> _aValue { get => _aValue_Element.Data; set => _aValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _aValue_Element = new();
public global::FrooxEngine.IField<global::System.Single> _gainValue { get => _gainValue_Element.Data; set => _gainValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _gainValue_Element = new();
public global::FrooxEngine.ColorWheelTriangleMesh _colorWheelMesh { get => _colorWheelMesh_Element.Data; set => _colorWheelMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ColorWheelTriangleMesh>, global::FrooxEngine.ColorWheelTriangleMesh> _colorWheelMesh_Element = new();
public global::FrooxEngine.LegacyButton _okButton { get => _okButton_Element.Data; set => _okButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyButton>, global::FrooxEngine.LegacyButton> _okButton_Element = new();
public global::FrooxEngine.LegacyButton _cancelButton { get => _cancelButton_Element.Data; set => _cancelButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyButton>, global::FrooxEngine.LegacyButton> _cancelButton_Element = new();
public global::FrooxEngine.LegacyUIStyle _style { get => _style_Element.Data; set => _style_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyUIStyle>, global::FrooxEngine.LegacyUIStyle> _style_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Realtime", Realtime_Element.Data.ToResoniteLinkField());
members.Add("TargetField", TargetField_Element.Data.ToResoniteReference(context));
members.Add("_originalColor", _originalColor_Element.Data.ToResoniteLinkField());
members.Add("_hue", _hue_Element.Data.ToResoniteLinkField());
members.Add("_saturation", _saturation_Element.Data.ToResoniteLinkField());
members.Add("_value", _value_Element.Data.ToResoniteLinkField());
members.Add("_alpha", _alpha_Element.Data.ToResoniteLinkField());
members.Add("_profile", _profile_Element.Data.ToResoniteLinkField());
members.Add("_gain", _gain_Element.Data.ToResoniteLinkField());
members.Add("_rSlider", _rSlider_Element.Data.ToResoniteReference(context));
members.Add("_gSlider", _gSlider_Element.Data.ToResoniteReference(context));
members.Add("_bSlider", _bSlider_Element.Data.ToResoniteReference(context));
members.Add("_aSlider", _aSlider_Element.Data.ToResoniteReference(context));
members.Add("_gainSlider", _gainSlider_Element.Data.ToResoniteReference(context));
members.Add("_rValue", _rValue_Element.Data.ToResoniteReference(context));
members.Add("_gValue", _gValue_Element.Data.ToResoniteReference(context));
members.Add("_bValue", _bValue_Element.Data.ToResoniteReference(context));
members.Add("_aValue", _aValue_Element.Data.ToResoniteReference(context));
members.Add("_gainValue", _gainValue_Element.Data.ToResoniteReference(context));
members.Add("_colorWheelMesh", _colorWheelMesh_Element.Data.ToResoniteReference(context));
members.Add("_okButton", _okButton_Element.Data.ToResoniteReference(context));
members.Add("_cancelButton", _cancelButton_Element.Data.ToResoniteReference(context));
members.Add("_style", _style_Element.Data.ToResoniteReference(context));
}

}
}
