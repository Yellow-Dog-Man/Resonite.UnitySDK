
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MigrationDialog
// Generated on: čtvrtek 26. února 2026 10:04:47
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MigrationDialog")]
public partial class MigrationDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _usernameField { get => _usernameField_Element.Data; set => _usernameField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _usernameField_Element = new();
public global::FrooxEngine.UIX.TextField _passwordField { get => _passwordField_Element.Data; set => _passwordField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _passwordField_Element = new();
public global::System.Boolean _migrateFavorites { get => _migrateFavorites_Element.Data; set => _migrateFavorites_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateFavorites_Element = new();
public global::System.Boolean _overwriteFavorites { get => _overwriteFavorites_Element.Data; set => _overwriteFavorites_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _overwriteFavorites_Element = new();
public global::System.Boolean _preserveOldHome { get => _preserveOldHome_Element.Data; set => _preserveOldHome_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _preserveOldHome_Element = new();
public global::System.Boolean _migrateContacts { get => _migrateContacts_Element.Data; set => _migrateContacts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateContacts_Element = new();
public global::System.Boolean _migrateMessageHistory { get => _migrateMessageHistory_Element.Data; set => _migrateMessageHistory_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateMessageHistory_Element = new();
public global::System.Boolean _migrateRecords { get => _migrateRecords_Element.Data; set => _migrateRecords_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateRecords_Element = new();
public global::System.Boolean _migrateCloudVariables { get => _migrateCloudVariables_Element.Data; set => _migrateCloudVariables_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateCloudVariables_Element = new();
public global::System.Boolean _migratedCloudVariableDefinitions { get => _migratedCloudVariableDefinitions_Element.Data; set => _migratedCloudVariableDefinitions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migratedCloudVariableDefinitions_Element = new();
public global::System.Boolean _migrateGroups { get => _migrateGroups_Element.Data; set => _migrateGroups_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _migrateGroups_Element = new();
public global::FrooxEngine.Slot _groupsRoot { get => _groupsRoot_Element.Data; set => _groupsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _groupsRoot_Element = new();
public global::FrooxEngine.UIX.Text _groupsMessage { get => _groupsMessage_Element.Data; set => _groupsMessage_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _groupsMessage_Element = new();
public global::FrooxEngine.UIX.Button _loadGroupsButton { get => _loadGroupsButton_Element.Data; set => _loadGroupsButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _loadGroupsButton_Element = new();
public global::FrooxEngine.MigrationDialog.State CurrentState { get => CurrentState_Element.Data; set => CurrentState_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MigrationDialog.State>, global::FrooxEngine.MigrationDialog.State> CurrentState_Element = new();
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion { get => _swapRegion_Element.Data; set => _swapRegion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapRegion_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_usernameField", _usernameField_Element.Data.ToResoniteReference(context));
members.Add("_passwordField", _passwordField_Element.Data.ToResoniteReference(context));
members.Add("_migrateFavorites", _migrateFavorites_Element.Data.ToResoniteLinkField());
members.Add("_overwriteFavorites", _overwriteFavorites_Element.Data.ToResoniteLinkField());
members.Add("_preserveOldHome", _preserveOldHome_Element.Data.ToResoniteLinkField());
members.Add("_migrateContacts", _migrateContacts_Element.Data.ToResoniteLinkField());
members.Add("_migrateMessageHistory", _migrateMessageHistory_Element.Data.ToResoniteLinkField());
members.Add("_migrateRecords", _migrateRecords_Element.Data.ToResoniteLinkField());
members.Add("_migrateCloudVariables", _migrateCloudVariables_Element.Data.ToResoniteLinkField());
members.Add("_migratedCloudVariableDefinitions", _migratedCloudVariableDefinitions_Element.Data.ToResoniteLinkField());
members.Add("_migrateGroups", _migrateGroups_Element.Data.ToResoniteLinkField());
members.Add("_groupsRoot", _groupsRoot_Element.Data.ToResoniteReference(context));
members.Add("_groupsMessage", _groupsMessage_Element.Data.ToResoniteReference(context));
members.Add("_loadGroupsButton", _loadGroupsButton_Element.Data.ToResoniteReference(context));
members.Add("CurrentState", CurrentState_Element.Data.ToResoniteLinkField());
members.Add("_swapRegion", _swapRegion_Element.Data.ToResoniteReference(context));
}

}
}
