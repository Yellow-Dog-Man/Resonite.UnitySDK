
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyTrailsRibbonAdapter
// Generated on: středa 25. února 2026 16:14:41
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TrailsMode", TrailsMode.ToResoniteLinkField());
members.Add("ParticleSizeAffectsTrailWidth", ParticleSizeAffectsTrailWidth.ToResoniteLinkField());
members.Add("InheritTrailColorFromParticle", InheritTrailColorFromParticle.ToResoniteLinkField());
members.Add("TrailWorldSpace", TrailWorldSpace.ToResoniteLinkField());
members.Add("TrailsModule", TrailsModule.ToResoniteReference(context));
members.Add("RibbonModule", RibbonModule.ToResoniteReference(context));
members.Add("RibbonUseParticleSize", RibbonUseParticleSize.ToResoniteReference(context));
members.Add("RibbonUseParticleColor", RibbonUseParticleColor.ToResoniteReference(context));
members.Add("TrailSizeInheritance", TrailSizeInheritance.ToResoniteReference(context));
members.Add("TrailColorInheritance", TrailColorInheritance.ToResoniteReference(context));
members.Add("TrailsSpace", TrailsSpace.ToResoniteReference(context));
}

}
}
