
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatarBuilder
// Generated on: sobota 14. února 2026 8:58:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatarBuilder")]
public partial class CommonAvatarBuilder : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler, global::FrooxEngine.ICustomInspector

{
    public global::System.Boolean LoadCloudAvatars;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate> CustomAvatarTemplates;
public global::FrooxEngine.Slot AutoInject;
public global::System.Boolean SetupNameBadges;
public global::System.Boolean SetupIconBadges;
public global::System.Boolean SetupServerVoice;
public global::System.Boolean SetupClientVoice;
public global::System.Boolean SetupServerTools;
public global::System.Boolean SetupClientTools;
public global::System.Boolean SetupLocomotion;
public global::System.Boolean AllowLocomotion;
public global::System.Boolean DefaultHostSilenced;
public global::System.Boolean DefaultClientSilenced;
public global::FrooxEngine.Slot LocomotionModules;
public global::FrooxEngine.ILocomotionModule ForceDefaultLocomotionModule;
public global::System.Boolean FindUserPreferredModule;
public global::System.Boolean SetupItemShelves;
public global::System.Boolean ParentClientsToServer;
public global::System.Boolean AlignTracking;
public global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler EmptyAvatarSlotHandler;
public global::System.Boolean FillEmptySlots;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LoadCloudAvatars", LoadCloudAvatars.ToResoniteLinkField());
members.Add("CustomAvatarTemplates", new ResoniteLink.SyncList()
{
    Elements = CustomAvatarTemplates.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("AutoInject", AutoInject.ToResoniteReference(context));
members.Add("SetupNameBadges", SetupNameBadges.ToResoniteLinkField());
members.Add("SetupIconBadges", SetupIconBadges.ToResoniteLinkField());
members.Add("SetupServerVoice", SetupServerVoice.ToResoniteLinkField());
members.Add("SetupClientVoice", SetupClientVoice.ToResoniteLinkField());
members.Add("SetupServerTools", SetupServerTools.ToResoniteLinkField());
members.Add("SetupClientTools", SetupClientTools.ToResoniteLinkField());
members.Add("SetupLocomotion", SetupLocomotion.ToResoniteLinkField());
members.Add("AllowLocomotion", AllowLocomotion.ToResoniteLinkField());
members.Add("DefaultHostSilenced", DefaultHostSilenced.ToResoniteLinkField());
members.Add("DefaultClientSilenced", DefaultClientSilenced.ToResoniteLinkField());
members.Add("LocomotionModules", LocomotionModules.ToResoniteReference(context));
members.Add("ForceDefaultLocomotionModule", ForceDefaultLocomotionModule.ToResoniteReference(context));
members.Add("FindUserPreferredModule", FindUserPreferredModule.ToResoniteLinkField());
members.Add("SetupItemShelves", SetupItemShelves.ToResoniteLinkField());
members.Add("ParentClientsToServer", ParentClientsToServer.ToResoniteLinkField());
members.Add("AlignTracking", AlignTracking.ToResoniteLinkField());
members.Add("EmptyAvatarSlotHandler", EmptyAvatarSlotHandler.ToResoniteReference(context));
members.Add("FillEmptySlots", FillEmptySlots.ToResoniteLinkField());
}

}
}
