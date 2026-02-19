
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedValueActionInterface<>
// Generated on: čtvrtek 19. února 2026 8:00:17
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedValueActionInterface<>")]
public partial class FeedValueActionInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.SyncDelegate<global::System.Action<T>> Action;
public global::FrooxEngine.IField<T> Value;
public global::FrooxEngine.IField<global::System.Boolean> Highlight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Action", Action.ToResoniteReference(context));
members.Add("Value", Value.ToResoniteReference(context));
members.Add("Highlight", Highlight.ToResoniteReference(context));
}

}
}
