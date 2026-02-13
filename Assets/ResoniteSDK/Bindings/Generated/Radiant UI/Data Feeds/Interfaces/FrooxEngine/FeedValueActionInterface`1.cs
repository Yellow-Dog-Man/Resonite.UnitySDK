
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedValueActionInterface<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedValueActionInterface<>")]
public partial class FeedValueActionInterface<T> : global::FrooxEngine.FeedItemInterface
	

{
    public global::FrooxEngine.SyncDelegate<global::System.Action<T>> Action;
public global::FrooxEngine.IField<T> Value;
public global::FrooxEngine.IField<global::System.Boolean> Highlight;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Action", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("Highlight", new ResoniteLink.Reference() { });
}

}
}
