
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyDistributionAdapter
// Generated on: pátek 6. března 2026 14:19:09
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::System.Boolean UseRandomDistribution { get => UseRandomDistribution_Element.Data; set => UseRandomDistribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseRandomDistribution_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.ParticleFollowerDistribution> Distribution { get => Distribution_Element.Data; set => Distribution_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::PhotonDust.ParticleFollowerDistribution>, global::FrooxEngine.IField<global::PhotonDust.ParticleFollowerDistribution>> Distribution_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseRandomDistribution", UseRandomDistribution_Element.ToLinkField(context));
members.Add("Distribution", Distribution_Element.ToLinkReference(context));
}

}
}
