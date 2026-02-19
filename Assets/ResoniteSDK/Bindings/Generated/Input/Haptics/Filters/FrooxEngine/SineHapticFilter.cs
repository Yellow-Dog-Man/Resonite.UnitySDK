
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SineHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SineHapticFilter")]
public partial class SineHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Boolean UseGlobalTime;
public global::System.Nullable<global::System.Single> DistanceScale;
public global::System.Nullable<UnityEngine.Vector3> AxisScale;
public global::System.Single MinIntensity;
public global::System.Single MaxIntensity;
public global::System.Single Frequency;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseGlobalTime", UseGlobalTime.ToResoniteLinkField());
members.Add("DistanceScale", DistanceScale.ToResoniteLinkField());
members.Add("AxisScale", AxisScale.ToResoniteLinkField());
members.Add("MinIntensity", MinIntensity.ToResoniteLinkField());
members.Add("MaxIntensity", MaxIntensity.ToResoniteLinkField());
members.Add("Frequency", Frequency.ToResoniteLinkField());
}

}
}
