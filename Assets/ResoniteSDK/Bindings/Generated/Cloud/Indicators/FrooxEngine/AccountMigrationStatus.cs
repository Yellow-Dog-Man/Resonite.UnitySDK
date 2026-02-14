
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AccountMigrationStatus
// Generated on: sobota 14. února 2026 8:57:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AccountMigrationStatus")]
public partial class AccountMigrationStatus : global::FrooxEngine.Component

{
    public global::System.String TaskId;
public global::System.Boolean Exists;
public global::System.String Name;
public global::System.String Description;
public global::SkyFrost.Base.MigrationState State;
public global::System.Nullable<global::System.Int32> EstimatedQueuePosition;
public global::System.Int32 StartCount;
public global::System.DateTime CreatedOn;
public global::System.Nullable<global::System.DateTime> StartedOn;
public global::System.Nullable<global::System.DateTime> CompletedOn;
public global::System.Double RecordsPerMinute;
public global::System.String CurrentlyMigrating;
public global::System.String CurrentItem;
public global::System.Int32 TotalRecordCount;
public global::System.Int32 TotalMigratedRecordCount;
public global::System.Int32 TotalFailedRecordCount;
public global::System.Int32 TotalMigratedVariableCount;
public global::System.Int32 TotalMigratedVariableDefinitionCount;
public global::System.Int32 TotalContactCount;
public global::System.Int32 MigratedContactCount;
public global::System.Int32 MigratedMessageCount;
public global::System.Int32 TotalGroupCount;
public global::System.Int32 MigratedGroupCount;
public global::System.Int32 TotalMigratedMemberCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TaskId", TaskId.ToResoniteLinkField());
members.Add("Exists", Exists.ToResoniteLinkField());
members.Add("Name", Name.ToResoniteLinkField());
members.Add("Description", Description.ToResoniteLinkField());
members.Add("State", State.ToResoniteLinkField());
members.Add("EstimatedQueuePosition", EstimatedQueuePosition.ToResoniteLinkField());
members.Add("StartCount", StartCount.ToResoniteLinkField());
members.Add("CreatedOn", CreatedOn.ToResoniteLinkField());
members.Add("StartedOn", StartedOn.ToResoniteLinkField());
members.Add("CompletedOn", CompletedOn.ToResoniteLinkField());
members.Add("RecordsPerMinute", RecordsPerMinute.ToResoniteLinkField());
members.Add("CurrentlyMigrating", CurrentlyMigrating.ToResoniteLinkField());
members.Add("CurrentItem", CurrentItem.ToResoniteLinkField());
members.Add("TotalRecordCount", TotalRecordCount.ToResoniteLinkField());
members.Add("TotalMigratedRecordCount", TotalMigratedRecordCount.ToResoniteLinkField());
members.Add("TotalFailedRecordCount", TotalFailedRecordCount.ToResoniteLinkField());
members.Add("TotalMigratedVariableCount", TotalMigratedVariableCount.ToResoniteLinkField());
members.Add("TotalMigratedVariableDefinitionCount", TotalMigratedVariableDefinitionCount.ToResoniteLinkField());
members.Add("TotalContactCount", TotalContactCount.ToResoniteLinkField());
members.Add("MigratedContactCount", MigratedContactCount.ToResoniteLinkField());
members.Add("MigratedMessageCount", MigratedMessageCount.ToResoniteLinkField());
members.Add("TotalGroupCount", TotalGroupCount.ToResoniteLinkField());
members.Add("MigratedGroupCount", MigratedGroupCount.ToResoniteLinkField());
members.Add("TotalMigratedMemberCount", TotalMigratedMemberCount.ToResoniteLinkField());
}

}
}
