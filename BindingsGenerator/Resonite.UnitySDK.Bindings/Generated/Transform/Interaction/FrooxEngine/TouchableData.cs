
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchableData
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchableData")]
public partial class TouchableData : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean Hovering { get => Hovering_Element.Data; set => Hovering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Hovering_Element = new();
public global::System.Boolean Touching { get => Touching_Element.Data; set => Touching_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Touching_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::FrooxEngine.VibratePreset OnHoverStartVibrate { get => OnHoverStartVibrate_Element.Data; set => OnHoverStartVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnHoverStartVibrate_Element = new();
public global::FrooxEngine.VibratePreset OnHoverStayVibrate { get => OnHoverStayVibrate_Element.Data; set => OnHoverStayVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnHoverStayVibrate_Element = new();
public global::FrooxEngine.VibratePreset OnHoverEndVibrate { get => OnHoverEndVibrate_Element.Data; set => OnHoverEndVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnHoverEndVibrate_Element = new();
public global::FrooxEngine.VibratePreset OnTouchStartVibrate { get => OnTouchStartVibrate_Element.Data; set => OnTouchStartVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnTouchStartVibrate_Element = new();
public global::FrooxEngine.VibratePreset OnTouchStayVibrate { get => OnTouchStayVibrate_Element.Data; set => OnTouchStayVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnTouchStayVibrate_Element = new();
public global::FrooxEngine.VibratePreset OnTouchEndVibrate { get => OnTouchEndVibrate_Element.Data; set => OnTouchEndVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> OnTouchEndVibrate_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter { get => ActiveUserFilter_Element.Data; set => ActiveUserFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ActiveUserHandling>, global::FrooxEngine.ActiveUserHandling> ActiveUserFilter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Hovering", Hovering_Element.ToLinkField(context));
members.Add("Touching", Touching_Element.ToLinkField(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.ToLinkField(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.ToLinkField(context));
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.ToLinkField(context));
members.Add("OnHoverStartVibrate", OnHoverStartVibrate_Element.ToLinkField(context));
members.Add("OnHoverStayVibrate", OnHoverStayVibrate_Element.ToLinkField(context));
members.Add("OnHoverEndVibrate", OnHoverEndVibrate_Element.ToLinkField(context));
members.Add("OnTouchStartVibrate", OnTouchStartVibrate_Element.ToLinkField(context));
members.Add("OnTouchStayVibrate", OnTouchStayVibrate_Element.ToLinkField(context));
members.Add("OnTouchEndVibrate", OnTouchEndVibrate_Element.ToLinkField(context));
members.Add("EditModeOnly", EditModeOnly_Element.ToLinkField(context));
members.Add("ActiveUserFilter", ActiveUserFilter_Element.ToLinkField(context));
}

}
}
