
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldPermissions
// Generated on: čtvrtek 26. února 2026 10:03:41
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
    public global::System.Boolean AllowSavingItems { get => AllowSavingItems_Element.Data; set => AllowSavingItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSavingItems_Element = new();
public global::System.Boolean AllowTransferingObjectsOut { get => AllowTransferingObjectsOut_Element.Data; set => AllowTransferingObjectsOut_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowTransferingObjectsOut_Element = new();
public global::System.Boolean AllowSpawningObjects { get => AllowSpawningObjects_Element.Data; set => AllowSpawningObjects_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSpawningObjects_Element = new();
public global::System.Boolean AllowSwappingAvatars { get => AllowSwappingAvatars_Element.Data; set => AllowSwappingAvatars_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSwappingAvatars_Element = new();
public global::FrooxEngine.WorldPermissions.SavePermission SaveCopyPermission { get => SaveCopyPermission_Element.Data; set => SaveCopyPermission_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.WorldPermissions.SavePermission>, global::FrooxEngine.WorldPermissions.SavePermission> SaveCopyPermission_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowSavingItems", AllowSavingItems_Element.Data.ToResoniteLinkField());
members.Add("AllowTransferingObjectsOut", AllowTransferingObjectsOut_Element.Data.ToResoniteLinkField());
members.Add("AllowSpawningObjects", AllowSpawningObjects_Element.Data.ToResoniteLinkField());
members.Add("AllowSwappingAvatars", AllowSwappingAvatars_Element.Data.ToResoniteLinkField());
members.Add("SaveCopyPermission", SaveCopyPermission_Element.Data.ToResoniteLinkField());
}

}
}
