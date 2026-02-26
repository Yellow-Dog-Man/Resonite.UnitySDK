
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamMetadata<>
// Generated on: čtvrtek 26. února 2026 10:03:36
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
    public global::FrooxEngine.AudioStream<S> Stream { get => Stream_Element.Data; set => Stream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioStream<S>>, global::FrooxEngine.AudioStream<S>> Stream_Element = new();
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
members.Add("Stream", Stream_Element.Data.ToResoniteReference(context));
members.Add("UnreadSamples", UnreadSamples_Element.Data.ToResoniteLinkField());
members.Add("TotalMissedSamples", TotalMissedSamples_Element.Data.ToResoniteLinkField());
members.Add("LastMissedSamples", LastMissedSamples_Element.Data.ToResoniteLinkField());
members.Add("BufferLength", BufferLength_Element.Data.ToResoniteLinkField());
members.Add("AverageReadSamplesPerSecond", AverageReadSamplesPerSecond_Element.Data.ToResoniteLinkField());
members.Add("AverageWriteSamplesPerSecond", AverageWriteSamplesPerSecond_Element.Data.ToResoniteLinkField());
members.Add("GlobalIndex", GlobalIndex_Element.Data.ToResoniteLinkField());
members.Add("SamplesAvailableForEncode", SamplesAvailableForEncode_Element.Data.ToResoniteLinkField());
members.Add("FrameSize", FrameSize_Element.Data.ToResoniteLinkField());
members.Add("MaxFrameSize", MaxFrameSize_Element.Data.ToResoniteLinkField());
members.Add("EncodedSampleRate", EncodedSampleRate_Element.Data.ToResoniteLinkField());
members.Add("TotalPacketCount", TotalPacketCount_Element.Data.ToResoniteLinkField());
members.Add("TotalLostPackets", TotalLostPackets_Element.Data.ToResoniteLinkField());
members.Add("LastLostPackets", LastLostPackets_Element.Data.ToResoniteLinkField());
members.Add("PacketLossRatio", PacketLossRatio_Element.Data.ToResoniteLinkField());
members.Add("AverageCodecSamplesPerSecond", AverageCodecSamplesPerSecond_Element.Data.ToResoniteLinkField());
}

}
}
