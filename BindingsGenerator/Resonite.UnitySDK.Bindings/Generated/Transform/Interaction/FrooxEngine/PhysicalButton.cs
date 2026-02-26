
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhysicalButton
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhysicalButton")]
public partial class PhysicalButton : global::FrooxEngine.Component, global::FrooxEngine.IButton, global::FrooxEngine.ITouchable

{
    public UnityEngine.Vector3 PressAxis { get => PressAxis_Element.Data; set => PressAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PressAxis_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter { get => ActiveUserFilter_Element.Data; set => ActiveUserFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ActiveUserHandling>, global::FrooxEngine.ActiveUserHandling> ActiveUserFilter_Element = new();
public global::System.Boolean __legacyActiveUserRootOnly { get => __legacyActiveUserRootOnly_Element.Data; set => __legacyActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyActiveUserRootOnly_Element = new();
public global::System.Single PressDepth { get => PressDepth_Element.Data; set => PressDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PressDepth_Element = new();
public global::System.Single PressThreshold { get => PressThreshold_Element.Data; set => PressThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PressThreshold_Element = new();
public global::System.Single ReleaseThreshold { get => ReleaseThreshold_Element.Data; set => ReleaseThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ReleaseThreshold_Element = new();
public global::System.Boolean IsPressed { get => IsPressed_Element.Data; set => IsPressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPressed_Element = new();
public global::System.Boolean IsHovering { get => IsHovering_Element.Data; set => IsHovering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHovering_Element = new();
public global::System.Boolean IsHolding { get => IsHolding_Element.Data; set => IsHolding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHolding_Element = new();
public global::System.Boolean IsPressedOrHolding { get => IsPressedOrHolding_Element.Data; set => IsPressedOrHolding_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsPressedOrHolding_Element = new();
public global::System.Boolean Hold { get => Hold_Element.Data; set => Hold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Hold_Element = new();
public global::System.Single HoldDepthRatio { get => HoldDepthRatio_Element.Data; set => HoldDepthRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoldDepthRatio_Element = new();
public global::FrooxEngine.VibratePreset BeginPressVibration { get => BeginPressVibration_Element.Data; set => BeginPressVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> BeginPressVibration_Element = new();
public global::FrooxEngine.VibratePreset PressVibration { get => PressVibration_Element.Data; set => PressVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> PressVibration_Element = new();
public global::FrooxEngine.VibratePreset HoverVibration { get => HoverVibration_Element.Data; set => HoverVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> HoverVibration_Element = new();
public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();
public global::System.Single _currentPressingDepth { get => _currentPressingDepth_Element.Data; set => _currentPressingDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _currentPressingDepth_Element = new();
public UnityEngine.Vector3 _buttonOffset { get => _buttonOffset_Element.Data; set => _buttonOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _buttonOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonPosition { get => _buttonPosition_Element.Data; set => _buttonPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _buttonPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PressAxis", PressAxis_Element.Data.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly_Element.Data.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter_Element.Data.ToResoniteLinkField());
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly_Element.Data.ToResoniteLinkField());
members.Add("PressDepth", PressDepth_Element.Data.ToResoniteLinkField());
members.Add("PressThreshold", PressThreshold_Element.Data.ToResoniteLinkField());
members.Add("ReleaseThreshold", ReleaseThreshold_Element.Data.ToResoniteLinkField());
members.Add("IsPressed", IsPressed_Element.Data.ToResoniteLinkField());
members.Add("IsHovering", IsHovering_Element.Data.ToResoniteLinkField());
members.Add("IsHolding", IsHolding_Element.Data.ToResoniteLinkField());
members.Add("IsPressedOrHolding", IsPressedOrHolding_Element.Data.ToResoniteLinkField());
members.Add("Hold", Hold_Element.Data.ToResoniteLinkField());
members.Add("HoldDepthRatio", HoldDepthRatio_Element.Data.ToResoniteLinkField());
members.Add("BeginPressVibration", BeginPressVibration_Element.Data.ToResoniteLinkField());
members.Add("PressVibration", PressVibration_Element.Data.ToResoniteLinkField());
members.Add("HoverVibration", HoverVibration_Element.Data.ToResoniteLinkField());
members.Add("Label", Label_Element.Data.ToResoniteReference(context));
members.Add("_currentPressingDepth", _currentPressingDepth_Element.Data.ToResoniteLinkField());
members.Add("_buttonOffset", _buttonOffset_Element.Data.ToResoniteLinkField());
members.Add("_buttonPosition", _buttonPosition_Element.Data.ToResoniteReference(context));
}

}
}
