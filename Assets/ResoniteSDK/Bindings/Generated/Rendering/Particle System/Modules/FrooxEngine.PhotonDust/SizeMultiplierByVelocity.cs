
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity
// Generated on: čtvrtek 19. února 2026 8:00:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity")]
public partial class SizeMultiplierByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 VelocityMultiplier;
public UnityEngine.Vector3Bool VelocityMask;
public UnityEngine.Vector3 MultiplierClampMin;
public UnityEngine.Vector3 MultiplierClampMax;
public UnityEngine.Vector3 ResultClampMin;
public UnityEngine.Vector3 ResultClampMax;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VelocityMultiplier", VelocityMultiplier.ToResoniteLinkField());
members.Add("VelocityMask", VelocityMask.ToResoniteLinkField());
members.Add("MultiplierClampMin", MultiplierClampMin.ToResoniteLinkField());
members.Add("MultiplierClampMax", MultiplierClampMax.ToResoniteLinkField());
members.Add("ResultClampMin", ResultClampMin.ToResoniteLinkField());
members.Add("ResultClampMax", ResultClampMax.ToResoniteLinkField());
}

}
}
