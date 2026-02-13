
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyTrailsRibbonAdapter
// Generated on: pátek 13. února 2026 5:52:34
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyTrailsRibbonAdapter")]
public partial class LegacyTrailsRibbonAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.LegacyParticleTrailMode TrailsMode;
public global::System.Boolean ParticleSizeAffectsTrailWidth;
public global::System.Boolean InheritTrailColorFromParticle;
public global::System.Boolean TrailWorldSpace;
public global::FrooxEngine.IField<global::System.Boolean> TrailsModule;
public global::FrooxEngine.IField<global::System.Boolean> RibbonModule;
public global::FrooxEngine.IField<global::System.Boolean> RibbonUseParticleSize;
public global::FrooxEngine.IField<global::System.Boolean> RibbonUseParticleColor;
public global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance> TrailSizeInheritance;
public global::FrooxEngine.IField<global::PhotonDust.TrailParticleInheritance> TrailColorInheritance;
public global::FrooxEngine.RootSpace TrailsSpace;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TrailsMode", TrailsMode.ToResoniteLinkField());
members.Add("ParticleSizeAffectsTrailWidth", ParticleSizeAffectsTrailWidth.ToResoniteLinkField());
members.Add("InheritTrailColorFromParticle", InheritTrailColorFromParticle.ToResoniteLinkField());
members.Add("TrailWorldSpace", TrailWorldSpace.ToResoniteLinkField());
members.Add("TrailsModule", new ResoniteLink.Reference() { });
members.Add("RibbonModule", new ResoniteLink.Reference() { });
members.Add("RibbonUseParticleSize", new ResoniteLink.Reference() { });
members.Add("RibbonUseParticleColor", new ResoniteLink.Reference() { });
members.Add("TrailSizeInheritance", new ResoniteLink.Reference() { });
members.Add("TrailColorInheritance", new ResoniteLink.Reference() { });
members.Add("TrailsSpace", new ResoniteLink.Reference() { });
}

}
}
