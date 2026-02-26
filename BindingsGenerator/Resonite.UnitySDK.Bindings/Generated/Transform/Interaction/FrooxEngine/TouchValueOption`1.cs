
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchValueOption<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchValueOption<>")]
public partial class TouchValueOption<T> : global::FrooxEngine.Component, global::FrooxEngine.ITouchable
	

{
    public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Target_Element = new();
public T Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Value_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> ActiveIndicator { get => ActiveIndicator_Element.Data; set => ActiveIndicator_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> ActiveIndicator_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HoverIndicator { get => HoverIndicator_Element.Data; set => HoverIndicator_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> HoverIndicator_Element = new();
public global::FrooxEngine.VibratePreset HoverVibrate { get => HoverVibrate_Element.Data; set => HoverVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> HoverVibrate_Element = new();
public global::FrooxEngine.VibratePreset Vibrate { get => Vibrate_Element.Data; set => Vibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> Vibrate_Element = new();
public global::System.Boolean SetOnTouchBegin { get => SetOnTouchBegin_Element.Data; set => SetOnTouchBegin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnTouchBegin_Element = new();
public global::System.Boolean SetOnTouchStay { get => SetOnTouchStay_Element.Data; set => SetOnTouchStay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnTouchStay_Element = new();
public global::System.Boolean SetOnTouchEnd { get => SetOnTouchEnd_Element.Data; set => SetOnTouchEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetOnTouchEnd_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::System.Boolean ActiveUserRootOnly { get => ActiveUserRootOnly_Element.Data; set => ActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ActiveUserRootOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Value", Value_Element.ToLinkField(context));
members.Add("ActiveIndicator", ActiveIndicator_Element.ToLinkReference(context));
members.Add("HoverIndicator", HoverIndicator_Element.ToLinkReference(context));
members.Add("HoverVibrate", HoverVibrate_Element.ToLinkField(context));
members.Add("Vibrate", Vibrate_Element.ToLinkField(context));
members.Add("SetOnTouchBegin", SetOnTouchBegin_Element.ToLinkField(context));
members.Add("SetOnTouchStay", SetOnTouchStay_Element.ToLinkField(context));
members.Add("SetOnTouchEnd", SetOnTouchEnd_Element.ToLinkField(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.ToLinkField(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.ToLinkField(context));
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.ToLinkField(context));
members.Add("EditModeOnly", EditModeOnly_Element.ToLinkField(context));
members.Add("ActiveUserRootOnly", ActiveUserRootOnly_Element.ToLinkField(context));
}

}
}
