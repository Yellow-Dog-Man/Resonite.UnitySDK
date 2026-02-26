
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters
// Generated on: čtvrtek 26. února 2026 15:08:30
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters")]
public partial class BodyNodeFilters : global::FrooxEngine.SyncObject

{
    public global::Renderite.Shared.BodyNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> Node_Element = new();
public global::System.Boolean Required { get => Required_Element.Data; set => Required_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Required_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CommonAvatar.AvatarAnchor.PoseFilter>, global::FrooxEngine.CommonAvatar.AvatarAnchor.PoseFilter> Filters = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkField(context));
members.Add("Required", Required_Element.ToLinkField(context));
members.Add("Filters", Filters.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
            }
}
