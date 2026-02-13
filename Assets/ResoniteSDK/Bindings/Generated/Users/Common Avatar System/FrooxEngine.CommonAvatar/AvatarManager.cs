
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarManager.EquippedGroup> _objectGroups;
public global::FrooxEngine.CommonAvatar.AvatarAnchor _currentAnchor;
public global::System.Boolean AutoAddNameBadge;
public global::System.Boolean AutoAddIconBadge;
public global::System.Boolean AutoAddLiveIndicator;
public global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler EmptySlotHandler;
public global::System.Single DefaultScale;
public global::System.String NameTagText;
public UnityEngine.ColorX NameTagColor;
public UnityEngine.ColorX NameTagOutline;
public UnityEngine.ColorX NameTagBackground;
public global::FrooxEngine.Slot _badgeTemplates;
public global::FrooxEngine.Slot _autoNameBadge;
public global::FrooxEngine.Slot _autoIconBadge;
public global::FrooxEngine.Slot _autoLiveIndicator;
public global::System.Int32 _updateVersion;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_objectGroups", new ResoniteLink.SyncList()
{
    Elements = _objectGroups.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_currentAnchor", new ResoniteLink.Reference() { });
members.Add("AutoAddNameBadge", AutoAddNameBadge.ToResoniteLinkField());
members.Add("AutoAddIconBadge", AutoAddIconBadge.ToResoniteLinkField());
members.Add("AutoAddLiveIndicator", AutoAddLiveIndicator.ToResoniteLinkField());
members.Add("EmptySlotHandler", new ResoniteLink.Reference() { });
members.Add("DefaultScale", DefaultScale.ToResoniteLinkField());
members.Add("NameTagText", NameTagText.ToResoniteLinkField());
members.Add("NameTagColor", NameTagColor.ToResoniteLinkField());
members.Add("NameTagOutline", NameTagOutline.ToResoniteLinkField());
members.Add("NameTagBackground", NameTagBackground.ToResoniteLinkField());
members.Add("_badgeTemplates", new ResoniteLink.Reference() { });
members.Add("_autoNameBadge", new ResoniteLink.Reference() { });
members.Add("_autoIconBadge", new ResoniteLink.Reference() { });
members.Add("_autoLiveIndicator", new ResoniteLink.Reference() { });
members.Add("_updateVersion", _updateVersion.ToResoniteLinkField());
}

}
}
