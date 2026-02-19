
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleLifetimeSubEmitter
// Generated on: čtvrtek 19. února 2026 8:00:20
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleLifetimeSubEmitter")]
public partial class ParticleLifetimeSubEmitter : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single Rate;
public global::FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<global::PhotonDust.SubEmissionParametersWithDirection> Parameters;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rate", Rate.ToResoniteLinkField());
members.Add("Parameters", new ResoniteLink.SyncObject() { Members = Parameters.CollectMembers(context) });
}

}
}
