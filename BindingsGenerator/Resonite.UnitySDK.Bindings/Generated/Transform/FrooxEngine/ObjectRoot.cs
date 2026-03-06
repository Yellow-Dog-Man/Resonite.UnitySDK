
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectRoot
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectRoot")]
public partial class ObjectRoot : global::FrooxEngine.Component, global::FrooxEngine.IObjectRoot, global::FrooxEngine.ICustomInspector

{
    
public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
}
public  async System.Threading.Tasks.Task<global::System.Int32> RemoveChildrenObjectRoots(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "RemoveChildrenObjectRoots";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_int)result.Result).Value;
}


}
}
