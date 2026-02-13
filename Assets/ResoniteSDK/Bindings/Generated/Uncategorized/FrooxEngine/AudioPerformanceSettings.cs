
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPerformanceSettings
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioPerformanceSettings")]
public partial class AudioPerformanceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioPerformanceSettings>

{
    public global::System.Int32 MaxVoices;
public global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize OutputBufferSize;
public global::FrooxEngine.AudioPerformanceSettings.AudioFrameSize SimulationFrameSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MaxVoices", MaxVoices.ToResoniteLinkField());
members.Add("OutputBufferSize", OutputBufferSize.ToResoniteLinkField());
members.Add("SimulationFrameSize", SimulationFrameSize.ToResoniteLinkField());
}

}
}
