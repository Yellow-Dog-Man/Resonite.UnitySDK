
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchablePermissions
// Generated on: sobota 14. února 2026 8:57:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchablePermissions")]
public partial class TouchablePermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.TagFilter Tags;
public global::FrooxEngine.ComponentFilter Components;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tags", new ResoniteLink.SyncObject() { Members = Tags.CollectMembers(context) });
members.Add("Components", new ResoniteLink.SyncObject() { Members = Components.CollectMembers(context) });
}

}
}
