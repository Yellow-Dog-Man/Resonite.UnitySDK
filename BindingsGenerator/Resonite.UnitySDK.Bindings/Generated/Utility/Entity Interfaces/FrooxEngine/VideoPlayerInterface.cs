
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoPlayerInterface
// Generated on: středa 25. února 2026 16:14:47
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteReference(context));
members.Add("Stream", Stream.ToResoniteReference(context));
members.Add("VideoClip", VideoClip.ToResoniteReference(context));
members.Add("VideoClipTexture", VideoClipTexture.ToResoniteReference(context));
members.Add("AspectRatio", AspectRatio.ToResoniteReference(context));
members.Add("DefaultVideoClip", DefaultVideoClip.ToResoniteReference(context));
members.Add("StereoRenderingEnabled", StereoRenderingEnabled.ToResoniteReference(context));
members.Add("StereoLayout", StereoLayout.ToResoniteReference(context));
members.Add("StereoTransformLeft", StereoTransformLeft.ToResoniteReference(context));
members.Add("StereoTransformRight", StereoTransformRight.ToResoniteReference(context));
members.Add("StereoTransformScaleLeft", StereoTransformScaleLeft.ToResoniteReference(context));
members.Add("StereoTransformOffsetLeft", StereoTransformOffsetLeft.ToResoniteReference(context));
members.Add("StereoTransformScaleRight", StereoTransformScaleRight.ToResoniteReference(context));
members.Add("StereoTransformOffsetRight", StereoTransformOffsetRight.ToResoniteReference(context));
members.Add("PanoramicRenderingEnabled", PanoramicRenderingEnabled.ToResoniteReference(context));
members.Add("PanoramicHorizontalFOV", PanoramicHorizontalFOV.ToResoniteReference(context));
members.Add("PanoramicVerticalFOV", PanoramicVerticalFOV.ToResoniteReference(context));
members.Add("PanoramicProjection", PanoramicProjection.ToResoniteReference(context));
}

}
}
