
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+PoseFilter
// Generated on: pátek 6. března 2026 14:18:36
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
    public partial class AvatarAnchor
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+PoseFilter")]
public partial class PoseFilter : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.CommonAvatar.IAvatarPoseFilter Filter { get => Filter_Element.Data; set => Filter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarPoseFilter>, global::FrooxEngine.CommonAvatar.IAvatarPoseFilter> Filter_Element = new();
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
