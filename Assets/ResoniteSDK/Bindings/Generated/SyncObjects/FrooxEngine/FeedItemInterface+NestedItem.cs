
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface+NestedItem
// Generated on: pátek 13. února 2026 23:23:01
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Interface", new ResoniteLink.Reference() { });
members.Add("Container", new ResoniteLink.Reference() { });
members.Add("IgnoreParentContainer", IgnoreParentContainer.ToResoniteLinkField());
}

}
            }
}
