
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoTextureProvider
// Generated on: čtvrtek 26. února 2026 12:26:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoTextureProvider")]
public partial class VideoTextureProvider : global::FrooxEngine.AssetProvider<global::FrooxEngine.VideoTexture>, global::FrooxEngine.ITexture2DProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>, global::FrooxEngine.ITextureProvider, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>, global::FrooxEngine.IPlayable, global::FrooxEngine.IWorldAudioDataSource, global::FrooxEngine.IStaticAssetProvider

{
    public PlaybackState Playback { get => Playback_Element.Data; set => Playback_Element.Data = value; }
public Field<global::FrooxEngine.SyncPlayback, PlaybackState> Playback_Element = new();
public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::System.Boolean Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Stream_Element = new();
public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Volume_Element = new();
public global::System.String ForcePlaybackEngine { get => ForcePlaybackEngine_Element.Data; set => ForcePlaybackEngine_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ForcePlaybackEngine_Element = new();
public global::System.Boolean ForceVideoStreamingServiceParsing { get => ForceVideoStreamingServiceParsing_Element.Data; set => ForceVideoStreamingServiceParsing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceVideoStreamingServiceParsing_Element = new();
public global::System.String VideoTitle { get => VideoTitle_Element.Data; set => VideoTitle_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> VideoTitle_Element = new();
public global::System.String CurrentPlaybackEngine { get => CurrentPlaybackEngine_Element.Data; set => CurrentPlaybackEngine_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CurrentPlaybackEngine_Element = new();
public global::System.Single CurrentClockError { get => CurrentClockError_Element.Data; set => CurrentClockError_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> CurrentClockError_Element = new();
public global::Renderite.Shared.TextureFilterMode FilterMode { get => FilterMode_Element.Data; set => FilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFilterMode>, global::Renderite.Shared.TextureFilterMode> FilterMode_Element = new();
public global::System.Int32 AnisotropicLevel { get => AnisotropicLevel_Element.Data; set => AnisotropicLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> AnisotropicLevel_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeU { get => WrapModeU_Element.Data; set => WrapModeU_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeU_Element = new();
public global::Renderite.Shared.TextureWrapMode WrapModeV { get => WrapModeV_Element.Data; set => WrapModeV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureWrapMode>, global::Renderite.Shared.TextureWrapMode> WrapModeV_Element = new();
public global::System.Nullable<global::System.Int32> AudioTrackIndex { get => AudioTrackIndex_Element.Data; set => AudioTrackIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> AudioTrackIndex_Element = new();
public global::System.Boolean PreferAudioOnly { get => PreferAudioOnly_Element.Data; set => PreferAudioOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreferAudioOnly_Element = new();
public global::System.Nullable<global::System.Int32> MaxWidth { get => MaxWidth_Element.Data; set => MaxWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MaxWidth_Element = new();
public global::System.Nullable<global::System.Int32> MaxHeight { get => MaxHeight_Element.Data; set => MaxHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> MaxHeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playback", Playback_Element.ToLinkPlayback(context));
members.Add("URL", URL_Element.ToLinkField(context));
members.Add("Stream", Stream_Element.ToLinkField(context));
members.Add("Volume", Volume_Element.ToLinkField(context));
members.Add("ForcePlaybackEngine", ForcePlaybackEngine_Element.ToLinkField(context));
members.Add("ForceVideoStreamingServiceParsing", ForceVideoStreamingServiceParsing_Element.ToLinkField(context));
members.Add("VideoTitle", VideoTitle_Element.ToLinkField(context));
members.Add("CurrentPlaybackEngine", CurrentPlaybackEngine_Element.ToLinkField(context));
members.Add("CurrentClockError", CurrentClockError_Element.ToLinkField(context));
members.Add("FilterMode", FilterMode_Element.ToLinkField(context));
members.Add("AnisotropicLevel", AnisotropicLevel_Element.ToLinkField(context));
members.Add("WrapModeU", WrapModeU_Element.ToLinkField(context));
members.Add("WrapModeV", WrapModeV_Element.ToLinkField(context));
members.Add("AudioTrackIndex", AudioTrackIndex_Element.ToLinkField(context));
members.Add("PreferAudioOnly", PreferAudioOnly_Element.ToLinkField(context));
members.Add("MaxWidth", MaxWidth_Element.ToLinkField(context));
members.Add("MaxHeight", MaxHeight_Element.ToLinkField(context));
}

}
}
