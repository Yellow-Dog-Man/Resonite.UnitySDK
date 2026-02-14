
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchButton
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchButton")]
public partial class TouchButton : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButton

{
    public global::System.Boolean IsPressed;
public global::System.Boolean IsHovering;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean EditModeOnly;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;
public global::FrooxEngine.VibratePreset BeginPressVibration;
public global::FrooxEngine.VibratePreset PressVibration;
public global::FrooxEngine.VibratePreset HoverVibration;
public global::FrooxEngine.IField<global::System.String> Label;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsPressed", IsPressed.ToResoniteLinkField());
members.Add("IsHovering", IsHovering.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("BeginPressVibration", BeginPressVibration.ToResoniteLinkField());
members.Add("PressVibration", PressVibration.ToResoniteLinkField());
members.Add("HoverVibration", HoverVibration.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
}

}
}
