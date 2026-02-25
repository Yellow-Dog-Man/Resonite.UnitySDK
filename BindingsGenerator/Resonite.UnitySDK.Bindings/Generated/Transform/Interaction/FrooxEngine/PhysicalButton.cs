
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhysicalButton
// Generated on: středa 25. února 2026 16:14:31
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
    public UnityEngine.Vector3 PressAxis;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean EditModeOnly;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;
public global::System.Boolean __legacyActiveUserRootOnly;
public global::System.Single PressDepth;
public global::System.Single PressThreshold;
public global::System.Single ReleaseThreshold;
public global::System.Boolean IsPressed;
public global::System.Boolean IsHovering;
public global::System.Boolean IsHolding;
public global::System.Boolean IsPressedOrHolding;
public global::System.Boolean Hold;
public global::System.Single HoldDepthRatio;
public global::FrooxEngine.VibratePreset BeginPressVibration;
public global::FrooxEngine.VibratePreset PressVibration;
public global::FrooxEngine.VibratePreset HoverVibration;
public global::FrooxEngine.IField<global::System.String> Label;
public global::System.Single _currentPressingDepth;
public UnityEngine.Vector3 _buttonOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonPosition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PressAxis", PressAxis.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly.ToResoniteLinkField());
members.Add("PressDepth", PressDepth.ToResoniteLinkField());
members.Add("PressThreshold", PressThreshold.ToResoniteLinkField());
members.Add("ReleaseThreshold", ReleaseThreshold.ToResoniteLinkField());
members.Add("IsPressed", IsPressed.ToResoniteLinkField());
members.Add("IsHovering", IsHovering.ToResoniteLinkField());
members.Add("IsHolding", IsHolding.ToResoniteLinkField());
members.Add("IsPressedOrHolding", IsPressedOrHolding.ToResoniteLinkField());
members.Add("Hold", Hold.ToResoniteLinkField());
members.Add("HoldDepthRatio", HoldDepthRatio.ToResoniteLinkField());
members.Add("BeginPressVibration", BeginPressVibration.ToResoniteLinkField());
members.Add("PressVibration", PressVibration.ToResoniteLinkField());
members.Add("HoverVibration", HoverVibration.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
members.Add("_currentPressingDepth", _currentPressingDepth.ToResoniteLinkField());
members.Add("_buttonOffset", _buttonOffset.ToResoniteLinkField());
members.Add("_buttonPosition", _buttonPosition.ToResoniteReference(context));
}

}
}
