
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DepthProjectionMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DepthProjectionMaterial")]
public partial class DepthProjectionMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Color_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Depth { get => Depth_Element.Data; set => Depth_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Depth_Element = new();
public global::FrooxEngine.DepthEncoding DepthEncoding { get => DepthEncoding_Element.Data; set => DepthEncoding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.DepthEncoding>, global::FrooxEngine.DepthEncoding> DepthEncoding_Element = new();
public UnityEngine.Vector2 ColorTextureOffset { get => ColorTextureOffset_Element.Data; set => ColorTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorTextureOffset_Element = new();
public UnityEngine.Vector2 ColorTextureScale { get => ColorTextureScale_Element.Data; set => ColorTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> ColorTextureScale_Element = new();
public UnityEngine.Vector2 DepthTextureOffset { get => DepthTextureOffset_Element.Data; set => DepthTextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DepthTextureOffset_Element = new();
public UnityEngine.Vector2 DepthTextureScale { get => DepthTextureScale_Element.Data; set => DepthTextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> DepthTextureScale_Element = new();
public global::System.Single DepthFrom { get => DepthFrom_Element.Data; set => DepthFrom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthFrom_Element = new();
public global::System.Single DepthTo { get => DepthTo_Element.Data; set => DepthTo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthTo_Element = new();
public UnityEngine.Vector2 FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FieldOfView_Element = new();
public global::System.Single NearClip { get => NearClip_Element.Data; set => NearClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearClip_Element = new();
public global::System.Single FarClip { get => FarClip_Element.Data; set => FarClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarClip_Element = new();
public global::System.Single DiscardThreshold { get => DiscardThreshold_Element.Data; set => DiscardThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DiscardThreshold_Element = new();
public global::System.Single DiscardOffset { get => DiscardOffset_Element.Data; set => DiscardOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DiscardOffset_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.ToLinkReference(context));
members.Add("Depth", Depth_Element.ToLinkReference(context));
members.Add("DepthEncoding", DepthEncoding_Element.ToLinkField(context));
members.Add("ColorTextureOffset", ColorTextureOffset_Element.ToLinkField(context));
members.Add("ColorTextureScale", ColorTextureScale_Element.ToLinkField(context));
members.Add("DepthTextureOffset", DepthTextureOffset_Element.ToLinkField(context));
members.Add("DepthTextureScale", DepthTextureScale_Element.ToLinkField(context));
members.Add("DepthFrom", DepthFrom_Element.ToLinkField(context));
members.Add("DepthTo", DepthTo_Element.ToLinkField(context));
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("NearClip", NearClip_Element.ToLinkField(context));
members.Add("FarClip", FarClip_Element.ToLinkField(context));
members.Add("DiscardThreshold", DiscardThreshold_Element.ToLinkField(context));
members.Add("DiscardOffset", DiscardOffset_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
}

}
}
