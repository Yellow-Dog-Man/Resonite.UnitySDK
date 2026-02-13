
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoTextureProvider
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoTextureProvider")]
public partial class VideoTextureProvider : global::FrooxEngine.AssetProvider<global::FrooxEngine.VideoTexture>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>, global::FrooxEngine.IPlayable, global::FrooxEngine.IWorldAudioDataSource, global::FrooxEngine.IStaticAssetProvider

{
    public System.Uri URL;
public global::System.Boolean Stream;
public global::System.Single Volume;
public global::System.String ForcePlaybackEngine;
public global::System.Boolean ForceVideoStreamingServiceParsing;
public global::System.String VideoTitle;
public global::System.String CurrentPlaybackEngine;
public global::System.Single CurrentClockError;
public global::Renderite.Shared.TextureFilterMode FilterMode;
public global::System.Int32 AnisotropicLevel;
public global::Renderite.Shared.TextureWrapMode WrapModeU;
public global::Renderite.Shared.TextureWrapMode WrapModeV;
public global::System.Nullable<global::System.Int32> AudioTrackIndex;
public global::System.Boolean PreferAudioOnly;
public global::System.Nullable<global::System.Int32> MaxWidth;
public global::System.Nullable<global::System.Int32> MaxHeight;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("Stream", Stream.ToResoniteLinkField());
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("ForcePlaybackEngine", ForcePlaybackEngine.ToResoniteLinkField());
members.Add("ForceVideoStreamingServiceParsing", ForceVideoStreamingServiceParsing.ToResoniteLinkField());
members.Add("VideoTitle", VideoTitle.ToResoniteLinkField());
members.Add("CurrentPlaybackEngine", CurrentPlaybackEngine.ToResoniteLinkField());
members.Add("CurrentClockError", CurrentClockError.ToResoniteLinkField());
members.Add("FilterMode", FilterMode.ToResoniteLinkField());
members.Add("AnisotropicLevel", AnisotropicLevel.ToResoniteLinkField());
members.Add("WrapModeU", WrapModeU.ToResoniteLinkField());
members.Add("WrapModeV", WrapModeV.ToResoniteLinkField());
members.Add("AudioTrackIndex", AudioTrackIndex.ToResoniteLinkField());
members.Add("PreferAudioOnly", PreferAudioOnly.ToResoniteLinkField());
members.Add("MaxWidth", MaxWidth.ToResoniteLinkField());
members.Add("MaxHeight", MaxHeight.ToResoniteLinkField());
}

}
}
