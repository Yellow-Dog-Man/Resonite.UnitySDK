
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters
// Generated on: čtvrtek 19. února 2026 7:59:43
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
    public partial class AvatarAnchor
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchor+BodyNodeFilters")]
public partial class BodyNodeFilters : global::FrooxEngine.SyncObject

{
    public global::Renderite.Shared.BodyNode Node;
public global::System.Boolean Required;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.AvatarAnchor.PoseFilter> Filters;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteLinkField());
members.Add("Required", Required.ToResoniteLinkField());
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
            }
}
