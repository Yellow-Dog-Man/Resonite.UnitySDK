
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters
// Generated on: sobota 14. února 2026 8:58:35
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters")]
public partial class PositionSimulatorSubEmissionParameters : global::FrooxEngine.PhotonDust.SubEmissionParameters<global::PhotonDust.PositionSimulatorSubEmissionParameters>

{
    public global::System.Boolean InheritLifetime;
public global::PhotonDust.PositionSimulatorSubEmissionParameters.VelocityInheritanceMode VelocityInheritanceMode;
public global::System.Single RandomDirectionWeight;
public global::System.Int32 CollisionEmissionMin;
public global::System.Int32 CollisionEmissionMax;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InheritLifetime", InheritLifetime.ToResoniteLinkField());
members.Add("VelocityInheritanceMode", VelocityInheritanceMode.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("CollisionEmissionMin", CollisionEmissionMin.ToResoniteLinkField());
members.Add("CollisionEmissionMax", CollisionEmissionMax.ToResoniteLinkField());
}

}
}
