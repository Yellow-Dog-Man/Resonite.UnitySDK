
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude")]
public partial class PivotFromVelocityMagnitude : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 PivotBaseOffset;
public UnityEngine.Vector3 PivotClampMin;
public UnityEngine.Vector3 PivotClampMax;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PivotBaseOffset", PivotBaseOffset.ToResoniteLinkField());
members.Add("PivotClampMin", PivotClampMin.ToResoniteLinkField());
members.Add("PivotClampMax", PivotClampMax.ToResoniteLinkField());
}

}
}
