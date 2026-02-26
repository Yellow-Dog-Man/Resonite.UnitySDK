
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamMetadata<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamMetadata<>")]
public partial class AudioStreamMetadata<S> : global::FrooxEngine.Component
	where S : struct, global::Elements.Assets.IAudioSample<S>

{
    public global::FrooxEngine.AudioStream<S> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioStream<S>>, global::FrooxEngine.AudioStream<S>> Stream_Element = new();
public global::System.Int32 UnreadSamples { get => UnreadSamples_Element.Data; set => UnreadSamples_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UnreadSamples_Element = new();
public global::System.Int32 TotalMissedSamples { get => TotalMissedSamples_Element.Data; set => TotalMissedSamples_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalMissedSamples_Element = new();
public global::System.Int32 LastMissedSamples { get => LastMissedSamples_Element.Data; set => LastMissedSamples_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> LastMissedSamples_Element = new();
public global::System.Int32 BufferLength { get => BufferLength_Element.Data; set => BufferLength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BufferLength_Element = new();
public global::System.Double AverageReadSamplesPerSecond { get => AverageReadSamplesPerSecond_Element.Data; set => AverageReadSamplesPerSecond_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> AverageReadSamplesPerSecond_Element = new();
public global::System.Double AverageWriteSamplesPerSecond { get => AverageWriteSamplesPerSecond_Element.Data; set => AverageWriteSamplesPerSecond_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> AverageWriteSamplesPerSecond_Element = new();
public global::System.Int64 GlobalIndex { get => GlobalIndex_Element.Data; set => GlobalIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int64>, global::System.Int64> GlobalIndex_Element = new();
public global::System.Int32 SamplesAvailableForEncode { get => SamplesAvailableForEncode_Element.Data; set => SamplesAvailableForEncode_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> SamplesAvailableForEncode_Element = new();
public global::System.Int32 FrameSize { get => FrameSize_Element.Data; set => FrameSize_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> FrameSize_Element = new();
public global::System.Int32 MaxFrameSize { get => MaxFrameSize_Element.Data; set => MaxFrameSize_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> MaxFrameSize_Element = new();
public global::System.Int32 EncodedSampleRate { get => EncodedSampleRate_Element.Data; set => EncodedSampleRate_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> EncodedSampleRate_Element = new();
public global::System.Int32 TotalPacketCount { get => TotalPacketCount_Element.Data; set => TotalPacketCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalPacketCount_Element = new();
public global::System.Int32 TotalLostPackets { get => TotalLostPackets_Element.Data; set => TotalLostPackets_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalLostPackets_Element = new();
public global::System.Int32 LastLostPackets { get => LastLostPackets_Element.Data; set => LastLostPackets_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> LastLostPackets_Element = new();
public global::System.Single PacketLossRatio { get => PacketLossRatio_Element.Data; set => PacketLossRatio_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> PacketLossRatio_Element = new();
public global::System.Double AverageCodecSamplesPerSecond { get => AverageCodecSamplesPerSecond_Element.Data; set => AverageCodecSamplesPerSecond_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> AverageCodecSamplesPerSecond_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream_Element.ToLinkReference(context));
members.Add("UnreadSamples", UnreadSamples_Element.ToLinkField(context));
members.Add("TotalMissedSamples", TotalMissedSamples_Element.ToLinkField(context));
members.Add("LastMissedSamples", LastMissedSamples_Element.ToLinkField(context));
members.Add("BufferLength", BufferLength_Element.ToLinkField(context));
members.Add("AverageReadSamplesPerSecond", AverageReadSamplesPerSecond_Element.ToLinkField(context));
members.Add("AverageWriteSamplesPerSecond", AverageWriteSamplesPerSecond_Element.ToLinkField(context));
members.Add("GlobalIndex", GlobalIndex_Element.ToLinkField(context));
members.Add("SamplesAvailableForEncode", SamplesAvailableForEncode_Element.ToLinkField(context));
members.Add("FrameSize", FrameSize_Element.ToLinkField(context));
members.Add("MaxFrameSize", MaxFrameSize_Element.ToLinkField(context));
members.Add("EncodedSampleRate", EncodedSampleRate_Element.ToLinkField(context));
members.Add("TotalPacketCount", TotalPacketCount_Element.ToLinkField(context));
members.Add("TotalLostPackets", TotalLostPackets_Element.ToLinkField(context));
members.Add("LastLostPackets", LastLostPackets_Element.ToLinkField(context));
members.Add("PacketLossRatio", PacketLossRatio_Element.ToLinkField(context));
members.Add("AverageCodecSamplesPerSecond", AverageCodecSamplesPerSecond_Element.ToLinkField(context));
}

}
}
