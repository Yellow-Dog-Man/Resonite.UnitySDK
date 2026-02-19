
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FlatLitToonMaterial
// Generated on: čtvrtek 19. února 2026 8:00:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FlatLitToonMaterial")]
public partial class FlatLitToonMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ICommonMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MainTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ColorMask;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissionMap;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap;
public UnityEngine.Vector2 MainTextureScale;
public UnityEngine.Vector2 MainTextureOffset;
public UnityEngine.Vector2 ColorMaskScale;
public UnityEngine.Vector2 ColorMaskOffset;
public UnityEngine.Vector2 EmissionMapScale;
public UnityEngine.Vector2 EmissionMapOffset;
public UnityEngine.Vector2 NormalMapScale;
public UnityEngine.Vector2 NormalMapOffset;
public global::System.Single AlphaCutoff;
public UnityEngine.ColorX Color;
public UnityEngine.ColorX EmissionColor;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Single Shadow;
public global::FrooxEngine.FlatLitToonMaterial.OutlineStyle Outline;
public global::System.Single OutlineWidth;
public UnityEngine.ColorX OutlineColor;
public global::System.Single OutlineTint;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MainTexture", MainTexture.ToResoniteReference(context));
members.Add("ColorMask", ColorMask.ToResoniteReference(context));
members.Add("EmissionMap", EmissionMap.ToResoniteReference(context));
members.Add("NormalMap", NormalMap.ToResoniteReference(context));
members.Add("MainTextureScale", MainTextureScale.ToResoniteLinkField());
members.Add("MainTextureOffset", MainTextureOffset.ToResoniteLinkField());
members.Add("ColorMaskScale", ColorMaskScale.ToResoniteLinkField());
members.Add("ColorMaskOffset", ColorMaskOffset.ToResoniteLinkField());
members.Add("EmissionMapScale", EmissionMapScale.ToResoniteLinkField());
members.Add("EmissionMapOffset", EmissionMapOffset.ToResoniteLinkField());
members.Add("NormalMapScale", NormalMapScale.ToResoniteLinkField());
members.Add("NormalMapOffset", NormalMapOffset.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("EmissionColor", EmissionColor.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("Shadow", Shadow.ToResoniteLinkField());
members.Add("Outline", Outline.ToResoniteLinkField());
members.Add("OutlineWidth", OutlineWidth.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("OutlineTint", OutlineTint.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
