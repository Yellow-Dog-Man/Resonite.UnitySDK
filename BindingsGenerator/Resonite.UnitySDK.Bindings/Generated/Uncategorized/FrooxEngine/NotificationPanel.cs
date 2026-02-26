
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NotificationPanel
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NotificationPanel")]
public partial class NotificationPanel : global::FrooxEngine.Component

{
    public global::System.Single DisplayDuration { get => DisplayDuration_Element.Data; set => DisplayDuration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DisplayDuration_Element = new();
public global::FrooxEngine.UserspaceRadiantDash Dash { get => Dash_Element.Data; set => Dash_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UserspaceRadiantDash>, global::FrooxEngine.UserspaceRadiantDash> Dash_Element = new();
public global::FrooxEngine.UIX.Canvas _canvas { get => _canvas_Element.Data; set => _canvas_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _canvas_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _notificationClip { get => _notificationClip_Element.Data; set => _notificationClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _notificationClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _contactRequestClip { get => _contactRequestClip_Element.Data; set => _contactRequestClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _contactRequestClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _inviteClip { get => _inviteClip_Element.Data; set => _inviteClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _inviteClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _inviteRequestClip { get => _inviteRequestClip_Element.Data; set => _inviteRequestClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _inviteRequestClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _sociableClip { get => _sociableClip_Element.Data; set => _sociableClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _sociableClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _userJoinClip { get => _userJoinClip_Element.Data; set => _userJoinClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _userJoinClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _userLeaveClip { get => _userLeaveClip_Element.Data; set => _userLeaveClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _userLeaveClip_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayDuration", DisplayDuration_Element.ToLinkField(context));
members.Add("Dash", Dash_Element.ToLinkReference(context));
members.Add("_canvas", _canvas_Element.ToLinkReference(context));
members.Add("_notificationClip", _notificationClip_Element.ToLinkReference(context));
members.Add("_contactRequestClip", _contactRequestClip_Element.ToLinkReference(context));
members.Add("_inviteClip", _inviteClip_Element.ToLinkReference(context));
members.Add("_inviteRequestClip", _inviteRequestClip_Element.ToLinkReference(context));
members.Add("_sociableClip", _sociableClip_Element.ToLinkReference(context));
members.Add("_userJoinClip", _userJoinClip_Element.ToLinkReference(context));
members.Add("_userLeaveClip", _userLeaveClip_Element.ToLinkReference(context));
}

}
}
