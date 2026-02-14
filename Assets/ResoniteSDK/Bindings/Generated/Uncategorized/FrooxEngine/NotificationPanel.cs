
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NotificationPanel
// Generated on: sobota 14. února 2026 8:58:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NotificationPanel")]
public partial class NotificationPanel : global::FrooxEngine.Component

{
    public global::System.Single DisplayDuration;
public global::FrooxEngine.UserspaceRadiantDash Dash;
public global::FrooxEngine.UIX.Canvas _canvas;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _notificationClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _contactRequestClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _inviteClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _inviteRequestClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _sociableClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _userJoinClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _userLeaveClip;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayDuration", DisplayDuration.ToResoniteLinkField());
members.Add("Dash", Dash.ToResoniteReference(context));
members.Add("_canvas", _canvas.ToResoniteReference(context));
members.Add("_notificationClip", _notificationClip.ToResoniteReference(context));
members.Add("_contactRequestClip", _contactRequestClip.ToResoniteReference(context));
members.Add("_inviteClip", _inviteClip.ToResoniteReference(context));
members.Add("_inviteRequestClip", _inviteRequestClip.ToResoniteReference(context));
members.Add("_sociableClip", _sociableClip.ToResoniteReference(context));
members.Add("_userJoinClip", _userJoinClip.ToResoniteReference(context));
members.Add("_userLeaveClip", _userLeaveClip.ToResoniteReference(context));
}

}
}
