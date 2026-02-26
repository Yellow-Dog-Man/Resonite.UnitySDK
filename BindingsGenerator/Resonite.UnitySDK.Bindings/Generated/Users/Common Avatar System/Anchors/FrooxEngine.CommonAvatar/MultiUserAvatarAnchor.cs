
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.MultiUserAvatarAnchor
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.IPointSnappable AnchorPointSnap { get => AnchorPointSnap_Element.Data; set => AnchorPointSnap_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPointSnappable>, global::FrooxEngine.IPointSnappable> AnchorPointSnap_Element = new();
public global::System.Int32 MaxUsers { get => MaxUsers_Element.Data; set => MaxUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxUsers_Element = new();
public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::FrooxEngine.IAvatarAnchor Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IAvatarAnchor>, global::FrooxEngine.IAvatarAnchor> Template_Element = new();
public global::FrooxEngine.Slot AnchorsRoot { get => AnchorsRoot_Element.Data; set => AnchorsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> AnchorsRoot_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorPointSnap", AnchorPointSnap_Element.ToLinkReference(context));
members.Add("MaxUsers", MaxUsers_Element.ToLinkField(context));
members.Add("MinDistance", MinDistance_Element.ToLinkField(context));
members.Add("Template", Template_Element.ToLinkReference(context));
members.Add("AnchorsRoot", AnchorsRoot_Element.ToLinkReference(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.ToLinkField(context));
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.ToLinkField(context));
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.ToLinkField(context));
}

}
}
