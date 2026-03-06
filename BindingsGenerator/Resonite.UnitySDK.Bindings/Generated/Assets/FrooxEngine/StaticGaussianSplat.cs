
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticGaussianSplat
// Generated on: pátek 6. března 2026 14:18:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticGaussianSplat")]
public partial class StaticGaussianSplat : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.GaussianSplat,global::Elements.Assets.GaussianSplatMetadata,global::FrooxEngine.GaussianSplatVariantDescriptor>

{
    
public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
}
public  async System.Threading.Tasks.Task<global::System.Boolean> ClipWithBoundingBox(UnityEngine.Bounds bounds, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ClipWithBoundingBox";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("bounds", bounds.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ClipWithBoundingBox(UnityEngine.Bounds bounds, UnityEngine.Quaternion boundsOrientation, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ClipWithBoundingBox";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("bounds", bounds.ToData());
__message.Arguments.Add("boundsOrientation", boundsOrientation.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ClipWithSphere(UnityEngine.Vector3 center, global::System.Single radius, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ClipWithSphere";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("center", center.ToData());
__message.Arguments.Add("radius", radius.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ClipWithCylinder(UnityEngine.Vector3 center, global::System.Single radius, global::System.Single height, UnityEngine.Quaternion orientation, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "ClipWithCylinder";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("center", center.ToData());
__message.Arguments.Add("radius", radius.ToData());
__message.Arguments.Add("height", height.ToData());
__message.Arguments.Add("orientation", orientation.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
