
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleLightsModule
// Generated on: čtvrtek 26. února 2026 12:28:04
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.Light TemplateLight { get => TemplateLight_Element.Data; set => TemplateLight_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> TemplateLight_Element = new();
public global::System.Single LightsRatio { get => LightsRatio_Element.Data; set => LightsRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LightsRatio_Element = new();
public global::PhotonDust.ParticleFollowerDistribution Distribution { get => Distribution_Element.Data; set => Distribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ParticleFollowerDistribution>, global::PhotonDust.ParticleFollowerDistribution> Distribution_Element = new();
public global::System.Int32 MaxLights { get => MaxLights_Element.Data; set => MaxLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxLights_Element = new();
public global::System.Boolean MultiplyColorByParticle { get => MultiplyColorByParticle_Element.Data; set => MultiplyColorByParticle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiplyColorByParticle_Element = new();
public global::System.Boolean MultiplyIntensityByAlpha { get => MultiplyIntensityByAlpha_Element.Data; set => MultiplyIntensityByAlpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiplyIntensityByAlpha_Element = new();
public global::System.Boolean MultiplyRangeBySize { get => MultiplyRangeBySize_Element.Data; set => MultiplyRangeBySize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiplyRangeBySize_Element = new();
public global::PhotonDust.ParticleLightsModule.AngleMultiplier AngleMultiplier { get => AngleMultiplier_Element.Data; set => AngleMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ParticleLightsModule.AngleMultiplier>, global::PhotonDust.ParticleLightsModule.AngleMultiplier> AngleMultiplier_Element = new();
public global::System.Single RangeMultiplier { get => RangeMultiplier_Element.Data; set => RangeMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RangeMultiplier_Element = new();
public global::System.Single IntensityMultiplier { get => IntensityMultiplier_Element.Data; set => IntensityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IntensityMultiplier_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TemplateLight", TemplateLight_Element.ToLinkReference(context));
members.Add("LightsRatio", LightsRatio_Element.ToLinkField(context));
members.Add("Distribution", Distribution_Element.ToLinkField(context));
members.Add("MaxLights", MaxLights_Element.ToLinkField(context));
members.Add("MultiplyColorByParticle", MultiplyColorByParticle_Element.ToLinkField(context));
members.Add("MultiplyIntensityByAlpha", MultiplyIntensityByAlpha_Element.ToLinkField(context));
members.Add("MultiplyRangeBySize", MultiplyRangeBySize_Element.ToLinkField(context));
members.Add("AngleMultiplier", AngleMultiplier_Element.ToLinkField(context));
members.Add("RangeMultiplier", RangeMultiplier_Element.ToLinkField(context));
members.Add("IntensityMultiplier", IntensityMultiplier_Element.ToLinkField(context));
}

}
}
