
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldPermissions
// Generated on: úterý 24. února 2026 18:17:53
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldPermissions")]
public partial class WorldPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowSavingItems;
public global::System.Boolean AllowTransferingObjectsOut;
public global::System.Boolean AllowSpawningObjects;
public global::System.Boolean AllowSwappingAvatars;
public global::FrooxEngine.WorldPermissions.SavePermission SaveCopyPermission;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowSavingItems", AllowSavingItems.ToResoniteLinkField());
members.Add("AllowTransferingObjectsOut", AllowTransferingObjectsOut.ToResoniteLinkField());
members.Add("AllowSpawningObjects", AllowSpawningObjects.ToResoniteLinkField());
members.Add("AllowSwappingAvatars", AllowSwappingAvatars.ToResoniteLinkField());
members.Add("SaveCopyPermission", SaveCopyPermission.ToResoniteLinkField());
}

}
}
