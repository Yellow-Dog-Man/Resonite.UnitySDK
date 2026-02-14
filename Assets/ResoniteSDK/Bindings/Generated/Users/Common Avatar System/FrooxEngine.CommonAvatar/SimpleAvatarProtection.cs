
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.SimpleAvatarProtection
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.CloudUserRef User;
public global::System.Boolean ReassignUserOnPackageImport;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("ReassignUserOnPackageImport", ReassignUserOnPackageImport.ToResoniteLinkField());
}

}
}
