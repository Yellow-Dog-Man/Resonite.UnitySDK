
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegHapticPointMapper
// Generated on: středa 25. února 2026 16:13:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegHapticPointMapper")]
public partial class LegHapticPointMapper : global::FrooxEngine.LimbHapticPointMapper<global::FrooxEngine.LegHapticPosition>

{
    public global::System.Single UpperLegRadius;
public global::System.Single KneeRadius;
public global::System.Single AnkleRadius;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpperLegRadius", UpperLegRadius.ToResoniteLinkField());
members.Add("KneeRadius", KneeRadius.ToResoniteLinkField());
members.Add("AnkleRadius", AnkleRadius.ToResoniteLinkField());
}

}
}
