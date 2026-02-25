
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleLightsModule
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleLightsModule")]
public partial class ParticleLightsModule : global::FrooxEngine.PhotonDust.ParticleSystemRendererModule<global::PhotonDust.ParticleLightsModule,global::System.Object>

{
    public global::FrooxEngine.Light TemplateLight;
public global::System.Single LightsRatio;
public global::PhotonDust.ParticleFollowerDistribution Distribution;
public global::System.Int32 MaxLights;
public global::System.Boolean MultiplyColorByParticle;
public global::System.Boolean MultiplyIntensityByAlpha;
public global::System.Boolean MultiplyRangeBySize;
public global::PhotonDust.ParticleLightsModule.AngleMultiplier AngleMultiplier;
public global::System.Single RangeMultiplier;
public global::System.Single IntensityMultiplier;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TemplateLight", TemplateLight.ToResoniteReference(context));
members.Add("LightsRatio", LightsRatio.ToResoniteLinkField());
members.Add("Distribution", Distribution.ToResoniteLinkField());
members.Add("MaxLights", MaxLights.ToResoniteLinkField());
members.Add("MultiplyColorByParticle", MultiplyColorByParticle.ToResoniteLinkField());
members.Add("MultiplyIntensityByAlpha", MultiplyIntensityByAlpha.ToResoniteLinkField());
members.Add("MultiplyRangeBySize", MultiplyRangeBySize.ToResoniteLinkField());
members.Add("AngleMultiplier", AngleMultiplier.ToResoniteLinkField());
members.Add("RangeMultiplier", RangeMultiplier.ToResoniteLinkField());
members.Add("IntensityMultiplier", IntensityMultiplier.ToResoniteLinkField());
}

}
}
