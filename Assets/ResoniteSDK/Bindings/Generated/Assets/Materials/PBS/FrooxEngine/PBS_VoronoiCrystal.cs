
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VoronoiCrystal
// Generated on: sobota 14. února 2026 8:56:57
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VoronoiCrystal")]
public partial class PBS_VoronoiCrystal : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.Vector2 NoiseScale;
public global::System.Single NoiseAnimationOffset;
public UnityEngine.ColorX CellColorTint;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorGradient;
public UnityEngine.ColorX EmissionColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionGradient;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SmoothnessGradient;
public global::System.Single CellSmoothness;
public global::System.Single CellMetallic;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public global::System.Single NormalStrength;
public UnityEngine.Vector2 NormalTextureScale;
public UnityEngine.Vector2 NormalTextureOffset;
public global::System.Single EdgeThickness;
public UnityEngine.ColorX EdgeColor;
public UnityEngine.ColorX EdgeEmission;
public global::System.Single EdgeSmoothness;
public global::System.Single EdgeMetallic;
public global::System.Single EdgeNormalStrength;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NoiseScale", NoiseScale.ToResoniteLinkField());
members.Add("NoiseAnimationOffset", NoiseAnimationOffset.ToResoniteLinkField());
members.Add("CellColorTint", CellColorTint.ToResoniteLinkField());
members.Add("ColorGradient", ColorGradient.ToResoniteReference(context));
members.Add("EmissionColor", EmissionColor.ToResoniteLinkField());
members.Add("EmissionGradient", EmissionGradient.ToResoniteReference(context));
members.Add("SmoothnessGradient", SmoothnessGradient.ToResoniteReference(context));
members.Add("CellSmoothness", CellSmoothness.ToResoniteLinkField());
members.Add("CellMetallic", CellMetallic.ToResoniteLinkField());
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("NormalStrength", NormalStrength.ToResoniteLinkField());
members.Add("NormalTextureScale", NormalTextureScale.ToResoniteLinkField());
members.Add("NormalTextureOffset", NormalTextureOffset.ToResoniteLinkField());
members.Add("EdgeThickness", EdgeThickness.ToResoniteLinkField());
members.Add("EdgeColor", EdgeColor.ToResoniteLinkField());
members.Add("EdgeEmission", EdgeEmission.ToResoniteLinkField());
members.Add("EdgeSmoothness", EdgeSmoothness.ToResoniteLinkField());
members.Add("EdgeMetallic", EdgeMetallic.ToResoniteLinkField());
members.Add("EdgeNormalStrength", EdgeNormalStrength.ToResoniteLinkField());
}

}
}
