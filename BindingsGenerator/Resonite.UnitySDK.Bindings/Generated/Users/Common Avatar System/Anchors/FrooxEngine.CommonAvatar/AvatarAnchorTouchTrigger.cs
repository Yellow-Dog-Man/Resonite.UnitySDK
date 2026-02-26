
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorTouchTrigger
// Generated on: čtvrtek 26. února 2026 10:04:49
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorTouchTrigger")]
public partial class AvatarAnchorTouchTrigger : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.CommonAvatar.AvatarAnchor Anchor { get => Anchor_Element.Data; set => Anchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarAnchor>, global::FrooxEngine.CommonAvatar.AvatarAnchor> Anchor_Element = new();
public global::System.String EnterText { get => EnterText_Element.Data; set => EnterText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> EnterText_Element = new();
public global::System.String ExitText { get => ExitText_Element.Data; set => ExitText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ExitText_Element = new();
public global::System.Boolean Enter { get => Enter_Element.Data; set => Enter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Enter_Element = new();
public global::System.Boolean Exit { get => Exit_Element.Data; set => Exit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Exit_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::FrooxEngine.VibratePreset Vibrate { get => Vibrate_Element.Data; set => Vibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> Vibrate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Anchor", Anchor_Element.Data.ToResoniteReference(context));
members.Add("EnterText", EnterText_Element.Data.ToResoniteLinkField());
members.Add("ExitText", ExitText_Element.Data.ToResoniteLinkField());
members.Add("Enter", Enter_Element.Data.ToResoniteLinkField());
members.Add("Exit", Exit_Element.Data.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("Vibrate", Vibrate_Element.Data.ToResoniteLinkField());
}

}
}
