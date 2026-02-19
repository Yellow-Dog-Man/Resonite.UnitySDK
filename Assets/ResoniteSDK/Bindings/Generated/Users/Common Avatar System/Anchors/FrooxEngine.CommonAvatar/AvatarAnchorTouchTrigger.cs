
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorTouchTrigger
// Generated on: čtvrtek 19. února 2026 8:00:32
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.CommonAvatar.AvatarAnchor Anchor;
public global::System.String EnterText;
public global::System.String ExitText;
public global::System.Boolean Enter;
public global::System.Boolean Exit;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;
public global::FrooxEngine.VibratePreset Vibrate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Anchor", Anchor.ToResoniteReference(context));
members.Add("EnterText", EnterText.ToResoniteLinkField());
members.Add("ExitText", ExitText.ToResoniteLinkField());
members.Add("Enter", Enter.ToResoniteLinkField());
members.Add("Exit", Exit.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("Vibrate", Vibrate.ToResoniteLinkField());
}

}
}
