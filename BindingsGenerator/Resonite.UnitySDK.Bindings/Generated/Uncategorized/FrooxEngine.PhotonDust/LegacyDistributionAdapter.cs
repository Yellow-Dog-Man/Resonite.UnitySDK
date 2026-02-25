
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyDistributionAdapter
// Generated on: středa 25. února 2026 16:14:40
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
