
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PriorityEntry<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PriorityEntry<>")]
public partial class PriorityEntry<K> : global::FrooxEngine.PriorityEntry
	

{
    public K EntryID { get => EntryID_Element.Data; set => EntryID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<K>, K> EntryID_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EntryID", EntryID_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task MoveUp(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "MoveUp";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task MoveDown(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "MoveDown";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task MakeFirst(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "MakeFirst";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task MakeLast(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "MakeLast";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
