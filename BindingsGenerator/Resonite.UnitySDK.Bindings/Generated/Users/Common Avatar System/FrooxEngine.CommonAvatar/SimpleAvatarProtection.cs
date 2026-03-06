
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.SimpleAvatarProtection
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
members.Add("User", User.ToLinkSyncObject(context));
members.Add("ReassignUserOnPackageImport", ReassignUserOnPackageImport_Element.ToLinkField(context));
}

}
}
