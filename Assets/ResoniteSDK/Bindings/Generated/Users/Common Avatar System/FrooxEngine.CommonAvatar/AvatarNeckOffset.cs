
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset")]
public partial class AvatarNeckOffset : global::FrooxEngine.UserRootComponent, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.INeckOffsetSource

{
    public global::System.Int32 Priority;
public UnityEngine.Vector3 Offset;
public global::FrooxEngine.User _activeUser;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("_activeUser", new ResoniteLink.Reference() { });
}

}
}
