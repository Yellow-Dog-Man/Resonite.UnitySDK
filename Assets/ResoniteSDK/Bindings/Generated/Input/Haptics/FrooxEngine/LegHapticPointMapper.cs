
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegHapticPointMapper
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegHapticPointMapper")]
public partial class LegHapticPointMapper : global::FrooxEngine.LimbHapticPointMapper<global::FrooxEngine.LegHapticPosition>

{
    public global::System.Single UpperLegRadius;
public global::System.Single KneeRadius;
public global::System.Single AnkleRadius;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UpperLegRadius", UpperLegRadius.ToResoniteLinkField());
members.Add("KneeRadius", KneeRadius.ToResoniteLinkField());
members.Add("AnkleRadius", AnkleRadius.ToResoniteLinkField());
}

}
}
