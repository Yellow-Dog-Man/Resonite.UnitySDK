
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioClipAssetMetadata
// Generated on: pátek 13. února 2026 5:51:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AudioClip", new ResoniteLink.Reference() { });
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
