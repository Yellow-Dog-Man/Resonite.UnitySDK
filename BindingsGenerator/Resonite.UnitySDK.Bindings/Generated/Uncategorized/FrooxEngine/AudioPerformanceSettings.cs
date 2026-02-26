
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPerformanceSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioPerformanceSettings")]
public partial class AudioPerformanceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioPerformanceSettings>

{
    public global::System.Int32 MaxVoices { get => MaxVoices_Element.Data; set => MaxVoices_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxVoices_Element = new();
public global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize OutputBufferSize { get => OutputBufferSize_Element.Data; set => OutputBufferSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize>, global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize> OutputBufferSize_Element = new();
public global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize SimulationFrameSize { get => SimulationFrameSize_Element.Data; set => SimulationFrameSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize>, global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize> SimulationFrameSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxVoices", MaxVoices_Element.ToLinkField(context));
members.Add("OutputBufferSize", OutputBufferSize_Element.ToLinkField(context));
members.Add("SimulationFrameSize", SimulationFrameSize_Element.ToLinkField(context));
}

}
}
