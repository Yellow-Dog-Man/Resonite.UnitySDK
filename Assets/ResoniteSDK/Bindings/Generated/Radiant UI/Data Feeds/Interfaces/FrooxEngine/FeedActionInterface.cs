
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedActionInterface
// Generated on: úterý 24. února 2026 18:20:02
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedActionInterface")]
public partial class FeedActionInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.SyncDelegate<global::System.Action> Action;
public global::FrooxEngine.IField<global::System.Boolean> Highlight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Action", Action.ToResoniteReference(context));
members.Add("Highlight", Highlight.ToResoniteReference(context));
}

}
}
