
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBSLerpMaterial")]
public abstract partial class PBSLerpMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::System.Single Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Lerp_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> LerpTexture { get => LerpTexture_Element.Data; set => LerpTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> LerpTexture_Element = new();
public UnityEngine.Vector2 LerpTextureScale { get => LerpTextureScale_Element.Data; set => LerpTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LerpTextureScale_Element = new();
public UnityEngine.Vector2 LerpTextureOffset { get => LerpTextureOffset_Element.Data; set => LerpTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LerpTextureOffset_Element = new();
public UnityEngine.Vector2 Texture0Scale { get => Texture0Scale_Element.Data; set => Texture0Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Texture0Scale_Element = new();
public UnityEngine.Vector2 Texture0Offset { get => Texture0Offset_Element.Data; set => Texture0Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Texture0Offset_Element = new();
public UnityEngine.Vector2 Texture1Scale { get => Texture1Scale_Element.Data; set => Texture1Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Texture1Scale_Element = new();
public UnityEngine.Vector2 Texture1Offset { get => Texture1Offset_Element.Data; set => Texture1Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Texture1Offset_Element = new();
public UnityEngine.ColorX AlbedoColor0 { get => AlbedoColor0_Element.Data; set => AlbedoColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor0_Element = new();
public UnityEngine.ColorX AlbedoColor1 { get => AlbedoColor1_Element.Data; set => AlbedoColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture0 { get => AlbedoTexture0_Element.Data; set => AlbedoTexture0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture1 { get => AlbedoTexture1_Element.Data; set => AlbedoTexture1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture1_Element = new();
public UnityEngine.ColorX EmissiveColor0 { get => EmissiveColor0_Element.Data; set => EmissiveColor0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor0_Element = new();
public UnityEngine.ColorX EmissiveColor1 { get => EmissiveColor1_Element.Data; set => EmissiveColor1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap0 { get => EmissiveMap0_Element.Data; set => EmissiveMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap1 { get => EmissiveMap1_Element.Data; set => EmissiveMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap1_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap0 { get => NormalMap0_Element.Data; set => NormalMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap1 { get => NormalMap1_Element.Data; set => NormalMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap1_Element = new();
public global::System.Single NormalScale0 { get => NormalScale0_Element.Data; set => NormalScale0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale0_Element = new();
public global::System.Single NormalScale1 { get => NormalScale1_Element.Data; set => NormalScale1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale1_Element = new();
public global::System.Boolean MultiValue { get => MultiValue_Element.Data; set => MultiValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MultiValue_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap0 { get => OcclusionMap0_Element.Data; set => OcclusionMap0_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap0_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap1 { get => OcclusionMap1_Element.Data; set => OcclusionMap1_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap1_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::FrooxEngine.Culling Culling { get => Culling_Element.Data; set => Culling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> Culling_Element = new();
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
members.Add("Lerp", Lerp_Element.Data.ToResoniteLinkField());
members.Add("LerpTexture", LerpTexture_Element.Data.ToResoniteReference(context));
members.Add("LerpTextureScale", LerpTextureScale_Element.Data.ToResoniteLinkField());
members.Add("LerpTextureOffset", LerpTextureOffset_Element.Data.ToResoniteLinkField());
members.Add("Texture0Scale", Texture0Scale_Element.Data.ToResoniteLinkField());
members.Add("Texture0Offset", Texture0Offset_Element.Data.ToResoniteLinkField());
members.Add("Texture1Scale", Texture1Scale_Element.Data.ToResoniteLinkField());
members.Add("Texture1Offset", Texture1Offset_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor0", AlbedoColor0_Element.Data.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1_Element.Data.ToResoniteLinkField());
members.Add("AlbedoTexture0", AlbedoTexture0_Element.Data.ToResoniteReference(context));
members.Add("AlbedoTexture1", AlbedoTexture1_Element.Data.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0_Element.Data.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1_Element.Data.ToResoniteLinkField());
members.Add("EmissiveMap0", EmissiveMap0_Element.Data.ToResoniteReference(context));
members.Add("EmissiveMap1", EmissiveMap1_Element.Data.ToResoniteReference(context));
members.Add("NormalMap0", NormalMap0_Element.Data.ToResoniteReference(context));
members.Add("NormalMap1", NormalMap1_Element.Data.ToResoniteReference(context));
members.Add("NormalScale0", NormalScale0_Element.Data.ToResoniteLinkField());
members.Add("NormalScale1", NormalScale1_Element.Data.ToResoniteLinkField());
members.Add("MultiValue", MultiValue_Element.Data.ToResoniteLinkField());
members.Add("OcclusionMap0", OcclusionMap0_Element.Data.ToResoniteReference(context));
members.Add("OcclusionMap1", OcclusionMap1_Element.Data.ToResoniteReference(context));
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff_Element.Data.ToResoniteLinkField());
members.Add("ZWrite", ZWrite_Element.Data.ToResoniteLinkField());
members.Add("ZTest", ZTest_Element.Data.ToResoniteLinkField());
members.Add("Culling", Culling_Element.Data.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor_Element.Data.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits_Element.Data.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue_Element.Data.ToResoniteLinkField());
}

}
}
