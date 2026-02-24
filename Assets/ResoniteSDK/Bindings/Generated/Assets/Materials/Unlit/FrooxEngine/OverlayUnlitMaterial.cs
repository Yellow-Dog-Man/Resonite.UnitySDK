
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OverlayUnlitMaterial
// Generated on: úterý 24. února 2026 18:17:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OverlayUnlitMaterial")]
public partial class OverlayUnlitMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.ColorX BehindTintColor;
public UnityEngine.ColorX FrontTintColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BehindTexture;
public UnityEngine.Vector2 BehindTextureScale;
public UnityEngine.Vector2 BehindTextureOffset;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> FrontTexture;
public UnityEngine.Vector2 FrontTextureScale;
public UnityEngine.Vector2 FrontTextureOffset;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Single AlphaCutoff;
public global::System.Boolean UseVertexColors;
public global::Renderite.Shared.ColorProfile VertexColorInterpolationSpace;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::System.Boolean PolarUVmapping;
public global::System.Single PolarPower;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;
public global::System.Int32 RenderQueue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BehindTintColor", BehindTintColor.ToResoniteLinkField());
members.Add("FrontTintColor", FrontTintColor.ToResoniteLinkField());
members.Add("BehindTexture", BehindTexture.ToResoniteReference(context));
members.Add("BehindTextureScale", BehindTextureScale.ToResoniteLinkField());
members.Add("BehindTextureOffset", BehindTextureOffset.ToResoniteLinkField());
members.Add("FrontTexture", FrontTexture.ToResoniteReference(context));
members.Add("FrontTextureScale", FrontTextureScale.ToResoniteLinkField());
members.Add("FrontTextureOffset", FrontTextureOffset.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("VertexColorInterpolationSpace", VertexColorInterpolationSpace.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("PolarUVmapping", PolarUVmapping.ToResoniteLinkField());
members.Add("PolarPower", PolarPower.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
}

}
}
