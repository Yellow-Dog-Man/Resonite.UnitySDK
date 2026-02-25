
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldPermissions
// Generated on: středa 25. února 2026 16:13:11
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
