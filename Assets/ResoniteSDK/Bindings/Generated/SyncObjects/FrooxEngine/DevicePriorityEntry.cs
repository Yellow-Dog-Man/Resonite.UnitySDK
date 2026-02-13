
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevicePriorityEntry
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevicePriorityEntry")]
public partial class DevicePriorityEntry : global::FrooxEngine.PriorityEntry<global::System.String>

{
    public global::System.String DeviceName;
public global::System.Boolean Allowed;
public global::System.Boolean IsConnected;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DeviceName", DeviceName.ToResoniteLinkField());
members.Add("Allowed", Allowed.ToResoniteLinkField());
members.Add("IsConnected", IsConnected.ToResoniteLinkField());
}

}
}
