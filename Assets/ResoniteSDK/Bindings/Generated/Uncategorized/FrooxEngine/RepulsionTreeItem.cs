
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RepulsionTreeItem
// Generated on: pátek 13. února 2026 23:23:17
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RepulsionTreeItem")]
public partial class RepulsionTreeItem : global::FrooxEngine.Component, global::FrooxEngine.IRepulsionTreeNode

{
    public global::System.Single Force;
public global::System.Single Radius;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Force", Force.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
}

}
}
