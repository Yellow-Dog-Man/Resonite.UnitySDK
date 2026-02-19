
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotRaycastTransferPortal
// Generated on: čtvrtek 19. února 2026 7:59:02
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotRaycastTransferPortal")]
public partial class SlotRaycastTransferPortal : global::FrooxEngine.Component, global::FrooxEngine.IRaycastPortal

{
    public global::FrooxEngine.Slot Exit;
public global::System.Nullable<global::System.Boolean> OverrideHitTriggers;
public global::FrooxEngine.FilterCombineMode FilterMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exit", Exit.ToResoniteReference(context));
members.Add("OverrideHitTriggers", OverrideHitTriggers.ToResoniteLinkField());
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
}

}
}
