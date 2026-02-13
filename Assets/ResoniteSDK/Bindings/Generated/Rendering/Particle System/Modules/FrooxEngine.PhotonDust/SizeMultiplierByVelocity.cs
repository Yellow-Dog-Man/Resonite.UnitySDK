
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity")]
public partial class SizeMultiplierByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 VelocityMultiplier;
public UnityEngine.Vector3Bool VelocityMask;
public UnityEngine.Vector3 MultiplierClampMin;
public UnityEngine.Vector3 MultiplierClampMax;
public UnityEngine.Vector3 ResultClampMin;
public UnityEngine.Vector3 ResultClampMax;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VelocityMultiplier", VelocityMultiplier.ToResoniteLinkField());
members.Add("VelocityMask", VelocityMask.ToResoniteLinkField());
members.Add("MultiplierClampMin", MultiplierClampMin.ToResoniteLinkField());
members.Add("MultiplierClampMax", MultiplierClampMax.ToResoniteLinkField());
members.Add("ResultClampMin", ResultClampMin.ToResoniteLinkField());
members.Add("ResultClampMax", ResultClampMax.ToResoniteLinkField());
}

}
}
