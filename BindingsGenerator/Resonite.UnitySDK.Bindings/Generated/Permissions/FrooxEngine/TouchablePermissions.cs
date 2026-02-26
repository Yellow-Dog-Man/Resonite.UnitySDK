
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchablePermissions
// Generated on: čtvrtek 26. února 2026 12:26:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchablePermissions")]
public partial class TouchablePermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.TagFilter Tags = new();
public global::FrooxEngine.ComponentFilter Components = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tags", Tags.ToLinkSyncObject(context));
members.Add("Components", Components.ToLinkSyncObject(context));
}

}
}
