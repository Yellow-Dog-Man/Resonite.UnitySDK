
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoPlayerInterface
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IField<System.Uri> URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> URL_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Stream_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture> VideoClip { get => VideoClip_Element.Data; set => VideoClip_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture>>, global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture>> VideoClip_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> VideoClipTexture { get => VideoClipTexture_Element.Data; set => VideoClipTexture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>> VideoClipTexture_Element = new();
public global::FrooxEngine.IField<global::System.Single> AspectRatio { get => AspectRatio_Element.Data; set => AspectRatio_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> AspectRatio_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture> DefaultVideoClip { get => DefaultVideoClip_Element.Data; set => DefaultVideoClip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.VideoTexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.VideoTexture>> DefaultVideoClip_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> StereoRenderingEnabled { get => StereoRenderingEnabled_Element.Data; set => StereoRenderingEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> StereoRenderingEnabled_Element = new();
public global::FrooxEngine.IField<global::Elements.Core.StereoLayout> StereoLayout { get => StereoLayout_Element.Data; set => StereoLayout_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::Elements.Core.StereoLayout>>, global::FrooxEngine.IField<global::Elements.Core.StereoLayout>> StereoLayout_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector4> StereoTransformLeft { get => StereoTransformLeft_Element.Data; set => StereoTransformLeft_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector4>>, global::FrooxEngine.IField<UnityEngine.Vector4>> StereoTransformLeft_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector4> StereoTransformRight { get => StereoTransformRight_Element.Data; set => StereoTransformRight_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector4>>, global::FrooxEngine.IField<UnityEngine.Vector4>> StereoTransformRight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformScaleLeft { get => StereoTransformScaleLeft_Element.Data; set => StereoTransformScaleLeft_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> StereoTransformScaleLeft_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformOffsetLeft { get => StereoTransformOffsetLeft_Element.Data; set => StereoTransformOffsetLeft_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> StereoTransformOffsetLeft_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformScaleRight { get => StereoTransformScaleRight_Element.Data; set => StereoTransformScaleRight_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> StereoTransformScaleRight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> StereoTransformOffsetRight { get => StereoTransformOffsetRight_Element.Data; set => StereoTransformOffsetRight_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector2>>, global::FrooxEngine.IField<UnityEngine.Vector2>> StereoTransformOffsetRight_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> PanoramicRenderingEnabled { get => PanoramicRenderingEnabled_Element.Data; set => PanoramicRenderingEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> PanoramicRenderingEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Single> PanoramicHorizontalFOV { get => PanoramicHorizontalFOV_Element.Data; set => PanoramicHorizontalFOV_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> PanoramicHorizontalFOV_Element = new();
public global::FrooxEngine.IField<global::System.Single> PanoramicVerticalFOV { get => PanoramicVerticalFOV_Element.Data; set => PanoramicVerticalFOV_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> PanoramicVerticalFOV_Element = new();
public global::FrooxEngine.IField<global::Elements.Core.PanoramicProjection> PanoramicProjection { get => PanoramicProjection_Element.Data; set => PanoramicProjection_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::Elements.Core.PanoramicProjection>>, global::FrooxEngine.IField<global::Elements.Core.PanoramicProjection>> PanoramicProjection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkReference(context));
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("VideoClip", VideoClip_Element.ToLinkReference(context));
members.Add("VideoClipTexture", VideoClipTexture_Element.ToLinkReference(context));
members.Add("AspectRatio", AspectRatio_Element.ToLinkReference(context));
members.Add("DefaultVideoClip", DefaultVideoClip_Element.ToLinkReference(context));
members.Add("StereoRenderingEnabled", StereoRenderingEnabled_Element.ToLinkReference(context));
members.Add("StereoLayout", StereoLayout_Element.ToLinkReference(context));
members.Add("StereoTransformLeft", StereoTransformLeft_Element.ToLinkReference(context));
members.Add("StereoTransformRight", StereoTransformRight_Element.ToLinkReference(context));
members.Add("StereoTransformScaleLeft", StereoTransformScaleLeft_Element.ToLinkReference(context));
members.Add("StereoTransformOffsetLeft", StereoTransformOffsetLeft_Element.ToLinkReference(context));
members.Add("StereoTransformScaleRight", StereoTransformScaleRight_Element.ToLinkReference(context));
members.Add("StereoTransformOffsetRight", StereoTransformOffsetRight_Element.ToLinkReference(context));
members.Add("PanoramicRenderingEnabled", PanoramicRenderingEnabled_Element.ToLinkReference(context));
members.Add("PanoramicHorizontalFOV", PanoramicHorizontalFOV_Element.ToLinkReference(context));
members.Add("PanoramicVerticalFOV", PanoramicVerticalFOV_Element.ToLinkReference(context));
members.Add("PanoramicProjection", PanoramicProjection_Element.ToLinkReference(context));
}

}
}
