
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutputDeviceSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutputDeviceSettings")]
public partial class AudioOutputDeviceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.AudioOutputDeviceSettings>

{
    public global::System.Boolean UseSystemDefault { get => UseSystemDefault_Element.Data; set => UseSystemDefault_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSystemDefault_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DevicePriorityEntry>, global::FrooxEngine.DevicePriorityEntry> DevicePriorities = new();
public global::System.Boolean DevicePrioritiesEnabled { get => DevicePrioritiesEnabled_Element.Data; set => DevicePrioritiesEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DevicePrioritiesEnabled_Element = new();
public global::System.Boolean SeparateStreamingCameraOutput { get => SeparateStreamingCameraOutput_Element.Data; set => SeparateStreamingCameraOutput_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SeparateStreamingCameraOutput_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DevicePriorityEntry>, global::FrooxEngine.DevicePriorityEntry> StreamingCameraPriorities = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseSystemDefault", UseSystemDefault_Element.ToLinkField(context));
members.Add("DevicePriorities", DevicePriorities.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("DevicePrioritiesEnabled", DevicePrioritiesEnabled_Element.ToLinkField(context));
members.Add("SeparateStreamingCameraOutput", SeparateStreamingCameraOutput_Element.ToLinkField(context));
members.Add("StreamingCameraPriorities", StreamingCameraPriorities.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}
public  async System.Threading.Tasks.Task<global::FrooxEngine.SyncObject> GetDevice(global::System.String key, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "GetDevice";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("key", key.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
var resultId = ((ResoniteLink.Data_Reference)result.Result).TargetID;
return context.TryResolveId(resultId) as global::FrooxEngine.SyncObject;
}

public  async System.Threading.Tasks.Task ForceRefreshDevices(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ForceRefreshDevices";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task<global::FrooxEngine.SyncObject> GetStreamingDevice(global::System.String key, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "GetStreamingDevice";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("key", key.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
var resultId = ((ResoniteLink.Data_Reference)result.Result).TargetID;
return context.TryResolveId(resultId) as global::FrooxEngine.SyncObject;
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
