
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude
// Generated on: středa 25. února 2026 16:14:18
// Resonite version: 2026.2.25.455
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
