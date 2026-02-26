
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchButton
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchButton")]
public partial class TouchButton : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButton

{
    public global::System.Boolean IsPressed { get => IsPressed_Element.Data; set => IsPressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPressed_Element = new();
public global::System.Boolean IsHovering { get => IsHovering_Element.Data; set => IsHovering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHovering_Element = new();
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
public global::FrooxEngine.VibratePreset BeginPressVibration { get => BeginPressVibration_Element.Data; set => BeginPressVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> BeginPressVibration_Element = new();
public global::FrooxEngine.VibratePreset PressVibration { get => PressVibration_Element.Data; set => PressVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> PressVibration_Element = new();
public global::FrooxEngine.VibratePreset HoverVibration { get => HoverVibration_Element.Data; set => HoverVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> HoverVibration_Element = new();
public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsPressed", IsPressed_Element.ToLinkField(context));
members.Add("IsHovering", IsHovering_Element.ToLinkField(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.ToLinkField(context));
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.ToLinkField(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.ToLinkField(context));
members.Add("EditModeOnly", EditModeOnly_Element.ToLinkField(context));
members.Add("ActiveUserFilter", ActiveUserFilter_Element.ToLinkField(context));
members.Add("BeginPressVibration", BeginPressVibration_Element.ToLinkField(context));
members.Add("PressVibration", PressVibration_Element.ToLinkField(context));
members.Add("HoverVibration", HoverVibration_Element.ToLinkField(context));
members.Add("Label", Label_Element.ToLinkReference(context));
}

}
}
