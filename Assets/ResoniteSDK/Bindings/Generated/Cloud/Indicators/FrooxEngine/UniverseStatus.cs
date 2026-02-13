
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UniverseStatus
// Generated on: pátek 13. února 2026 23:21:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UniverseStatus")]
public partial class UniverseStatus : global::FrooxEngine.Component

{
    public global::System.String UniverseId;
public global::System.String UniverseName;
public global::System.String PrimaryGroupId;
public global::System.Boolean InUniverse;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UniverseId", UniverseId.ToResoniteLinkField());
members.Add("UniverseName", UniverseName.ToResoniteLinkField());
members.Add("PrimaryGroupId", PrimaryGroupId.ToResoniteLinkField());
members.Add("InUniverse", InUniverse.ToResoniteLinkField());
}

}
}
