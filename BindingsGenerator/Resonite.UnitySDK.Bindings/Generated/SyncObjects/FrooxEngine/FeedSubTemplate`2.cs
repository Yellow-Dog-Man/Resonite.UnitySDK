
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedSubTemplate<,>
// Generated on: čtvrtek 26. února 2026 12:28:01
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public TTemplate Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<TTemplate>, TTemplate> Template_Element = new();
public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Int32 MaxItems { get => MaxItems_Element.Data; set => MaxItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxItems_Element = new();
public global::System.Int32 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Offset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template_Element.ToLinkReference(context));
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("MaxItems", MaxItems_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
}

}
}
