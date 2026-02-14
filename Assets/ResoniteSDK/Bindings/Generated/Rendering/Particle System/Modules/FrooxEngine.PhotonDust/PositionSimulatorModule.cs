
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorModule
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorModule")]
public partial class PositionSimulatorModule : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Boolean Collisions;
public global::System.Single CollisionLifetimeLossRatio;
public global::System.Single CollisionBounceRatio;
public global::FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters CollisionSubEmission;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Collisions", Collisions.ToResoniteLinkField());
members.Add("CollisionLifetimeLossRatio", CollisionLifetimeLossRatio.ToResoniteLinkField());
members.Add("CollisionBounceRatio", CollisionBounceRatio.ToResoniteLinkField());
members.Add("CollisionSubEmission", new ResoniteLink.SyncObject() { Members = CollisionSubEmission.CollectMembers(context) });
}

}
}
