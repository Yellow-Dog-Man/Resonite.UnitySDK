
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamMetadata<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamMetadata<>")]
public partial class AudioStreamMetadata<S> : global::FrooxEngine.Component
	where S : struct, global::Elements.Assets.IAudioSample<S>

{
    public global::FrooxEngine.AudioStream<S> Stream;
public global::System.Int32 UnreadSamples;
public global::System.Int32 TotalMissedSamples;
public global::System.Int32 LastMissedSamples;
public global::System.Int32 BufferLength;
public global::System.Double AverageReadSamplesPerSecond;
public global::System.Double AverageWriteSamplesPerSecond;
public global::System.Int64 GlobalIndex;
public global::System.Int32 SamplesAvailableForEncode;
public global::System.Int32 FrameSize;
public global::System.Int32 MaxFrameSize;
public global::System.Int32 EncodedSampleRate;
public global::System.Int32 TotalPacketCount;
public global::System.Int32 TotalLostPackets;
public global::System.Int32 LastLostPackets;
public global::System.Single PacketLossRatio;
public global::System.Double AverageCodecSamplesPerSecond;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream.ToResoniteReference(context));
members.Add("UnreadSamples", UnreadSamples.ToResoniteLinkField());
members.Add("TotalMissedSamples", TotalMissedSamples.ToResoniteLinkField());
members.Add("LastMissedSamples", LastMissedSamples.ToResoniteLinkField());
members.Add("BufferLength", BufferLength.ToResoniteLinkField());
members.Add("AverageReadSamplesPerSecond", AverageReadSamplesPerSecond.ToResoniteLinkField());
members.Add("AverageWriteSamplesPerSecond", AverageWriteSamplesPerSecond.ToResoniteLinkField());
members.Add("GlobalIndex", GlobalIndex.ToResoniteLinkField());
members.Add("SamplesAvailableForEncode", SamplesAvailableForEncode.ToResoniteLinkField());
members.Add("FrameSize", FrameSize.ToResoniteLinkField());
members.Add("MaxFrameSize", MaxFrameSize.ToResoniteLinkField());
members.Add("EncodedSampleRate", EncodedSampleRate.ToResoniteLinkField());
members.Add("TotalPacketCount", TotalPacketCount.ToResoniteLinkField());
members.Add("TotalLostPackets", TotalLostPackets.ToResoniteLinkField());
members.Add("LastLostPackets", LastLostPackets.ToResoniteLinkField());
members.Add("PacketLossRatio", PacketLossRatio.ToResoniteLinkField());
members.Add("AverageCodecSamplesPerSecond", AverageCodecSamplesPerSecond.ToResoniteLinkField());
}

}
}
