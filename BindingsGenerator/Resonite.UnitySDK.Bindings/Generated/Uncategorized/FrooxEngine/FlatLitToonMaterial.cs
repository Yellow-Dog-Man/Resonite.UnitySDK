
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FlatLitToonMaterial
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FlatLitToonMaterial")]
public partial class FlatLitToonMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ICommonMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MainTexture { get => MainTexture_Element.Data; set => MainTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MainTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMask { get => ColorMask_Element.Data; set => ColorMask_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ColorMask_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionMap { get => EmissionMap_Element.Data; set => EmissionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissionMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public UnityEngine.Vector2 MainTextureScale { get => MainTextureScale_Element.Data; set => MainTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MainTextureScale_Element = new();
public UnityEngine.Vector2 MainTextureOffset { get => MainTextureOffset_Element.Data; set => MainTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MainTextureOffset_Element = new();
public UnityEngine.Vector2 ColorMaskScale { get => ColorMaskScale_Element.Data; set => ColorMaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMaskScale_Element = new();
public UnityEngine.Vector2 ColorMaskOffset { get => ColorMaskOffset_Element.Data; set => ColorMaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorMaskOffset_Element = new();
public UnityEngine.Vector2 EmissionMapScale { get => EmissionMapScale_Element.Data; set => EmissionMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapScale_Element = new();
public UnityEngine.Vector2 EmissionMapOffset { get => EmissionMapOffset_Element.Data; set => EmissionMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> EmissionMapOffset_Element = new();
public UnityEngine.Vector2 NormalMapScale { get => NormalMapScale_Element.Data; set => NormalMapScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapScale_Element = new();
public UnityEngine.Vector2 NormalMapOffset { get => NormalMapOffset_Element.Data; set => NormalMapOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> NormalMapOffset_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public UnityEngine.ColorX EmissionColor { get => EmissionColor_Element.Data; set => EmissionColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissionColor_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::System.Single Shadow { get => Shadow_Element.Data; set => Shadow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Shadow_Element = new();
public global::FrooxEngine.FlatLitToonMaterial.OutlineStyle Outline { get => Outline_Element.Data; set => Outline_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FlatLitToonMaterial.OutlineStyle>, global::FrooxEngine.FlatLitToonMaterial.OutlineStyle> Outline_Element = new();
public global::System.Single OutlineWidth { get => OutlineWidth_Element.Data; set => OutlineWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineWidth_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public global::System.Single OutlineTint { get => OutlineTint_Element.Data; set => OutlineTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutlineTint_Element = new();
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
members.Add("MainTexture", MainTexture_Element.ToLinkReference(context));
members.Add("ColorMask", ColorMask_Element.ToLinkReference(context));
members.Add("EmissionMap", EmissionMap_Element.ToLinkReference(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("MainTextureScale", MainTextureScale_Element.ToLinkField(context));
members.Add("MainTextureOffset", MainTextureOffset_Element.ToLinkField(context));
members.Add("ColorMaskScale", ColorMaskScale_Element.ToLinkField(context));
members.Add("ColorMaskOffset", ColorMaskOffset_Element.ToLinkField(context));
members.Add("EmissionMapScale", EmissionMapScale_Element.ToLinkField(context));
members.Add("EmissionMapOffset", EmissionMapOffset_Element.ToLinkField(context));
members.Add("NormalMapScale", NormalMapScale_Element.ToLinkField(context));
members.Add("NormalMapOffset", NormalMapOffset_Element.ToLinkField(context));
members.Add("AlphaCutoff", AlphaCutoff_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("EmissionColor", EmissionColor_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("Shadow", Shadow_Element.ToLinkField(context));
members.Add("Outline", Outline_Element.ToLinkField(context));
members.Add("OutlineWidth", OutlineWidth_Element.ToLinkField(context));
members.Add("OutlineColor", OutlineColor_Element.ToLinkField(context));
members.Add("OutlineTint", OutlineTint_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
