
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableReceiverSurface
// Generated on: pátek 13. února 2026 5:51:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableReceiverSurface")]
public partial class GrabbableReceiverSurface : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock

{
    public global::System.Boolean ParentPlaced;
public global::FrooxEngine.Slot OverrideParent;
public global::System.Single TweenTime;
public global::System.Single MaxDistance;
public global::System.Single Offset;
public global::System.Single CheckOffset;
public System.Collections.Generic.List<UnityEngine.Vector3> Directions;
public global::FrooxEngine.TagFilter TagFilter;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ParentPlaced", ParentPlaced.ToResoniteLinkField());
members.Add("OverrideParent", new ResoniteLink.Reference() { });
members.Add("TweenTime", TweenTime.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("CheckOffset", CheckOffset.ToResoniteLinkField());
members.Add("Directions", new ResoniteLink.SyncList()
{
    Elements = Directions.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("TagFilter", new ResoniteLink.SyncObject() { Members = TagFilter.CollectMembers() });
}

}
}
