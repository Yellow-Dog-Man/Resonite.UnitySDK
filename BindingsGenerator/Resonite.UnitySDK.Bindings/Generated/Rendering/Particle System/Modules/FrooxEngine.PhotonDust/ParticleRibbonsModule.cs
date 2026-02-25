
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleRibbonsModule
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleRibbonsModule")]
public partial class ParticleRibbonsModule : global::FrooxEngine.PhotonDust.TrailRendererModule<global::System.Object>

{
    public global::System.Single RibbonPointRatio;
public global::PhotonDust.ParticleFollowerDistribution Distribution;
public global::System.Int32 MaxRibbonPoints;
public global::System.Int32 InterweavedRibbonCount;
public global::System.Boolean UseParticleColor;
public global::System.Boolean UseParticleSize;
public global::System.Boolean ShuffleInterweavedRibbons;
public global::PhotonDust.UniformSizeMode SizeInheritanceMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RibbonPointRatio", RibbonPointRatio.ToResoniteLinkField());
members.Add("Distribution", Distribution.ToResoniteLinkField());
members.Add("MaxRibbonPoints", MaxRibbonPoints.ToResoniteLinkField());
members.Add("InterweavedRibbonCount", InterweavedRibbonCount.ToResoniteLinkField());
members.Add("UseParticleColor", UseParticleColor.ToResoniteLinkField());
members.Add("UseParticleSize", UseParticleSize.ToResoniteLinkField());
members.Add("ShuffleInterweavedRibbons", ShuffleInterweavedRibbons.ToResoniteLinkField());
members.Add("SizeInheritanceMode", SizeInheritanceMode.ToResoniteLinkField());
}

}
}
