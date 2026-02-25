
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevicePriorityEntry
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevicePriorityEntry")]
public partial class DevicePriorityEntry : global::FrooxEngine.PriorityEntry<global::System.String>

{
    public global::System.String DeviceName;
public global::System.Boolean Allowed;
public global::System.Boolean IsConnected;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
members.Add("Allowed", Allowed.ToResoniteLinkField());
members.Add("IsConnected", IsConnected.ToResoniteLinkField());
}

}
}
