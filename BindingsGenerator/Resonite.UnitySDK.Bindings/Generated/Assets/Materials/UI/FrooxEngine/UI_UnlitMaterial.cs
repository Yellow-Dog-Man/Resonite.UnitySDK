
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_UnlitMaterial
// Generated on: čtvrtek 26. února 2026 12:26:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_UnlitMaterial")]
public partial class UI_UnlitMaterial : global::FrooxEngine.SingleShaderUI_StencilMaterial, global::FrooxEngine.ICommonMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX Tint { get => Tint_Element.Data; set => Tint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Tint_Element = new();
public global::System.Boolean Overlay { get => Overlay_Element.Data; set => Overlay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Overlay_Element = new();
public UnityEngine.ColorX OverlayTint { get => OverlayTint_Element.Data; set => OverlayTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OverlayTint_Element = new();
public global::System.Single AlphaCutoff { get => AlphaCutoff_Element.Data; set => AlphaCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AlphaCutoff_Element = new();
public global::System.Boolean AlphaClip { get => AlphaClip_Element.Data; set => AlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlphaClip_Element = new();
public global::FrooxEngine.UnlitTextureMode TextureMode { get => TextureMode_Element.Data; set => TextureMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UnlitTextureMode>, global::FrooxEngine.UnlitTextureMode> TextureMode_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> MaskTexture { get => MaskTexture_Element.Data; set => MaskTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> MaskTexture_Element = new();
public UnityEngine.Vector2 MaskScale { get => MaskScale_Element.Data; set => MaskScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskScale_Element = new();
public UnityEngine.Vector2 MaskOffset { get => MaskOffset_Element.Data; set => MaskOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaskOffset_Element = new();
public global::FrooxEngine.MaskTextureMode MaskMode { get => MaskMode_Element.Data; set => MaskMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MaskTextureMode>, global::FrooxEngine.MaskTextureMode> MaskMode_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("TextureScale", TextureScale_Element.ToLinkField(context));
members.Add("TextureOffset", TextureOffset_Element.ToLinkField(context));
members.Add("Tint", Tint_Element.ToLinkField(context));
members.Add("Overlay", Overlay_Element.ToLinkField(context));
members.Add("OverlayTint", OverlayTint_Element.ToLinkField(context));
members.Add("AlphaCutoff", AlphaCutoff_Element.ToLinkField(context));
members.Add("AlphaClip", AlphaClip_Element.ToLinkField(context));
members.Add("TextureMode", TextureMode_Element.ToLinkField(context));
members.Add("MaskTexture", MaskTexture_Element.ToLinkReference(context));
members.Add("MaskScale", MaskScale_Element.ToLinkField(context));
members.Add("MaskOffset", MaskOffset_Element.ToLinkField(context));
members.Add("MaskMode", MaskMode_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
}

}
}
