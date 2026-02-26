
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatarBuilder
// Generated on: čtvrtek 26. února 2026 12:28:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatarBuilder")]
public partial class CommonAvatarBuilder : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler, global::FrooxEngine.ICustomInspector

{
    public global::System.Boolean LoadCloudAvatars { get => LoadCloudAvatars_Element.Data; set => LoadCloudAvatars_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LoadCloudAvatars_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate>, global::FrooxEngine.CommonAvatarBuilder.AvatarTemplate> CustomAvatarTemplates = new();
public global::FrooxEngine.Slot AutoInject { get => AutoInject_Element.Data; set => AutoInject_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> AutoInject_Element = new();
public global::System.Boolean SetupNameBadges { get => SetupNameBadges_Element.Data; set => SetupNameBadges_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupNameBadges_Element = new();
public global::System.Boolean SetupIconBadges { get => SetupIconBadges_Element.Data; set => SetupIconBadges_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupIconBadges_Element = new();
public global::System.Boolean SetupServerVoice { get => SetupServerVoice_Element.Data; set => SetupServerVoice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupServerVoice_Element = new();
public global::System.Boolean SetupClientVoice { get => SetupClientVoice_Element.Data; set => SetupClientVoice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupClientVoice_Element = new();
public global::System.Boolean SetupServerTools { get => SetupServerTools_Element.Data; set => SetupServerTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupServerTools_Element = new();
public global::System.Boolean SetupClientTools { get => SetupClientTools_Element.Data; set => SetupClientTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupClientTools_Element = new();
public global::System.Boolean SetupLocomotion { get => SetupLocomotion_Element.Data; set => SetupLocomotion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupLocomotion_Element = new();
public global::System.Boolean AllowLocomotion { get => AllowLocomotion_Element.Data; set => AllowLocomotion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowLocomotion_Element = new();
public global::System.Boolean DefaultHostSilenced { get => DefaultHostSilenced_Element.Data; set => DefaultHostSilenced_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DefaultHostSilenced_Element = new();
public global::System.Boolean DefaultClientSilenced { get => DefaultClientSilenced_Element.Data; set => DefaultClientSilenced_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DefaultClientSilenced_Element = new();
public global::FrooxEngine.Slot LocomotionModules { get => LocomotionModules_Element.Data; set => LocomotionModules_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> LocomotionModules_Element = new();
public global::FrooxEngine.ILocomotionModule ForceDefaultLocomotionModule { get => ForceDefaultLocomotionModule_Element.Data; set => ForceDefaultLocomotionModule_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ILocomotionModule>, global::FrooxEngine.ILocomotionModule> ForceDefaultLocomotionModule_Element = new();
public global::System.Boolean FindUserPreferredModule { get => FindUserPreferredModule_Element.Data; set => FindUserPreferredModule_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FindUserPreferredModule_Element = new();
public global::System.Boolean SetupItemShelves { get => SetupItemShelves_Element.Data; set => SetupItemShelves_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupItemShelves_Element = new();
public global::System.Boolean ParentClientsToServer { get => ParentClientsToServer_Element.Data; set => ParentClientsToServer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParentClientsToServer_Element = new();
public global::System.Boolean AlignTracking { get => AlignTracking_Element.Data; set => AlignTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlignTracking_Element = new();
public global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler EmptyAvatarSlotHandler { get => EmptyAvatarSlotHandler_Element.Data; set => EmptyAvatarSlotHandler_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler>, global::FrooxEngine.CommonAvatar.IEmptyAvatarSlotHandler> EmptyAvatarSlotHandler_Element = new();
public global::System.Boolean FillEmptySlots { get => FillEmptySlots_Element.Data; set => FillEmptySlots_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FillEmptySlots_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LoadCloudAvatars", LoadCloudAvatars_Element.ToLinkField(context));
members.Add("CustomAvatarTemplates", CustomAvatarTemplates.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("AutoInject", AutoInject_Element.ToLinkReference(context));
members.Add("SetupNameBadges", SetupNameBadges_Element.ToLinkField(context));
members.Add("SetupIconBadges", SetupIconBadges_Element.ToLinkField(context));
members.Add("SetupServerVoice", SetupServerVoice_Element.ToLinkField(context));
members.Add("SetupClientVoice", SetupClientVoice_Element.ToLinkField(context));
members.Add("SetupServerTools", SetupServerTools_Element.ToLinkField(context));
members.Add("SetupClientTools", SetupClientTools_Element.ToLinkField(context));
members.Add("SetupLocomotion", SetupLocomotion_Element.ToLinkField(context));
members.Add("AllowLocomotion", AllowLocomotion_Element.ToLinkField(context));
members.Add("DefaultHostSilenced", DefaultHostSilenced_Element.ToLinkField(context));
members.Add("DefaultClientSilenced", DefaultClientSilenced_Element.ToLinkField(context));
members.Add("LocomotionModules", LocomotionModules_Element.ToLinkReference(context));
members.Add("ForceDefaultLocomotionModule", ForceDefaultLocomotionModule_Element.ToLinkReference(context));
members.Add("FindUserPreferredModule", FindUserPreferredModule_Element.ToLinkField(context));
members.Add("SetupItemShelves", SetupItemShelves_Element.ToLinkField(context));
members.Add("ParentClientsToServer", ParentClientsToServer_Element.ToLinkField(context));
members.Add("AlignTracking", AlignTracking_Element.ToLinkField(context));
members.Add("EmptyAvatarSlotHandler", EmptyAvatarSlotHandler_Element.ToLinkReference(context));
members.Add("FillEmptySlots", FillEmptySlots_Element.ToLinkField(context));
}

}
}
