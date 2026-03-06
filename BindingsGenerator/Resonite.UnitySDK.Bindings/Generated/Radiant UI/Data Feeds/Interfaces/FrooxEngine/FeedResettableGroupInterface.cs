
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedResettableGroupInterface
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
