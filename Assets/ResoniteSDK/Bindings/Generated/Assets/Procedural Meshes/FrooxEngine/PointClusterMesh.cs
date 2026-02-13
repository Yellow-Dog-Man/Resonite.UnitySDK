
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointClusterMesh
// Generated on: pátek 13. února 2026 5:51:08
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.PointClusterMesh.DistributionType Distribution;
public global::FrooxEngine.PointClusterMesh.ColorMode Colors;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> TextureColorSource;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> HeightScaleSource;
public global::System.Single TextureIntensityClip;
public global::System.Single TextureAlphaClip;
public global::System.Int32 MaxClipAttempts;
public global::System.Single HeightmapExp;
public global::System.Int32 Seed;
public global::System.Int32 Points;
public global::FrooxEngine.AtlasInfo Atlas;
public UnityEngine.Vector3 Scale;
public global::System.Single RangeExp;
public UnityEngine.Vector3 JitterRange;
public UnityEngine.ColorX Color0;
public UnityEngine.ColorX Color1;
public global::System.Single ColorLerpScale;
public global::System.Single ColorGap;
public UnityEngine.Vector3 SimplexNoiseScale;
public UnityEngine.Vector3 SimplexNoiseOffset;
public global::System.Boolean UniformSize;
public UnityEngine.Vector2 MinSize;
public UnityEngine.Vector2 MaxSize;
public global::System.Single MinRotation;
public global::System.Single MaxRotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Distribution", Distribution.ToResoniteLinkField());
members.Add("Colors", Colors.ToResoniteLinkField());
members.Add("TextureColorSource", new ResoniteLink.Reference() { });
members.Add("HeightScaleSource", new ResoniteLink.Reference() { });
members.Add("TextureIntensityClip", TextureIntensityClip.ToResoniteLinkField());
members.Add("TextureAlphaClip", TextureAlphaClip.ToResoniteLinkField());
members.Add("MaxClipAttempts", MaxClipAttempts.ToResoniteLinkField());
members.Add("HeightmapExp", HeightmapExp.ToResoniteLinkField());
members.Add("Seed", Seed.ToResoniteLinkField());
members.Add("Points", Points.ToResoniteLinkField());
members.Add("Atlas", new ResoniteLink.Reference() { });
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("RangeExp", RangeExp.ToResoniteLinkField());
members.Add("JitterRange", JitterRange.ToResoniteLinkField());
members.Add("Color0", Color0.ToResoniteLinkField());
members.Add("Color1", Color1.ToResoniteLinkField());
members.Add("ColorLerpScale", ColorLerpScale.ToResoniteLinkField());
members.Add("ColorGap", ColorGap.ToResoniteLinkField());
members.Add("SimplexNoiseScale", SimplexNoiseScale.ToResoniteLinkField());
members.Add("SimplexNoiseOffset", SimplexNoiseOffset.ToResoniteLinkField());
members.Add("UniformSize", UniformSize.ToResoniteLinkField());
members.Add("MinSize", MinSize.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("MinRotation", MinRotation.ToResoniteLinkField());
members.Add("MaxRotation", MaxRotation.ToResoniteLinkField());
}

}
}
