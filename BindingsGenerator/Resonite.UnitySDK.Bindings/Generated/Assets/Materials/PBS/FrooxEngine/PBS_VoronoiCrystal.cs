
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VoronoiCrystal
// Generated on: čtvrtek 26. února 2026 10:03:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public UnityEngine.Vector2 NoiseScale { get => NoiseScale_Element.Data; set => NoiseScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NoiseScale_Element = new();
public global::System.Single NoiseAnimationOffset { get => NoiseAnimationOffset_Element.Data; set => NoiseAnimationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoiseAnimationOffset_Element = new();
public UnityEngine.ColorX CellColorTint { get => CellColorTint_Element.Data; set => CellColorTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CellColorTint_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorGradient { get => ColorGradient_Element.Data; set => ColorGradient_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ColorGradient_Element = new();
public UnityEngine.ColorX EmissionColor { get => EmissionColor_Element.Data; set => EmissionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissionColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionGradient { get => EmissionGradient_Element.Data; set => EmissionGradient_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissionGradient_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SmoothnessGradient { get => SmoothnessGradient_Element.Data; set => SmoothnessGradient_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> SmoothnessGradient_Element = new();
public global::System.Single CellSmoothness { get => CellSmoothness_Element.Data; set => CellSmoothness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CellSmoothness_Element = new();
public global::System.Single CellMetallic { get => CellMetallic_Element.Data; set => CellMetallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CellMetallic_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalStrength { get => NormalStrength_Element.Data; set => NormalStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalStrength_Element = new();
public UnityEngine.Vector2 NormalTextureScale { get => NormalTextureScale_Element.Data; set => NormalTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalTextureScale_Element = new();
public UnityEngine.Vector2 NormalTextureOffset { get => NormalTextureOffset_Element.Data; set => NormalTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalTextureOffset_Element = new();
public global::System.Single EdgeThickness { get => EdgeThickness_Element.Data; set => EdgeThickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeThickness_Element = new();
public UnityEngine.ColorX EdgeColor { get => EdgeColor_Element.Data; set => EdgeColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EdgeColor_Element = new();
public UnityEngine.ColorX EdgeEmission { get => EdgeEmission_Element.Data; set => EdgeEmission_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EdgeEmission_Element = new();
public global::System.Single EdgeSmoothness { get => EdgeSmoothness_Element.Data; set => EdgeSmoothness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeSmoothness_Element = new();
public global::System.Single EdgeMetallic { get => EdgeMetallic_Element.Data; set => EdgeMetallic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeMetallic_Element = new();
public global::System.Single EdgeNormalStrength { get => EdgeNormalStrength_Element.Data; set => EdgeNormalStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeNormalStrength_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NoiseScale", NoiseScale_Element.Data.ToResoniteLinkField());
members.Add("NoiseAnimationOffset", NoiseAnimationOffset_Element.Data.ToResoniteLinkField());
members.Add("CellColorTint", CellColorTint_Element.Data.ToResoniteLinkField());
members.Add("ColorGradient", ColorGradient_Element.Data.ToResoniteReference(context));
members.Add("EmissionColor", EmissionColor_Element.Data.ToResoniteLinkField());
members.Add("EmissionGradient", EmissionGradient_Element.Data.ToResoniteReference(context));
members.Add("SmoothnessGradient", SmoothnessGradient_Element.Data.ToResoniteReference(context));
members.Add("CellSmoothness", CellSmoothness_Element.Data.ToResoniteLinkField());
members.Add("CellMetallic", CellMetallic_Element.Data.ToResoniteLinkField());
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("NormalStrength", NormalStrength_Element.Data.ToResoniteLinkField());
members.Add("NormalTextureScale", NormalTextureScale_Element.Data.ToResoniteLinkField());
members.Add("NormalTextureOffset", NormalTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("EdgeThickness", EdgeThickness_Element.Data.ToResoniteLinkField());
members.Add("EdgeColor", EdgeColor_Element.Data.ToResoniteLinkField());
members.Add("EdgeEmission", EdgeEmission_Element.Data.ToResoniteLinkField());
members.Add("EdgeSmoothness", EdgeSmoothness_Element.Data.ToResoniteLinkField());
members.Add("EdgeMetallic", EdgeMetallic_Element.Data.ToResoniteLinkField());
members.Add("EdgeNormalStrength", EdgeNormalStrength_Element.Data.ToResoniteLinkField());
}

}
}
