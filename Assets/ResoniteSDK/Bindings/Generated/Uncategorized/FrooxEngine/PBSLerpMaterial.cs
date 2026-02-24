
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBSLerpMaterial
// Generated on: úterý 24. února 2026 18:17:36
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Single Lerp;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> LerpTexture;
public UnityEngine.Vector2 LerpTextureScale;
public UnityEngine.Vector2 LerpTextureOffset;
public UnityEngine.Vector2 Texture0Scale;
public UnityEngine.Vector2 Texture0Offset;
public UnityEngine.Vector2 Texture1Scale;
public UnityEngine.Vector2 Texture1Offset;
public UnityEngine.ColorX AlbedoColor0;
public UnityEngine.ColorX AlbedoColor1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture1;
public UnityEngine.ColorX EmissiveColor0;
public UnityEngine.ColorX EmissiveColor1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap1;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap1;
public global::System.Single NormalScale0;
public global::System.Single NormalScale1;
public global::System.Boolean MultiValue;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap0;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap1;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::FrooxEngine.Culling Culling;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("LerpTexture", LerpTexture.ToResoniteReference(context));
members.Add("LerpTextureScale", LerpTextureScale.ToResoniteLinkField());
members.Add("LerpTextureOffset", LerpTextureOffset.ToResoniteLinkField());
members.Add("Texture0Scale", Texture0Scale.ToResoniteLinkField());
members.Add("Texture0Offset", Texture0Offset.ToResoniteLinkField());
members.Add("Texture1Scale", Texture1Scale.ToResoniteLinkField());
members.Add("Texture1Offset", Texture1Offset.ToResoniteLinkField());
members.Add("AlbedoColor0", AlbedoColor0.ToResoniteLinkField());
members.Add("AlbedoColor1", AlbedoColor1.ToResoniteLinkField());
members.Add("AlbedoTexture0", AlbedoTexture0.ToResoniteReference(context));
members.Add("AlbedoTexture1", AlbedoTexture1.ToResoniteReference(context));
members.Add("EmissiveColor0", EmissiveColor0.ToResoniteLinkField());
members.Add("EmissiveColor1", EmissiveColor1.ToResoniteLinkField());
members.Add("EmissiveMap0", EmissiveMap0.ToResoniteReference(context));
members.Add("EmissiveMap1", EmissiveMap1.ToResoniteReference(context));
members.Add("NormalMap0", NormalMap0.ToResoniteReference(context));
members.Add("NormalMap1", NormalMap1.ToResoniteReference(context));
members.Add("NormalScale0", NormalScale0.ToResoniteLinkField());
members.Add("NormalScale1", NormalScale1.ToResoniteLinkField());
members.Add("MultiValue", MultiValue.ToResoniteLinkField());
members.Add("OcclusionMap0", OcclusionMap0.ToResoniteReference(context));
members.Add("OcclusionMap1", OcclusionMap1.ToResoniteReference(context));
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("Culling", Culling.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
