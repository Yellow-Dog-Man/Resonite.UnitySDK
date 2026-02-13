
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedSubTemplate<,>
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedSubTemplate<,>")]
public partial class FeedSubTemplate<TItem,TTemplate> : global::FrooxEngine.SyncObject
	where TTemplate : global::FrooxEngine.FeedItemInterface
	where TItem : global::FrooxEngine.DataFeedItem

{
    public TTemplate Template;
public global::FrooxEngine.Slot Root;
public global::System.Int32 MaxItems;
public global::System.Int32 Offset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Template", new ResoniteLink.Reference() { });
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("MaxItems", MaxItems.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
}

}
}
