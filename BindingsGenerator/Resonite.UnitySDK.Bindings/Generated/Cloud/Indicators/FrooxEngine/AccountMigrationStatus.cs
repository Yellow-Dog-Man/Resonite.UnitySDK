
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AccountMigrationStatus
// Generated on: čtvrtek 26. února 2026 12:26:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AccountMigrationStatus")]
public partial class AccountMigrationStatus : global::FrooxEngine.Component

{
    public global::System.String TaskId { get => TaskId_Element.Data; set => TaskId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> TaskId_Element = new();
public global::System.Boolean Exists { get => Exists_Element.Data; set => Exists_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Exists_Element = new();
public global::System.String Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Name_Element = new();
public global::System.String Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Description_Element = new();
public global::SkyFrost.Base.MigrationState State { get => State_Element.Data; set => State_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.MigrationState>, global::SkyFrost.Base.MigrationState> State_Element = new();
public global::System.Nullable<global::System.Int32> EstimatedQueuePosition { get => EstimatedQueuePosition_Element.Data; set => EstimatedQueuePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> EstimatedQueuePosition_Element = new();
public global::System.Int32 StartCount { get => StartCount_Element.Data; set => StartCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> StartCount_Element = new();
public global::System.DateTime CreatedOn { get => CreatedOn_Element.Data; set => CreatedOn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.DateTime>, global::System.DateTime> CreatedOn_Element = new();
public global::System.Nullable<global::System.DateTime> StartedOn { get => StartedOn_Element.Data; set => StartedOn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> StartedOn_Element = new();
public global::System.Nullable<global::System.DateTime> CompletedOn { get => CompletedOn_Element.Data; set => CompletedOn_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.DateTime>>, global::System.Nullable<global::System.DateTime>> CompletedOn_Element = new();
public global::System.Double RecordsPerMinute { get => RecordsPerMinute_Element.Data; set => RecordsPerMinute_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> RecordsPerMinute_Element = new();
public global::System.String CurrentlyMigrating { get => CurrentlyMigrating_Element.Data; set => CurrentlyMigrating_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CurrentlyMigrating_Element = new();
public global::System.String CurrentItem { get => CurrentItem_Element.Data; set => CurrentItem_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CurrentItem_Element = new();
public global::System.Int32 TotalRecordCount { get => TotalRecordCount_Element.Data; set => TotalRecordCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalRecordCount_Element = new();
public global::System.Int32 TotalMigratedRecordCount { get => TotalMigratedRecordCount_Element.Data; set => TotalMigratedRecordCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalMigratedRecordCount_Element = new();
public global::System.Int32 TotalFailedRecordCount { get => TotalFailedRecordCount_Element.Data; set => TotalFailedRecordCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalFailedRecordCount_Element = new();
public global::System.Int32 TotalMigratedVariableCount { get => TotalMigratedVariableCount_Element.Data; set => TotalMigratedVariableCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalMigratedVariableCount_Element = new();
public global::System.Int32 TotalMigratedVariableDefinitionCount { get => TotalMigratedVariableDefinitionCount_Element.Data; set => TotalMigratedVariableDefinitionCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalMigratedVariableDefinitionCount_Element = new();
public global::System.Int32 TotalContactCount { get => TotalContactCount_Element.Data; set => TotalContactCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalContactCount_Element = new();
public global::System.Int32 MigratedContactCount { get => MigratedContactCount_Element.Data; set => MigratedContactCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MigratedContactCount_Element = new();
public global::System.Int32 MigratedMessageCount { get => MigratedMessageCount_Element.Data; set => MigratedMessageCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MigratedMessageCount_Element = new();
public global::System.Int32 TotalGroupCount { get => TotalGroupCount_Element.Data; set => TotalGroupCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalGroupCount_Element = new();
public global::System.Int32 MigratedGroupCount { get => MigratedGroupCount_Element.Data; set => MigratedGroupCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MigratedGroupCount_Element = new();
public global::System.Int32 TotalMigratedMemberCount { get => TotalMigratedMemberCount_Element.Data; set => TotalMigratedMemberCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalMigratedMemberCount_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TaskId", TaskId_Element.ToLinkField(context));
members.Add("Exists", Exists_Element.ToLinkField(context));
members.Add("Name", Name_Element.ToLinkField(context));
members.Add("Description", Description_Element.ToLinkField(context));
members.Add("State", State_Element.ToLinkField(context));
members.Add("EstimatedQueuePosition", EstimatedQueuePosition_Element.ToLinkField(context));
members.Add("StartCount", StartCount_Element.ToLinkField(context));
members.Add("CreatedOn", CreatedOn_Element.ToLinkField(context));
members.Add("StartedOn", StartedOn_Element.ToLinkField(context));
members.Add("CompletedOn", CompletedOn_Element.ToLinkField(context));
members.Add("RecordsPerMinute", RecordsPerMinute_Element.ToLinkField(context));
members.Add("CurrentlyMigrating", CurrentlyMigrating_Element.ToLinkField(context));
members.Add("CurrentItem", CurrentItem_Element.ToLinkField(context));
members.Add("TotalRecordCount", TotalRecordCount_Element.ToLinkField(context));
members.Add("TotalMigratedRecordCount", TotalMigratedRecordCount_Element.ToLinkField(context));
members.Add("TotalFailedRecordCount", TotalFailedRecordCount_Element.ToLinkField(context));
members.Add("TotalMigratedVariableCount", TotalMigratedVariableCount_Element.ToLinkField(context));
members.Add("TotalMigratedVariableDefinitionCount", TotalMigratedVariableDefinitionCount_Element.ToLinkField(context));
members.Add("TotalContactCount", TotalContactCount_Element.ToLinkField(context));
members.Add("MigratedContactCount", MigratedContactCount_Element.ToLinkField(context));
members.Add("MigratedMessageCount", MigratedMessageCount_Element.ToLinkField(context));
members.Add("TotalGroupCount", TotalGroupCount_Element.ToLinkField(context));
members.Add("MigratedGroupCount", MigratedGroupCount_Element.ToLinkField(context));
members.Add("TotalMigratedMemberCount", TotalMigratedMemberCount_Element.ToLinkField(context));
}

}
}
