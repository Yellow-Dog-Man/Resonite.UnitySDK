
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface+NestedItem
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
    public partial class FeedItemInterface
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedItemInterface+NestedItem")]
public partial class NestedItem : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FeedItemInterface Interface;
public global::FrooxEngine.Slot Container;
public global::System.Boolean IgnoreParentContainer;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Interface", Interface.ToResoniteReference(context));
members.Add("Container", Container.ToResoniteReference(context));
members.Add("IgnoreParentContainer", IgnoreParentContainer.ToResoniteLinkField());
}

}
            }
}
