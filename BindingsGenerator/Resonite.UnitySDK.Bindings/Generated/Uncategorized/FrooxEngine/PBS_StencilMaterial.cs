
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_StencilMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_StencilMaterial")]
public abstract partial class PBS_StencilMaterial : global::FrooxEngine.MaterialProvider, global::FrooxEngine.IUIX_Material

{
    public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
public global::FrooxEngine.ColorMask ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ColorMask>, global::FrooxEngine.ColorMask> ColorMask_Element = new();
public global::FrooxEngine.StencilComparison StencilComparison { get => StencilComparison_Element.Data; set => StencilComparison_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilComparison>, global::FrooxEngine.StencilComparison> StencilComparison_Element = new();
public global::FrooxEngine.StencilOperation StencilOperation { get => StencilOperation_Element.Data; set => StencilOperation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.StencilOperation>, global::FrooxEngine.StencilOperation> StencilOperation_Element = new();
public global::System.Byte StencilID { get => StencilID_Element.Data; set => StencilID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilID_Element = new();
public global::System.Byte StencilWriteMask { get => StencilWriteMask_Element.Data; set => StencilWriteMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilWriteMask_Element = new();
public global::System.Byte StencilReadMask { get => StencilReadMask_Element.Data; set => StencilReadMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Byte>, global::System.Byte> StencilReadMask_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public UnityEngine.Rect __rectDummy { get => __rectDummy_Element.Data; set => __rectDummy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> __rectDummy_Element = new();
public global::System.Boolean __rectClipDummy { get => __rectClipDummy_Element.Data; set => __rectClipDummy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __rectClipDummy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextureScale", TextureScale_Element.Data.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor", AlbedoColor_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture", AlbedoTexture_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap", EmissiveMap_Element.Data.ToResoniteReference(context));
members.Add("NormalMap", NormalMap_Element.Data.ToResoniteReference(context));
members.Add("NormalScale", NormalScale_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMap", OcclusionMap_Element.Data.ToResoniteReference(context));
members.Add("ColorMask", ColorMask_Element.Data.ToResoniteLinkField());
members.Add("StencilComparison", StencilComparison_Element.Data.ToResoniteLinkField());
members.Add("StencilOperation", StencilOperation_Element.Data.ToResoniteLinkField());
members.Add("StencilID", StencilID_Element.Data.ToResoniteLinkField());
members.Add("StencilWriteMask", StencilWriteMask_Element.Data.ToResoniteLinkField());
members.Add("StencilReadMask", StencilReadMask_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
members.Add("__rectDummy", __rectDummy_Element.Data.ToResoniteLinkField());
members.Add("__rectClipDummy", __rectClipDummy_Element.Data.ToResoniteLinkField());
}

}
}
