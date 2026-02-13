
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoPlayerInterface
// Generated on: pátek 13. února 2026 23:23:21
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoPlayerInterface")]
public partial class VideoPlayerInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> URL;
public global::FrooxEngine.IField<global::System.Boolean> Stream;
public global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture> VideoClip;
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> VideoClipTexture;
public global::FrooxEngine.IField<global::System.Single> AspectRatio;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> DefaultVideoClip;
public global::FrooxEngine.IField<global::System.Boolean> StereoRenderingEnabled;
public global::FrooxEngine.IField<global::Elements.Core.StereoLayout> StereoLayout;
public global::FrooxEngine.IField<UnityEngine.Vector4> StereoTransformLeft;
public global::FrooxEngine.IField<UnityEngine.Vector4> StereoTransformRight;
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformScaleLeft;
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformOffsetLeft;
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformScaleRight;
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformOffsetRight;
public global::FrooxEngine.IField<global::System.Boolean> PanoramicRenderingEnabled;
public global::FrooxEngine.IField<global::System.Single> PanoramicHorizontalFOV;
public global::FrooxEngine.IField<global::System.Single> PanoramicVerticalFOV;
public global::FrooxEngine.IField<global::Elements.Core.PanoramicProjection> PanoramicProjection;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", new ResoniteLink.Reference() { });
members.Add("Stream", new ResoniteLink.Reference() { });
members.Add("VideoClip", new ResoniteLink.Reference() { });
members.Add("VideoClipTexture", new ResoniteLink.Reference() { });
members.Add("AspectRatio", new ResoniteLink.Reference() { });
members.Add("DefaultVideoClip", new ResoniteLink.Reference() { });
members.Add("StereoRenderingEnabled", new ResoniteLink.Reference() { });
members.Add("StereoLayout", new ResoniteLink.Reference() { });
members.Add("StereoTransformLeft", new ResoniteLink.Reference() { });
members.Add("StereoTransformRight", new ResoniteLink.Reference() { });
members.Add("StereoTransformScaleLeft", new ResoniteLink.Reference() { });
members.Add("StereoTransformOffsetLeft", new ResoniteLink.Reference() { });
members.Add("StereoTransformScaleRight", new ResoniteLink.Reference() { });
members.Add("StereoTransformOffsetRight", new ResoniteLink.Reference() { });
members.Add("PanoramicRenderingEnabled", new ResoniteLink.Reference() { });
members.Add("PanoramicHorizontalFOV", new ResoniteLink.Reference() { });
members.Add("PanoramicVerticalFOV", new ResoniteLink.Reference() { });
members.Add("PanoramicProjection", new ResoniteLink.Reference() { });
}

}
}
