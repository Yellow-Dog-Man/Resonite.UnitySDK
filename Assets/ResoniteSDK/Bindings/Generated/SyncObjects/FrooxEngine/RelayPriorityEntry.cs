
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelayPriorityEntry
// Generated on: úterý 24. února 2026 18:20:27
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RelayPriorityEntry")]
public partial class RelayPriorityEntry : global::FrooxEngine.PriorityEntry<global::System.String>

{
    public global::System.String RelayIP;
public global::System.Int32 CurrentUsers;
public global::System.Boolean IsAvailable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelayIP", RelayIP.ToResoniteLinkField());
members.Add("CurrentUsers", CurrentUsers.ToResoniteLinkField());
members.Add("IsAvailable", IsAvailable.ToResoniteLinkField());
}

}
}
