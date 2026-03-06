
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPerformanceSettings
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public  async System.Threading.Tasks.Task ResetToDefault(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ResetToDefault";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
