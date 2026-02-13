
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude
// Generated on: pátek 13. února 2026 23:23:06
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude")]
public partial class PivotFromVelocityMagnitude : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 PivotBaseOffset;
public UnityEngine.Vector3 PivotClampMin;
public UnityEngine.Vector3 PivotClampMax;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PivotBaseOffset", PivotBaseOffset.ToResoniteLinkField());
members.Add("PivotClampMin", PivotClampMin.ToResoniteLinkField());
members.Add("PivotClampMax", PivotClampMax.ToResoniteLinkField());
}

}
}
