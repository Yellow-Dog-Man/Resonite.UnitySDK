
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotRaycastTransferPortal
// Generated on: pátek 13. února 2026 5:51:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotRaycastTransferPortal")]
public partial class SlotRaycastTransferPortal : global::FrooxEngine.Component, global::FrooxEngine.IRaycastPortal

{
    public global::FrooxEngine.Slot Exit;
public global::System.Nullable<global::System.Boolean> OverrideHitTriggers;
public global::FrooxEngine.FilterCombineMode FilterMode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Exit", new ResoniteLink.Reference() { });
members.Add("OverrideHitTriggers", OverrideHitTriggers.ToResoniteLinkField());
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
}

}
}
