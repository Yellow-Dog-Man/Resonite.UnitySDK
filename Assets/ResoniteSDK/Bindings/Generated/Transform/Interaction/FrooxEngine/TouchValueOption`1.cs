
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchValueOption<>
// Generated on: úterý 24. února 2026 18:20:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchValueOption<>")]
public partial class TouchValueOption<T> : global::FrooxEngine.Component, global::FrooxEngine.ITouchable
	

{
    public global::FrooxEngine.IField<T> Target;
public T Value;
public global::FrooxEngine.IField<global::System.Boolean> ActiveIndicator;
public global::FrooxEngine.IField<global::System.Boolean> HoverIndicator;
public global::FrooxEngine.VibratePreset HoverVibrate;
public global::FrooxEngine.VibratePreset Vibrate;
public global::System.Boolean SetOnTouchBegin;
public global::System.Boolean SetOnTouchStay;
public global::System.Boolean SetOnTouchEnd;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::System.Boolean EditModeOnly;
public global::System.Boolean ActiveUserRootOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Value", Value.ToResoniteLinkField());
members.Add("ActiveIndicator", ActiveIndicator.ToResoniteReference(context));
members.Add("HoverIndicator", HoverIndicator.ToResoniteReference(context));
members.Add("HoverVibrate", HoverVibrate.ToResoniteLinkField());
members.Add("Vibrate", Vibrate.ToResoniteLinkField());
members.Add("SetOnTouchBegin", SetOnTouchBegin.ToResoniteLinkField());
members.Add("SetOnTouchStay", SetOnTouchStay.ToResoniteLinkField());
members.Add("SetOnTouchEnd", SetOnTouchEnd.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("ActiveUserRootOnly", ActiveUserRootOnly.ToResoniteLinkField());
}

}
}
