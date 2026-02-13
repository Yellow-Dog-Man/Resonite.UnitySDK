
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_Handler
// Generated on: pátek 13. února 2026 5:51:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_Handler")]
public abstract partial class OSC_Handler : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef HandlingUser;
public global::System.String AccessReason;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HandlingUser", new ResoniteLink.SyncObject() { Members = HandlingUser.CollectMembers() });
members.Add("AccessReason", AccessReason.ToResoniteLinkField());
}

}
}
