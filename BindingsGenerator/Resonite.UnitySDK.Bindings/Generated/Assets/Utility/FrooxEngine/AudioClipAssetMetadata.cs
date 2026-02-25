
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioClipAssetMetadata
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioClipAssetMetadata")]
public partial class AudioClipAssetMetadata : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> AudioClip;
public global::System.Int32 SampleRate;
public global::Elements.Assets.ChannelConfiguration Channels;
public global::System.Int32 ChannelCount;
public global::System.Int32 SampleCount;
public global::System.Double Duration;
public global::System.String Extension;
public global::System.String CodecInfo;
public global::System.Boolean FullyDecoded;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AudioClip", AudioClip.ToResoniteReference(context));
members.Add("SampleRate", SampleRate.ToResoniteLinkField());
members.Add("Channels", Channels.ToResoniteLinkField());
members.Add("ChannelCount", ChannelCount.ToResoniteLinkField());
members.Add("SampleCount", SampleCount.ToResoniteLinkField());
members.Add("Duration", Duration.ToResoniteLinkField());
members.Add("Extension", Extension.ToResoniteLinkField());
members.Add("CodecInfo", CodecInfo.ToResoniteLinkField());
members.Add("FullyDecoded", FullyDecoded.ToResoniteLinkField());
}

}
}
