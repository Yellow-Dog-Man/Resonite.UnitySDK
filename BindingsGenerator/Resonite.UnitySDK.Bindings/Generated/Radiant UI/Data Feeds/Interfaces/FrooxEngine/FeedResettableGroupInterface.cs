
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedResettableGroupInterface
// Generated on: čtvrtek 26. února 2026 15:09:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedResettableGroupInterface")]
public partial class FeedResettableGroupInterface : global::FrooxEngine.FeedGroupInterface

{
    public global::FrooxEngine.SyncDelegate<global::System.Action> ResetAction { get => ResetAction_Element.Data; set => ResetAction_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncDelegate<global::System.Action>>, global::FrooxEngine.SyncDelegate<global::System.Action>> ResetAction_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetAction", ResetAction_Element.ToLinkReference(context));
}

}
}
