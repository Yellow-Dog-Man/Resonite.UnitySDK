
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AccountMigrationsList
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AccountMigrationsList")]
public partial class AccountMigrationsList : global::FrooxEngine.Component

{
    public global::System.Int32 TotalMigrations;
public global::System.Int32 WaitingMigrations;
public global::System.Int32 RunningMigrations;
public global::System.Int32 CompletedMigrations;
public System.Collections.Generic.List<global::System.String> MigrationTaskIds;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TotalMigrations", TotalMigrations.ToResoniteLinkField());
members.Add("WaitingMigrations", WaitingMigrations.ToResoniteLinkField());
members.Add("RunningMigrations", RunningMigrations.ToResoniteLinkField());
members.Add("CompletedMigrations", CompletedMigrations.ToResoniteLinkField());
members.Add("MigrationTaskIds", new ResoniteLink.SyncList()
{
    Elements = MigrationTaskIds.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
