
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointClusterMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointClusterMesh")]
public partial class PointClusterMesh : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.PointClusterMesh.DistributionType Distribution { get => Distribution_Element.Data; set => Distribution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PointClusterMesh.DistributionType>, global::FrooxEngine.PointClusterMesh.DistributionType> Distribution_Element = new();
public global::FrooxEngine.PointClusterMesh.ColorMode Colors { get => Colors_Element.Data; set => Colors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PointClusterMesh.ColorMode>, global::FrooxEngine.PointClusterMesh.ColorMode> Colors_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> TextureColorSource { get => TextureColorSource_Element.Data; set => TextureColorSource_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>> TextureColorSource_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> HeightScaleSource { get => HeightScaleSource_Element.Data; set => HeightScaleSource_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> HeightScaleSource_Element = new();
public global::System.Single TextureIntensityClip { get => TextureIntensityClip_Element.Data; set => TextureIntensityClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TextureIntensityClip_Element = new();
public global::System.Single TextureAlphaClip { get => TextureAlphaClip_Element.Data; set => TextureAlphaClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TextureAlphaClip_Element = new();
public global::System.Int32 MaxClipAttempts { get => MaxClipAttempts_Element.Data; set => MaxClipAttempts_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxClipAttempts_Element = new();
public global::System.Single HeightmapExp { get => HeightmapExp_Element.Data; set => HeightmapExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightmapExp_Element = new();
public global::System.Int32 Seed { get => Seed_Element.Data; set => Seed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Seed_Element = new();
public global::System.Int32 Points { get => Points_Element.Data; set => Points_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Points_Element = new();
public global::FrooxEngine.AtlasInfo Atlas { get => Atlas_Element.Data; set => Atlas_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.AtlasInfo>, global::FrooxEngine.AtlasInfo> Atlas_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public global::System.Single RangeExp { get => RangeExp_Element.Data; set => RangeExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RangeExp_Element = new();
public UnityEngine.Vector3 JitterRange { get => JitterRange_Element.Data; set => JitterRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> JitterRange_Element = new();
public UnityEngine.ColorX Color0 { get => Color0_Element.Data; set => Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color0_Element = new();
public UnityEngine.ColorX Color1 { get => Color1_Element.Data; set => Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color1_Element = new();
public global::System.Single ColorLerpScale { get => ColorLerpScale_Element.Data; set => ColorLerpScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorLerpScale_Element = new();
public global::System.Single ColorGap { get => ColorGap_Element.Data; set => ColorGap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ColorGap_Element = new();
public UnityEngine.Vector3 SimplexNoiseScale { get => SimplexNoiseScale_Element.Data; set => SimplexNoiseScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SimplexNoiseScale_Element = new();
public UnityEngine.Vector3 SimplexNoiseOffset { get => SimplexNoiseOffset_Element.Data; set => SimplexNoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> SimplexNoiseOffset_Element = new();
public global::System.Boolean UniformSize { get => UniformSize_Element.Data; set => UniformSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UniformSize_Element = new();
public UnityEngine.Vector2 MinSize { get => MinSize_Element.Data; set => MinSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MinSize_Element = new();
public UnityEngine.Vector2 MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> MaxSize_Element = new();
public global::System.Single MinRotation { get => MinRotation_Element.Data; set => MinRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinRotation_Element = new();
public global::System.Single MaxRotation { get => MaxRotation_Element.Data; set => MaxRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Distribution", Distribution_Element.ToLinkField(context));
members.Add("Colors", Colors_Element.ToLinkField(context));
members.Add("TextureColorSource", TextureColorSource_Element.ToLinkReference(context));
members.Add("HeightScaleSource", HeightScaleSource_Element.ToLinkReference(context));
members.Add("TextureIntensityClip", TextureIntensityClip_Element.ToLinkField(context));
members.Add("TextureAlphaClip", TextureAlphaClip_Element.ToLinkField(context));
members.Add("MaxClipAttempts", MaxClipAttempts_Element.ToLinkField(context));
members.Add("HeightmapExp", HeightmapExp_Element.ToLinkField(context));
members.Add("Seed", Seed_Element.ToLinkField(context));
members.Add("Points", Points_Element.ToLinkField(context));
members.Add("Atlas", Atlas_Element.ToLinkReference(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("RangeExp", RangeExp_Element.ToLinkField(context));
members.Add("JitterRange", JitterRange_Element.ToLinkField(context));
members.Add("Color0", Color0_Element.ToLinkField(context));
members.Add("Color1", Color1_Element.ToLinkField(context));
members.Add("ColorLerpScale", ColorLerpScale_Element.ToLinkField(context));
members.Add("ColorGap", ColorGap_Element.ToLinkField(context));
members.Add("SimplexNoiseScale", SimplexNoiseScale_Element.ToLinkField(context));
members.Add("SimplexNoiseOffset", SimplexNoiseOffset_Element.ToLinkField(context));
members.Add("UniformSize", UniformSize_Element.ToLinkField(context));
members.Add("MinSize", MinSize_Element.ToLinkField(context));
members.Add("MaxSize", MaxSize_Element.ToLinkField(context));
members.Add("MinRotation", MinRotation_Element.ToLinkField(context));
members.Add("MaxRotation", MaxRotation_Element.ToLinkField(context));
}

}
}
