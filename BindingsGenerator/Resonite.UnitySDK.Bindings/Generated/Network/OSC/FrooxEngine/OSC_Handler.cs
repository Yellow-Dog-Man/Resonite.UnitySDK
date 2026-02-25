
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Handler
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
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
