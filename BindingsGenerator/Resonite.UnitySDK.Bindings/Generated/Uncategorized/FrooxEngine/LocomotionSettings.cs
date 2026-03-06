
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionSettings
// Generated on: pátek 6. března 2026 14:19:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionSettings")]
public partial class LocomotionSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LocomotionSettings>

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.PriorityEntry<global::FrooxEngine.LocomotionArchetype>>, global::FrooxEngine.PriorityEntry<global::FrooxEngine.LocomotionArchetype>> LocomotionPreferences = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocomotionPreferences", LocomotionPreferences.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}
public  async System.Threading.Tasks.Task<global::FrooxEngine.SyncObject> GetEntry(global::System.String key, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "GetEntry";
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
