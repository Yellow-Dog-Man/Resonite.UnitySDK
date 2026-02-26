
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorModule
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Boolean Collisions { get => Collisions_Element.Data; set => Collisions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Collisions_Element = new();
public global::System.Single CollisionLifetimeLossRatio { get => CollisionLifetimeLossRatio_Element.Data; set => CollisionLifetimeLossRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CollisionLifetimeLossRatio_Element = new();
public global::System.Single CollisionBounceRatio { get => CollisionBounceRatio_Element.Data; set => CollisionBounceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CollisionBounceRatio_Element = new();
public global::FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters CollisionSubEmission = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Collisions", Collisions_Element.ToLinkField(context));
members.Add("CollisionLifetimeLossRatio", CollisionLifetimeLossRatio_Element.ToLinkField(context));
members.Add("CollisionBounceRatio", CollisionBounceRatio_Element.ToLinkField(context));
members.Add("CollisionSubEmission", CollisionSubEmission.ToLinkSyncObject(context));
}

}
}
