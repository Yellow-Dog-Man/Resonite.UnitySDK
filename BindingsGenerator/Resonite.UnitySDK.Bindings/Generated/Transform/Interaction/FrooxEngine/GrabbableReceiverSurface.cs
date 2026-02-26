
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableReceiverSurface
// Generated on: čtvrtek 26. února 2026 15:08:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableReceiverSurface")]
public partial class GrabbableReceiverSurface : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock

{
    public global::System.Boolean ParentPlaced { get => ParentPlaced_Element.Data; set => ParentPlaced_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParentPlaced_Element = new();
public global::FrooxEngine.Slot OverrideParent { get => OverrideParent_Element.Data; set => OverrideParent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideParent_Element = new();
public global::System.Single TweenTime { get => TweenTime_Element.Data; set => TweenTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TweenTime_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::System.Single Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Offset_Element = new();
public global::System.Single CheckOffset { get => CheckOffset_Element.Data; set => CheckOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CheckOffset_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<UnityEngine.Vector3>, UnityEngine.Vector3, Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3>> Directions = new();
public global::FrooxEngine.TagFilter TagFilter = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParentPlaced", ParentPlaced_Element.ToLinkField(context));
members.Add("OverrideParent", OverrideParent_Element.ToLinkReference(context));
members.Add("TweenTime", TweenTime_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("CheckOffset", CheckOffset_Element.ToLinkField(context));
members.Add("Directions", Directions.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("TagFilter", TagFilter.ToLinkSyncObject(context));
}

}
}
