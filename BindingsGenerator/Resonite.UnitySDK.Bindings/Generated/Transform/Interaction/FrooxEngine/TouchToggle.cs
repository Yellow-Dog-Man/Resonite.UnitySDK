
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchToggle
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchToggle")]
public partial class TouchToggle : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> State_Element = new();
public global::FrooxEngine.TouchEventType EventType { get => EventType_Element.Data; set => EventType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TouchEventType>, global::FrooxEngine.TouchEventType> EventType_Element = new();
public global::FrooxEngine.EventState ToggleEvent { get => ToggleEvent_Element.Data; set => ToggleEvent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.EventState>, global::FrooxEngine.EventState> ToggleEvent_Element = new();
public global::FrooxEngine.EventState OnEvent { get => OnEvent_Element.Data; set => OnEvent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.EventState>, global::FrooxEngine.EventState> OnEvent_Element = new();
public global::FrooxEngine.EventState OffEvent { get => OffEvent_Element.Data; set => OffEvent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.EventState>, global::FrooxEngine.EventState> OffEvent_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::FrooxEngine.VibratePreset Vibrate { get => Vibrate_Element.Data; set => Vibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> Vibrate_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter { get => ActiveUserFilter_Element.Data; set => ActiveUserFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ActiveUserHandling>, global::FrooxEngine.ActiveUserHandling> ActiveUserFilter_Element = new();
public global::System.Boolean __legacyActiveUserRootOnly { get => __legacyActiveUserRootOnly_Element.Data; set => __legacyActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyActiveUserRootOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("State", State_Element.ToLinkField(context));
members.Add("EventType", EventType_Element.ToLinkField(context));
members.Add("ToggleEvent", ToggleEvent_Element.ToLinkField(context));
members.Add("OnEvent", OnEvent_Element.ToLinkField(context));
members.Add("OffEvent", OffEvent_Element.ToLinkField(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.ToLinkField(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.ToLinkField(context));
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.ToLinkField(context));
members.Add("Vibrate", Vibrate_Element.ToLinkField(context));
members.Add("EditModeOnly", EditModeOnly_Element.ToLinkField(context));
members.Add("ActiveUserFilter", ActiveUserFilter_Element.ToLinkField(context));
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly_Element.ToLinkField(context));
}

}
}
