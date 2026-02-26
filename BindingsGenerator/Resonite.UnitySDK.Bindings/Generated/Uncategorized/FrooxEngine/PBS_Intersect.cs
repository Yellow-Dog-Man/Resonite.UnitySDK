
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Intersect
// Generated on: čtvrtek 26. února 2026 12:26:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Intersect")]
public abstract partial class PBS_Intersect : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.IPBS_Material, global::FrooxEngine.ICullingMaterial

{
    public global::System.Single BeginTransitionStart { get => BeginTransitionStart_Element.Data; set => BeginTransitionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BeginTransitionStart_Element = new();
public global::System.Single BeginTransitionEnd { get => BeginTransitionEnd_Element.Data; set => BeginTransitionEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BeginTransitionEnd_Element = new();
public global::System.Single EndTransitionStart { get => EndTransitionStart_Element.Data; set => EndTransitionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndTransitionStart_Element = new();
public global::System.Single EndTransitionEnd { get => EndTransitionEnd_Element.Data; set => EndTransitionEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndTransitionEnd_Element = new();
public UnityEngine.Vector2 TextureScale { get => TextureScale_Element.Data; set => TextureScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureScale_Element = new();
public UnityEngine.Vector2 TextureOffset { get => TextureOffset_Element.Data; set => TextureOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> TextureOffset_Element = new();
public UnityEngine.ColorX AlbedoColor { get => AlbedoColor_Element.Data; set => AlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> AlbedoColor_Element = new();
public UnityEngine.ColorX IntersectAlbedoColor { get => IntersectAlbedoColor_Element.Data; set => IntersectAlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> IntersectAlbedoColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> AlbedoTexture { get => AlbedoTexture_Element.Data; set => AlbedoTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> AlbedoTexture_Element = new();
public UnityEngine.ColorX EmissiveColor { get => EmissiveColor_Element.Data; set => EmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EmissiveColor_Element = new();
public UnityEngine.ColorX IntersectEmissiveColor { get => IntersectEmissiveColor_Element.Data; set => IntersectEmissiveColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> IntersectEmissiveColor_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> EmissiveMap { get => EmissiveMap_Element.Data; set => EmissiveMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> EmissiveMap_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> NormalMap { get => NormalMap_Element.Data; set => NormalMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> NormalMap_Element = new();
public global::System.Single NormalScale { get => NormalScale_Element.Data; set => NormalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalScale_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> OcclusionMap { get => OcclusionMap_Element.Data; set => OcclusionMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> OcclusionMap_Element = new();
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
members.Add("BeginTransitionStart", BeginTransitionStart_Element.ToLinkField(context));
members.Add("BeginTransitionEnd", BeginTransitionEnd_Element.ToLinkField(context));
members.Add("EndTransitionStart", EndTransitionStart_Element.ToLinkField(context));
members.Add("EndTransitionEnd", EndTransitionEnd_Element.ToLinkField(context));
members.Add("TextureScale", TextureScale_Element.ToLinkField(context));
members.Add("TextureOffset", TextureOffset_Element.ToLinkField(context));
members.Add("AlbedoColor", AlbedoColor_Element.ToLinkField(context));
members.Add("IntersectAlbedoColor", IntersectAlbedoColor_Element.ToLinkField(context));
members.Add("AlbedoTexture", AlbedoTexture_Element.ToLinkReference(context));
members.Add("EmissiveColor", EmissiveColor_Element.ToLinkField(context));
members.Add("IntersectEmissiveColor", IntersectEmissiveColor_Element.ToLinkField(context));
members.Add("EmissiveMap", EmissiveMap_Element.ToLinkReference(context));
members.Add("NormalMap", NormalMap_Element.ToLinkReference(context));
members.Add("NormalScale", NormalScale_Element.ToLinkField(context));
members.Add("OcclusionMap", OcclusionMap_Element.ToLinkReference(context));
members.Add("Culling", Culling_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
