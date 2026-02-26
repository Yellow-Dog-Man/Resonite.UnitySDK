
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+PoseFilter
// Generated on: čtvrtek 26. února 2026 12:27:26
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.CommonAvatar.IAvatarPoseFilter Filter { get => Filter_Element.Data; set => Filter_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarPoseFilter>, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter> Filter_Element = new();
public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Filter", Filter_Element.ToLinkReference(context));
members.Add("Priority", Priority_Element.ToLinkField(context));
}

}
            }
}
