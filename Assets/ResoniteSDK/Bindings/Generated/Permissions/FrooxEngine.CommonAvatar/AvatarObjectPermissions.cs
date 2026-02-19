
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectPermissions
// Generated on: čtvrtek 19. února 2026 7:59:01
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarObjectPermissions")]
public partial class AvatarObjectPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.TagFilter Tags;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tags", new ResoniteLink.SyncObject() { Members = Tags.CollectMembers(context) });
}

}
}
