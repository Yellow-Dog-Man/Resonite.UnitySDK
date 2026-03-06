
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamSettings")]
public partial class AudioStreamSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioStreamSettings>

{
    public global::System.Single DefaultBitrate { get => DefaultBitrate_Element.Data; set => DefaultBitrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultBitrate_Element = new();
public global::System.String DefaultDeviceID { get => DefaultDeviceID_Element.Data; set => DefaultDeviceID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DefaultDeviceID_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultBitrate", DefaultBitrate_Element.ToLinkField(context));
members.Add("DefaultDeviceID", DefaultDeviceID_Element.ToLinkField(context));
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
