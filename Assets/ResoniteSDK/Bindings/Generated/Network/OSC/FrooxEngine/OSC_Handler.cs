
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Handler
// Generated on: čtvrtek 19. února 2026 7:59:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Handler")]
public abstract partial class OSC_Handler : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef HandlingUser;
public global::System.String AccessReason;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HandlingUser", new ResoniteLink.SyncObject() { Members = HandlingUser.CollectMembers(context) });
members.Add("AccessReason", AccessReason.ToResoniteLinkField());
}

}
}
