
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+PoseFilter
// Generated on: sobota 14. února 2026 8:57:47
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
    public partial class AvatarAnchor
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+PoseFilter")]
public partial class PoseFilter : global::FrooxEngine.SyncObject

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
}
