
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NotificationPanel
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisplayDuration", DisplayDuration.ToResoniteLinkField());
members.Add("Dash", new ResoniteLink.Reference() { });
members.Add("_canvas", new ResoniteLink.Reference() { });
members.Add("_notificationClip", new ResoniteLink.Reference() { });
members.Add("_contactRequestClip", new ResoniteLink.Reference() { });
members.Add("_inviteClip", new ResoniteLink.Reference() { });
members.Add("_inviteRequestClip", new ResoniteLink.Reference() { });
members.Add("_sociableClip", new ResoniteLink.Reference() { });
members.Add("_userJoinClip", new ResoniteLink.Reference() { });
members.Add("_userLeaveClip", new ResoniteLink.Reference() { });
}

}
}
