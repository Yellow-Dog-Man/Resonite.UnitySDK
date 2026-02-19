
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolAvatarPoseFilter
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ToolAvatarPoseFilter")]
public partial class ToolAvatarPoseFilter : global::FrooxEngine.Component

{
    public global::FrooxEngine.CommonAvatar.IAvatarPoseFilter Filter;
public global::System.Int32 Priority;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Filter", Filter.ToResoniteReference(context));
members.Add("Priority", Priority.ToResoniteLinkField());
}

}
}
