
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset
// Generated on: středa 25. února 2026 16:14:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNeckOffset")]
public partial class AvatarNeckOffset : global::FrooxEngine.UserRootComponent, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent, global::FrooxEngine.INeckOffsetSource

{
    public global::System.Int32 Priority;
public UnityEngine.Vector3 Offset;
public global::FrooxEngine.User _activeUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("_activeUser", _activeUser.ToResoniteReference(context));
}

}
}
