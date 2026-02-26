
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorSplat
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorSplat")]
public abstract partial class PBS_ColorSplat : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Boolean MultiValue { get => MultiValue_Element.Data; set => MultiValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiValue_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMap { get => ColorMap_Element.Data; set => ColorMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ColorMap_Element = new();
public UnityEngine.Vector2 ColorMapScale { get => ColorMapScale_Element.Data; set => ColorMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMapScale_Element = new();
public UnityEngine.Vector2 ColorMapOffset { get => ColorMapOffset_Element.Data; set => ColorMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMapOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedHeightMap { get => PackedHeightMap_Element.Data; set => PackedHeightMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> PackedHeightMap_Element = new();
public global::System.Single HeightTransitionRange { get => HeightTransitionRange_Element.Data; set => HeightTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightTransitionRange_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor0 { get => AlbedoColor0_Element.Data; set => AlbedoColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor0_Element = new();
public UnityEngine.ColorX AlbedoColor1 { get => AlbedoColor1_Element.Data; set => AlbedoColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor1_Element = new();
public UnityEngine.ColorX AlbedoColor2 { get => AlbedoColor2_Element.Data; set => AlbedoColor2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor2_Element = new();
public UnityEngine.ColorX AlbedoColor3 { get => AlbedoColor3_Element.Data; set => AlbedoColor3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture0 { get => AlbedoTexture0_Element.Data; set => AlbedoTexture0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture1 { get => AlbedoTexture1_Element.Data; set => AlbedoTexture1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture2 { get => AlbedoTexture2_Element.Data; set => AlbedoTexture2_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture2_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture3 { get => AlbedoTexture3_Element.Data; set => AlbedoTexture3_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture3_Element = new();
public UnityEngine.ColorX EmissiveColor0 { get => EmissiveColor0_Element.Data; set => EmissiveColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor0_Element = new();
public UnityEngine.ColorX EmissiveColor1 { get => EmissiveColor1_Element.Data; set => EmissiveColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor1_Element = new();
public UnityEngine.ColorX EmissiveColor2 { get => EmissiveColor2_Element.Data; set => EmissiveColor2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor2_Element = new();
public UnityEngine.ColorX EmissiveColor3 { get => EmissiveColor3_Element.Data; set => EmissiveColor3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap0 { get => EmissiveMap0_Element.Data; set => EmissiveMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap1 { get => EmissiveMap1_Element.Data; set => EmissiveMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap2 { get => EmissiveMap2_Element.Data; set => EmissiveMap2_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap2_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap3 { get => EmissiveMap3_Element.Data; set => EmissiveMap3_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedEmissionMap { get => PackedEmissionMap_Element.Data; set => PackedEmissionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> PackedEmissionMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedNormalMap01 { get => PackedNormalMap01_Element.Data; set => PackedNormalMap01_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> PackedNormalMap01_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> PackedNormalMap23 { get => PackedNormalMap23_Element.Data; set => PackedNormalMap23_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> PackedNormalMap23_Element = new();
public global::System.Single NormalScale0 { get => NormalScale0_Element.Data; set => NormalScale0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale0_Element = new();
public global::System.Single NormalScale1 { get => NormalScale1_Element.Data; set => NormalScale1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale1_Element = new();
public global::System.Single NormalScale2 { get => NormalScale2_Element.Data; set => NormalScale2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale2_Element = new();
public global::System.Single NormalScale3 { get => NormalScale3_Element.Data; set => NormalScale3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale3_Element = new();
public global::System.Single AlphaClip { get => AlphaClip_Element.Data; set => AlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaClip_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MultiValue", MultiValue_Element.Data.ToResoniteLinkField());
members.Add("ColorMap", ColorMap_Element.Data.ToResoniteReference(context));
members.Add("ColorMapScale", ColorMapScale_Element.Data.ToResoniteLinkField());
members.Add("ColorMapOffset", ColorMapOffset_Element.Data.ToResoniteLinkField());
members.Add("PackedHeightMap", PackedHeightMap_Element.Data.ToResoniteReference(context));
members.Add("HeightTransitionRange", HeightTransitionRange_Element.Data.ToResoniteLinkField());
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor0", AlbedoColor0_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor2", AlbedoColor2_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor3", AlbedoColor3_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture0", AlbedoTexture0_Element.Data.ToResoniteReference(context));
members.Add("AlbedoTexture1", AlbedoTexture1_Element.Data.ToResoniteReference(context));
members.Add("AlbedoTexture2", AlbedoTexture2_Element.Data.ToResoniteReference(context));
members.Add("AlbedoTexture3", AlbedoTexture3_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor2", EmissiveColor2_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor3", EmissiveColor3_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap0", EmissiveMap0_Element.Data.ToResoniteReference(context));
members.Add("EmissiveMap1", EmissiveMap1_Element.Data.ToResoniteReference(context));
members.Add("EmissiveMap2", EmissiveMap2_Element.Data.ToResoniteReference(context));
members.Add("EmissiveMap3", EmissiveMap3_Element.Data.ToResoniteReference(context));
members.Add("PackedEmissionMap", PackedEmissionMap_Element.Data.ToResoniteReference(context));
members.Add("PackedNormalMap01", PackedNormalMap01_Element.Data.ToResoniteReference(context));
members.Add("PackedNormalMap23", PackedNormalMap23_Element.Data.ToResoniteReference(context));
members.Add("NormalScale0", NormalScale0_Element.Data.ToResoniteLinkField());
members.Add("NormalScale1", NormalScale1_Element.Data.ToResoniteLinkField());
members.Add("NormalScale2", NormalScale2_Element.Data.ToResoniteLinkField());
members.Add("NormalScale3", NormalScale3_Element.Data.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
