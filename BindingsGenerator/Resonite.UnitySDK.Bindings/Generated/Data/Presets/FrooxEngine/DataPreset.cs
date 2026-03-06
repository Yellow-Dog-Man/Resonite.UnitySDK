
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPreset
// Generated on: pátek 6. března 2026 14:18:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPreset")]
public partial class DataPreset : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean IsActive { get => IsActive_Element.Data; set => IsActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsActive_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.IDataPresetEntry>, global::FrooxEngine.IDataPresetEntry, Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IDataPresetEntry>, global::FrooxEngine.IDataPresetEntry>> Entries = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsActive", IsActive_Element.ToLinkField(context));
members.Add("Entries", Entries.ToLinkList(context, m => m.ToLinkReference(context)));
}
public  async System.Threading.Tasks.Task SetActive(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SetActive";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task SetValues(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SetValues";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
