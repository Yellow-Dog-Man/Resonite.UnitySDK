
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedSubTemplate<,>
// Generated on: sobota 14. února 2026 8:58:31
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template.ToResoniteReference(context));
members.Add("Root", Root.ToResoniteReference(context));
members.Add("MaxItems", MaxItems.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
}

}
}
