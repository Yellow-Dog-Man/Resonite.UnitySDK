
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.SimpleAvatarProtection
// Generated on: čtvrtek 26. února 2026 10:04:49
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.SimpleAvatarProtection")]
public partial class SimpleAvatarProtection : global::FrooxEngine.Component, global::FrooxEngine.IItemPermissions, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IPackageImportEventReceiver

{
    public global::FrooxEngine.CloudUserRef User = new();
public global::System.Boolean ReassignUserOnPackageImport { get => ReassignUserOnPackageImport_Element.Data; set => ReassignUserOnPackageImport_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ReassignUserOnPackageImport_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("ReassignUserOnPackageImport", ReassignUserOnPackageImport_Element.Data.ToResoniteLinkField());
}

}
}
