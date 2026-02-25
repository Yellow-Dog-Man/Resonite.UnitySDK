
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchToggle
// Generated on: středa 25. února 2026 16:14:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchToggle")]
public partial class TouchToggle : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean State;
public global::FrooxEngine.TouchEventType EventType;
public global::FrooxEngine.EventState ToggleEvent;
public global::FrooxEngine.EventState OnEvent;
public global::FrooxEngine.EventState OffEvent;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::FrooxEngine.VibratePreset Vibrate;
public global::System.Boolean EditModeOnly;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;
public global::System.Boolean __legacyActiveUserRootOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State.ToResoniteLinkField());
members.Add("EventType", EventType.ToResoniteLinkField());
members.Add("ToggleEvent", ToggleEvent.ToResoniteLinkField());
members.Add("OnEvent", OnEvent.ToResoniteLinkField());
members.Add("OffEvent", OffEvent.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("Vibrate", Vibrate.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly.ToResoniteLinkField());
}

}
}
