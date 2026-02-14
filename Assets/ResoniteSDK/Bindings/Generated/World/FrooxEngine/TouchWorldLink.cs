
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchWorldLink
// Generated on: sobota 14. února 2026 8:58:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchWorldLink")]
public partial class TouchWorldLink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::System.Boolean AcceptOutOfSightTouch;
public global::FrooxEngine.VibratePreset Vibrate;
public global::FrooxEngine.WorldLink WorldLink;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("Vibrate", Vibrate.ToResoniteLinkField());
members.Add("WorldLink", WorldLink.ToResoniteReference(context));
}

}
}
