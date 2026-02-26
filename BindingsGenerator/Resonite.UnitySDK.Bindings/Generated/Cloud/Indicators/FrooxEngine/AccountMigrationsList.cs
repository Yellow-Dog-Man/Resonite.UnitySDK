
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AccountMigrationsList
// Generated on: čtvrtek 26. února 2026 10:03:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AccountMigrationsList")]
public partial class AccountMigrationsList : global::FrooxEngine.Component

{
    public global::System.Int32 TotalMigrations { get => TotalMigrations_Element.Data; set => TotalMigrations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalMigrations_Element = new();
public global::System.Int32 WaitingMigrations { get => WaitingMigrations_Element.Data; set => WaitingMigrations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> WaitingMigrations_Element = new();
public global::System.Int32 RunningMigrations { get => RunningMigrations_Element.Data; set => RunningMigrations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RunningMigrations_Element = new();
public global::System.Int32 CompletedMigrations { get => CompletedMigrations_Element.Data; set => CompletedMigrations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CompletedMigrations_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> MigrationTaskIds = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TotalMigrations", TotalMigrations_Element.Data.ToResoniteLinkField());
members.Add("WaitingMigrations", WaitingMigrations_Element.Data.ToResoniteLinkField());
members.Add("RunningMigrations", RunningMigrations_Element.Data.ToResoniteLinkField());
members.Add("CompletedMigrations", CompletedMigrations_Element.Data.ToResoniteLinkField());
members.Add("MigrationTaskIds", new ResoniteLink.SyncList()
{
    Elements = MigrationTaskIds.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}
