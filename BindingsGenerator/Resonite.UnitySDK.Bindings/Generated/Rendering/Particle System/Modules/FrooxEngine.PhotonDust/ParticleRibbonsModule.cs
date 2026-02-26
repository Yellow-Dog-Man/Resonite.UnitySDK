
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleRibbonsModule
// Generated on: čtvrtek 26. února 2026 10:04:38
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
    public global::System.Single RibbonPointRatio { get => RibbonPointRatio_Element.Data; set => RibbonPointRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RibbonPointRatio_Element = new();
public global::PhotonDust.ParticleFollowerDistribution Distribution { get => Distribution_Element.Data; set => Distribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ParticleFollowerDistribution>, global::PhotonDust.ParticleFollowerDistribution> Distribution_Element = new();
public global::System.Int32 MaxRibbonPoints { get => MaxRibbonPoints_Element.Data; set => MaxRibbonPoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxRibbonPoints_Element = new();
public global::System.Int32 InterweavedRibbonCount { get => InterweavedRibbonCount_Element.Data; set => InterweavedRibbonCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> InterweavedRibbonCount_Element = new();
public global::System.Boolean UseParticleColor { get => UseParticleColor_Element.Data; set => UseParticleColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseParticleColor_Element = new();
public global::System.Boolean UseParticleSize { get => UseParticleSize_Element.Data; set => UseParticleSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseParticleSize_Element = new();
public global::System.Boolean ShuffleInterweavedRibbons { get => ShuffleInterweavedRibbons_Element.Data; set => ShuffleInterweavedRibbons_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShuffleInterweavedRibbons_Element = new();
public global::PhotonDust.UniformSizeMode SizeInheritanceMode { get => SizeInheritanceMode_Element.Data; set => SizeInheritanceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.UniformSizeMode>, global::PhotonDust.UniformSizeMode> SizeInheritanceMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RibbonPointRatio", RibbonPointRatio_Element.Data.ToResoniteLinkField());
members.Add("Distribution", Distribution_Element.Data.ToResoniteLinkField());
members.Add("MaxRibbonPoints", MaxRibbonPoints_Element.Data.ToResoniteLinkField());
members.Add("InterweavedRibbonCount", InterweavedRibbonCount_Element.Data.ToResoniteLinkField());
members.Add("UseParticleColor", UseParticleColor_Element.Data.ToResoniteLinkField());
members.Add("UseParticleSize", UseParticleSize_Element.Data.ToResoniteLinkField());
members.Add("ShuffleInterweavedRibbons", ShuffleInterweavedRibbons_Element.Data.ToResoniteLinkField());
members.Add("SizeInheritanceMode", SizeInheritanceMode_Element.Data.ToResoniteLinkField());
}

}
}
