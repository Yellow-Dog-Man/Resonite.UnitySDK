
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters")]
public partial class BodyNodeFilters : global::FrooxEngine.SyncObject

{
    public global::Renderite.Shared.BodyNode Node;
public global::System.Boolean Required;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarAnchor.PoseFilter> Filters;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("Required", Required.ToResoniteLinkField());
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
            }
}
