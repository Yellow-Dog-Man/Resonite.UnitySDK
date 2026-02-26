
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_ColorMask
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_ColorMask")]
public abstract partial class PBS_ColorMask : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.Vector2 ColorMaskScale { get => ColorMaskScale_Element.Data; set => ColorMaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMaskScale_Element = new();
public UnityEngine.Vector2 ColorMaskOffset { get => ColorMaskOffset_Element.Data; set => ColorMaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMaskOffset_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ColorMask_Element = new();
public UnityEngine.ColorX AlbedoColor0 { get => AlbedoColor0_Element.Data; set => AlbedoColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor0_Element = new();
public UnityEngine.ColorX AlbedoColor1 { get => AlbedoColor1_Element.Data; set => AlbedoColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor1_Element = new();
public UnityEngine.ColorX AlbedoColor2 { get => AlbedoColor2_Element.Data; set => AlbedoColor2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor2_Element = new();
public UnityEngine.ColorX AlbedoColor3 { get => AlbedoColor3_Element.Data; set => AlbedoColor3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor0 { get => EmissiveColor0_Element.Data; set => EmissiveColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor0_Element = new();
public UnityEngine.ColorX EmissiveColor1 { get => EmissiveColor1_Element.Data; set => EmissiveColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor1_Element = new();
public UnityEngine.ColorX EmissiveColor2 { get => EmissiveColor2_Element.Data; set => EmissiveColor2_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor2_Element = new();
public UnityEngine.ColorX EmissiveColor3 { get => EmissiveColor3_Element.Data; set => EmissiveColor3_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor3_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public global::System.Boolean Transparent { get => Transparent_Element.Data; set => Transparent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Transparent_Element = new();
public global::System.Boolean ForceZWrite { get => ForceZWrite_Element.Data; set => ForceZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceZWrite_Element = new();
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
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("ColorMaskScale", ColorMaskScale_Element.Data.ToResoniteLinkField());
members.Add("ColorMaskOffset", ColorMaskOffset_Element.Data.ToResoniteLinkField());
members.Add("ColorMask", ColorMask_Element.Data.ToResoniteReference(context));
members.Add("AlbedoColor0", AlbedoColor0_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor2", AlbedoColor2_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor3", AlbedoColor3_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor2", EmissiveColor2_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor3", EmissiveColor3_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap_Element.Data.ToResoniteReference(context));
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("NormalScale", NormalScale_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap_Element.Data.ToResoniteReference(context));
members.Add("Transparent", Transparent_Element.Data.ToResoniteLinkField());
members.Add("ForceZWrite", ForceZWrite_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
