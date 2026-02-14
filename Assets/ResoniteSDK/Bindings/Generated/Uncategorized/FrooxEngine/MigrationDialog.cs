
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MigrationDialog
// Generated on: sobota 14. února 2026 8:58:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MigrationDialog")]
public partial class MigrationDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _usernameField;
public global::FrooxEngine.UIX.TextField _passwordField;
public global::System.Boolean _migrateFavorites;
public global::System.Boolean _overwriteFavorites;
public global::System.Boolean _preserveOldHome;
public global::System.Boolean _migrateContacts;
public global::System.Boolean _migrateMessageHistory;
public global::System.Boolean _migrateRecords;
public global::System.Boolean _migrateCloudVariables;
public global::System.Boolean _migratedCloudVariableDefinitions;
public global::System.Boolean _migrateGroups;
public global::FrooxEngine.Slot _groupsRoot;
public global::FrooxEngine.UIX.Text _groupsMessage;
public global::FrooxEngine.UIX.Button _loadGroupsButton;
public global::FrooxEngine.MigrationDialog.State CurrentState;
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_usernameField", _usernameField.ToResoniteReference(context));
members.Add("_passwordField", _passwordField.ToResoniteReference(context));
members.Add("_migrateFavorites", _migrateFavorites.ToResoniteLinkField());
members.Add("_overwriteFavorites", _overwriteFavorites.ToResoniteLinkField());
members.Add("_preserveOldHome", _preserveOldHome.ToResoniteLinkField());
members.Add("_migrateContacts", _migrateContacts.ToResoniteLinkField());
members.Add("_migrateMessageHistory", _migrateMessageHistory.ToResoniteLinkField());
members.Add("_migrateRecords", _migrateRecords.ToResoniteLinkField());
members.Add("_migrateCloudVariables", _migrateCloudVariables.ToResoniteLinkField());
members.Add("_migratedCloudVariableDefinitions", _migratedCloudVariableDefinitions.ToResoniteLinkField());
members.Add("_migrateGroups", _migrateGroups.ToResoniteLinkField());
members.Add("_groupsRoot", _groupsRoot.ToResoniteReference(context));
members.Add("_groupsMessage", _groupsMessage.ToResoniteReference(context));
members.Add("_loadGroupsButton", _loadGroupsButton.ToResoniteReference(context));
members.Add("CurrentState", CurrentState.ToResoniteLinkField());
members.Add("_swapRegion", _swapRegion.ToResoniteReference(context));
}

}
}
