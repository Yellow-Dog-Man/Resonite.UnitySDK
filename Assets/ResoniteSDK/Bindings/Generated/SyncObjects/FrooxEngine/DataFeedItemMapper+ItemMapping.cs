
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMapper+ItemMapping
// Generated on: pátek 13. února 2026 5:52:18
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class DataFeedItemMapper
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMapper+ItemMapping")]
public partial class ItemMapping : global::FrooxEngine.SyncObject

{
    public System.String MatchingType;
public System.Collections.Generic.List<System.String> GenericReplacementTypes;
public global::FrooxEngine.FeedItemInterface Template;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MatchingType", MatchingType.ToResoniteLinkField());
members.Add("GenericReplacementTypes", new ResoniteLink.SyncList()
{
    Elements = GenericReplacementTypes.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("Template", new ResoniteLink.Reference() { });
}

}
            }
}
