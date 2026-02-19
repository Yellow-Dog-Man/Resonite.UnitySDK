
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchableData
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchableData")]
public partial class TouchableData : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean Hovering;
public global::System.Boolean Touching;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::FrooxEngine.VibratePreset OnHoverStartVibrate;
public global::FrooxEngine.VibratePreset OnHoverStayVibrate;
public global::FrooxEngine.VibratePreset OnHoverEndVibrate;
public global::FrooxEngine.VibratePreset OnTouchStartVibrate;
public global::FrooxEngine.VibratePreset OnTouchStayVibrate;
public global::FrooxEngine.VibratePreset OnTouchEndVibrate;
public global::System.Boolean EditModeOnly;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Hovering", Hovering.ToResoniteLinkField());
members.Add("Touching", Touching.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("OnHoverStartVibrate", OnHoverStartVibrate.ToResoniteLinkField());
members.Add("OnHoverStayVibrate", OnHoverStayVibrate.ToResoniteLinkField());
members.Add("OnHoverEndVibrate", OnHoverEndVibrate.ToResoniteLinkField());
members.Add("OnTouchStartVibrate", OnTouchStartVibrate.ToResoniteLinkField());
members.Add("OnTouchStayVibrate", OnTouchStayVibrate.ToResoniteLinkField());
members.Add("OnTouchEndVibrate", OnTouchEndVibrate.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
}

}
}
