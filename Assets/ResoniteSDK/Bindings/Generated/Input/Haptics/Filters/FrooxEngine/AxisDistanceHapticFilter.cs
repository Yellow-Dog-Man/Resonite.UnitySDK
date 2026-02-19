
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisDistanceHapticFilter
// Generated on: čtvrtek 19. února 2026 7:58:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisDistanceHapticFilter")]
public partial class AxisDistanceHapticFilter : global::FrooxEngine.HapticFilter

{
    public UnityEngine.Vector3 Axis;
public global::System.Single StartDistance;
public global::System.Single EndDistance;
public global::System.Single StartIntensity;
public global::System.Single EndIntensity;
public global::System.Single Power;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis.ToResoniteLinkField());
members.Add("StartDistance", StartDistance.ToResoniteLinkField());
members.Add("EndDistance", EndDistance.ToResoniteLinkField());
members.Add("StartIntensity", StartIntensity.ToResoniteLinkField());
members.Add("EndIntensity", EndIntensity.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
}

}
}
