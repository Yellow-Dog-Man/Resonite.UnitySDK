
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VelocityHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VelocityHapticFilter")]
public partial class VelocityHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Single VelocitySmoothTime;
public global::System.Single StartVelocity;
public global::System.Single EndVelocity;
public global::System.Single StartIntensity;
public global::System.Single EndIntensity;
public global::System.Single Power;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VelocitySmoothTime", VelocitySmoothTime.ToResoniteLinkField());
members.Add("StartVelocity", StartVelocity.ToResoniteLinkField());
members.Add("EndVelocity", EndVelocity.ToResoniteLinkField());
members.Add("StartIntensity", StartIntensity.ToResoniteLinkField());
members.Add("EndIntensity", EndIntensity.ToResoniteLinkField());
members.Add("Power", Power.ToResoniteLinkField());
}

}
}
