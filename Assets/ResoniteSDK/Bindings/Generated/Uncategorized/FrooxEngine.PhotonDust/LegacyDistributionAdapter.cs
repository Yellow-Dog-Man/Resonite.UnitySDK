
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyDistributionAdapter
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyDistributionAdapter")]
public partial class LegacyDistributionAdapter : global::FrooxEngine.Component

{
    public global::System.Boolean UseRandomDistribution;
public global::FrooxEngine.IField<global::PhotonDust.ParticleFollowerDistribution> Distribution;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseRandomDistribution", UseRandomDistribution.ToResoniteLinkField());
members.Add("Distribution", Distribution.ToResoniteReference(context));
}

}
}
