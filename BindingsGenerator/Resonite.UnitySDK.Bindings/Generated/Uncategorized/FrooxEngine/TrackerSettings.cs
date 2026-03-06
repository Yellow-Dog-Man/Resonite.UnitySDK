
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings
// Generated on: pátek 6. března 2026 14:19:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackerSettings")]
public partial class TrackerSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TrackerSettings>

{
    public global::System.Boolean UseTrackers { get => UseTrackers_Element.Data; set => UseTrackers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseTrackers_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.TrackerSettings.Tracker>, global::FrooxEngine.TrackerSettings.Tracker> Trackers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseTrackers", UseTrackers_Element.ToLinkField(context));
members.Add("Trackers", Trackers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}
public  async System.Threading.Tasks.Task<global::FrooxEngine.SyncObject> GetTrackerForSubsetting(global::System.String key, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "GetTrackerForSubsetting";
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


}
}
