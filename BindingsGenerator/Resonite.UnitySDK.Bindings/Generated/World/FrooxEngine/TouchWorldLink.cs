
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchWorldLink
// Generated on: čtvrtek 26. února 2026 10:04:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchWorldLink")]
public partial class TouchWorldLink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::FrooxEngine.VibratePreset Vibrate { get => Vibrate_Element.Data; set => Vibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> Vibrate_Element = new();
public global::FrooxEngine.WorldLink WorldLink { get => WorldLink_Element.Data; set => WorldLink_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldLink>, global::FrooxEngine.WorldLink> WorldLink_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("Vibrate", Vibrate_Element.Data.ToResoniteLinkField());
members.Add("WorldLink", WorldLink_Element.Data.ToResoniteReference(context));
}

}
}
