
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.MultiUserAvatarAnchor
// Generated on: středa 25. února 2026 16:14:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.MultiUserAvatarAnchor")]
public partial class MultiUserAvatarAnchor : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.IPointSnappable AnchorPointSnap;
public global::System.Int32 MaxUsers;
public global::System.Single MinDistance;
public global::FrooxEngine.IAvatarAnchor Template;
public global::FrooxEngine.Slot AnchorsRoot;
public global::System.Boolean AcceptOutOfSightTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptRemoteTouch;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorPointSnap", AnchorPointSnap.ToResoniteReference(context));
members.Add("MaxUsers", MaxUsers.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("Template", Template.ToResoniteReference(context));
members.Add("AnchorsRoot", AnchorsRoot.ToResoniteReference(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
}

}
}
