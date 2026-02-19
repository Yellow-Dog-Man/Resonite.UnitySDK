
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CylindricalDistanceHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CylindricalDistanceHapticFilter")]
public partial class CylindricalDistanceHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Single StartRadius;
public global::System.Single EndRadius;
public global::System.Single StartRadiusIntensity;
public global::System.Single EndRadiusIntensity;
public global::System.Single RadiusPower;
public global::System.Single StartAxisOffset;
public global::System.Single EndAxisOffset;
public global::System.Single StartAxisIntensity;
public global::System.Single EndAxisIntensity;
public global::System.Single AxisPower;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartRadius", StartRadius.ToResoniteLinkField());
members.Add("EndRadius", EndRadius.ToResoniteLinkField());
members.Add("StartRadiusIntensity", StartRadiusIntensity.ToResoniteLinkField());
members.Add("EndRadiusIntensity", EndRadiusIntensity.ToResoniteLinkField());
members.Add("RadiusPower", RadiusPower.ToResoniteLinkField());
members.Add("StartAxisOffset", StartAxisOffset.ToResoniteLinkField());
members.Add("EndAxisOffset", EndAxisOffset.ToResoniteLinkField());
members.Add("StartAxisIntensity", StartAxisIntensity.ToResoniteLinkField());
members.Add("EndAxisIntensity", EndAxisIntensity.ToResoniteLinkField());
members.Add("AxisPower", AxisPower.ToResoniteLinkField());
}

}
}
