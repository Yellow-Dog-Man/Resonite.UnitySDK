
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UniverseStatus
// Generated on: úterý 24. února 2026 18:17:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UniverseStatus")]
public partial class UniverseStatus : global::FrooxEngine.Component

{
    public global::System.String UniverseId;
public global::System.String UniverseName;
public global::System.String PrimaryGroupId;
public global::System.Boolean InUniverse;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UniverseId", UniverseId.ToResoniteLinkField());
members.Add("UniverseName", UniverseName.ToResoniteLinkField());
members.Add("PrimaryGroupId", PrimaryGroupId.ToResoniteLinkField());
members.Add("InUniverse", InUniverse.ToResoniteLinkField());
}

}
}
