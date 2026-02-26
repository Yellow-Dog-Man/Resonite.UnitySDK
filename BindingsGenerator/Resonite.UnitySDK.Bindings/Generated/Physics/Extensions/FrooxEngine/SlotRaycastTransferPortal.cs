
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotRaycastTransferPortal
// Generated on: čtvrtek 26. února 2026 12:26:58
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotRaycastTransferPortal")]
public partial class SlotRaycastTransferPortal : global::FrooxEngine.Component, global::FrooxEngine.IRaycastPortal

{
    public global::FrooxEngine.Slot Exit { get => Exit_Element.Data; set => Exit_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Exit_Element = new();
public global::System.Nullable<global::System.Boolean> OverrideHitTriggers { get => OverrideHitTriggers_Element.Data; set => OverrideHitTriggers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> OverrideHitTriggers_Element = new();
public global::FrooxEngine.FilterCombineMode FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FilterCombineMode>, global::FrooxEngine.FilterCombineMode> FilterMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exit", Exit_Element.ToLinkReference(context));
members.Add("OverrideHitTriggers", OverrideHitTriggers_Element.ToLinkField(context));
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
}

}
}
