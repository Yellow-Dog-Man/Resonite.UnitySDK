
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager")]
public partial class AvatarManager : global::FrooxEngine.UserRootComponent

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.AvatarManager.EquippedGroup>, global::FrooxEngine.CommonAvatar.AvatarManager.EquippedGroup> _objectGroups = new();
public global::FrooxEngine.CommonAvatar.AvatarAnchor _currentAnchor { get => _currentAnchor_Element.Data; set => _currentAnchor_Element.Data = value; }
public Field<global::FrooxEngine.LinkRef<global::FrooxEngine.CommonAvatar.AvatarAnchor>, global::FrooxEngine.CommonAvatar.AvatarAnchor> _currentAnchor_Element = new();
public global::System.Boolean AutoAddNameBadge { get => AutoAddNameBadge_Element.Data; set => AutoAddNameBadge_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoAddNameBadge_Element = new();
public global::System.Boolean AutoAddIconBadge { get => AutoAddIconBadge_Element.Data; set => AutoAddIconBadge_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoAddIconBadge_Element = new();
public global::System.Boolean AutoAddLiveIndicator { get => AutoAddLiveIndicator_Element.Data; set => AutoAddLiveIndicator_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoAddLiveIndicator_Element = new();
public global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler EmptySlotHandler { get => EmptySlotHandler_Element.Data; set => EmptySlotHandler_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler>, global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler> EmptySlotHandler_Element = new();
public global::System.Single DefaultScale { get => DefaultScale_Element.Data; set => DefaultScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultScale_Element = new();
public global::System.String NameTagText { get => NameTagText_Element.Data; set => NameTagText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> NameTagText_Element = new();
public UnityEngine.ColorX NameTagColor { get => NameTagColor_Element.Data; set => NameTagColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NameTagColor_Element = new();
public UnityEngine.ColorX NameTagOutline { get => NameTagOutline_Element.Data; set => NameTagOutline_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NameTagOutline_Element = new();
public UnityEngine.ColorX NameTagBackground { get => NameTagBackground_Element.Data; set => NameTagBackground_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NameTagBackground_Element = new();
public global::FrooxEngine.Slot _badgeTemplates { get => _badgeTemplates_Element.Data; set => _badgeTemplates_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _badgeTemplates_Element = new();
public global::FrooxEngine.Slot _autoNameBadge { get => _autoNameBadge_Element.Data; set => _autoNameBadge_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _autoNameBadge_Element = new();
public global::FrooxEngine.Slot _autoIconBadge { get => _autoIconBadge_Element.Data; set => _autoIconBadge_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _autoIconBadge_Element = new();
public global::FrooxEngine.Slot _autoLiveIndicator { get => _autoLiveIndicator_Element.Data; set => _autoLiveIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _autoLiveIndicator_Element = new();
public global::System.Int32 _updateVersion { get => _updateVersion_Element.Data; set => _updateVersion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _updateVersion_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_objectGroups", _objectGroups.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_currentAnchor", _currentAnchor_Element.ToLinkReference(context));
members.Add("AutoAddNameBadge", AutoAddNameBadge_Element.ToLinkField(context));
members.Add("AutoAddIconBadge", AutoAddIconBadge_Element.ToLinkField(context));
members.Add("AutoAddLiveIndicator", AutoAddLiveIndicator_Element.ToLinkField(context));
members.Add("EmptySlotHandler", EmptySlotHandler_Element.ToLinkReference(context));
members.Add("DefaultScale", DefaultScale_Element.ToLinkField(context));
members.Add("NameTagText", NameTagText_Element.ToLinkField(context));
members.Add("NameTagColor", NameTagColor_Element.ToLinkField(context));
members.Add("NameTagOutline", NameTagOutline_Element.ToLinkField(context));
members.Add("NameTagBackground", NameTagBackground_Element.ToLinkField(context));
members.Add("_badgeTemplates", _badgeTemplates_Element.ToLinkReference(context));
members.Add("_autoNameBadge", _autoNameBadge_Element.ToLinkReference(context));
members.Add("_autoIconBadge", _autoIconBadge_Element.ToLinkReference(context));
members.Add("_autoLiveIndicator", _autoLiveIndicator_Element.ToLinkReference(context));
members.Add("_updateVersion", _updateVersion_Element.ToLinkField(context));
}

}
}
