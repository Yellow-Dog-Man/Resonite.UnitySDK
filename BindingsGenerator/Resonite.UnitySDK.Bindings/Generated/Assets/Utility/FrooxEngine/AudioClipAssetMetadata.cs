
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioClipAssetMetadata
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioClipAssetMetadata")]
public partial class AudioClipAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> AudioClip { get => AudioClip_Element.Data; set => AudioClip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> AudioClip_Element = new();
public global::System.Int32 SampleRate { get => SampleRate_Element.Data; set => SampleRate_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> SampleRate_Element = new();
public global::Elements.Assets.ChannelConfiguration Channels { get => Channels_Element.Data; set => Channels_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Elements.Assets.ChannelConfiguration>, global::Elements.Assets.ChannelConfiguration> Channels_Element = new();
public global::System.Int32 ChannelCount { get => ChannelCount_Element.Data; set => ChannelCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> ChannelCount_Element = new();
public global::System.Int32 SampleCount { get => SampleCount_Element.Data; set => SampleCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> SampleCount_Element = new();
public global::System.Double Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> Duration_Element = new();
public global::System.String Extension { get => Extension_Element.Data; set => Extension_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> Extension_Element = new();
public global::System.String CodecInfo { get => CodecInfo_Element.Data; set => CodecInfo_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> CodecInfo_Element = new();
public global::System.Boolean FullyDecoded { get => FullyDecoded_Element.Data; set => FullyDecoded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> FullyDecoded_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioClip", AudioClip_Element.ToLinkReference(context));
members.Add("SampleRate", SampleRate_Element.ToLinkField(context));
members.Add("Channels", Channels_Element.ToLinkField(context));
members.Add("ChannelCount", ChannelCount_Element.ToLinkField(context));
members.Add("SampleCount", SampleCount_Element.ToLinkField(context));
members.Add("Duration", Duration_Element.ToLinkField(context));
members.Add("Extension", Extension_Element.ToLinkField(context));
members.Add("CodecInfo", CodecInfo_Element.ToLinkField(context));
members.Add("FullyDecoded", FullyDecoded_Element.ToLinkField(context));
}

}
}
