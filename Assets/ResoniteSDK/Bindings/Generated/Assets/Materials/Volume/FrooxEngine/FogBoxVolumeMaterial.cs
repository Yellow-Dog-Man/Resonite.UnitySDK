
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FogBoxVolumeMaterial
// Generated on: čtvrtek 19. února 2026 7:58:52
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FogBoxVolumeMaterial")]
public partial class FogBoxVolumeMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX BaseColor;
public UnityEngine.ColorX AccumulationColor;
public UnityEngine.ColorX AccumulationColorBottom;
public UnityEngine.ColorX AccumulationColorTop;
public global::System.Single FogStart;
public global::System.Single FogEnd;
public global::System.Single FogDensity;
public global::System.Single GammaCurve;
public global::System.Boolean WorldSpace;
public global::FrooxEngine.FogBoxVolumeMaterial.Color ColorMode;
public global::FrooxEngine.FogBoxVolumeMaterial.Saturation SaturationMode;
public global::FrooxEngine.FogBoxVolumeMaterial.Accumulation AccumulationMode;
public global::System.Single AccumulationRate;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("AccumulationColor", AccumulationColor.ToResoniteLinkField());
members.Add("AccumulationColorBottom", AccumulationColorBottom.ToResoniteLinkField());
members.Add("AccumulationColorTop", AccumulationColorTop.ToResoniteLinkField());
members.Add("FogStart", FogStart.ToResoniteLinkField());
members.Add("FogEnd", FogEnd.ToResoniteLinkField());
members.Add("FogDensity", FogDensity.ToResoniteLinkField());
members.Add("GammaCurve", GammaCurve.ToResoniteLinkField());
members.Add("WorldSpace", WorldSpace.ToResoniteLinkField());
members.Add("ColorMode", ColorMode.ToResoniteLinkField());
members.Add("SaturationMode", SaturationMode.ToResoniteLinkField());
members.Add("AccumulationMode", AccumulationMode.ToResoniteLinkField());
members.Add("AccumulationRate", AccumulationRate.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
