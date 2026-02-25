
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_UnlitMaterial
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_UnlitMaterial")]
public partial class UI_UnlitMaterial : global::FrooxEngine.SingleShaderUI_StencilMaterial, global::FrooxEngine.ICommonMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Vector2 TextureScale;
public UnityEngine.Vector2 TextureOffset;
public UnityEngine.ColorX Tint;
public global::System.Boolean Overlay;
public UnityEngine.ColorX OverlayTint;
public global::System.Single AlphaCutoff;
public global::System.Boolean AlphaClip;
public global::FrooxEngine.UnlitTextureMode TextureMode;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture;
public UnityEngine.Vector2 MaskScale;
public UnityEngine.Vector2 MaskOffset;
public global::FrooxEngine.MaskTextureMode MaskMode;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;
public global::System.Single OffsetFactor;
public global::System.Single OffsetUnits;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("TextureScale", TextureScale.ToResoniteLinkField());
members.Add("TextureOffset", TextureOffset.ToResoniteLinkField());
members.Add("Tint", Tint.ToResoniteLinkField());
members.Add("Overlay", Overlay.ToResoniteLinkField());
members.Add("OverlayTint", OverlayTint.ToResoniteLinkField());
members.Add("AlphaCutoff", AlphaCutoff.ToResoniteLinkField());
members.Add("AlphaClip", AlphaClip.ToResoniteLinkField());
members.Add("TextureMode", TextureMode.ToResoniteLinkField());
members.Add("MaskTexture", MaskTexture.ToResoniteReference(context));
members.Add("MaskScale", MaskScale.ToResoniteLinkField());
members.Add("MaskOffset", MaskOffset.ToResoniteLinkField());
members.Add("MaskMode", MaskMode.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
members.Add("OffsetFactor", OffsetFactor.ToResoniteLinkField());
members.Add("OffsetUnits", OffsetUnits.ToResoniteLinkField());
}

}
}
