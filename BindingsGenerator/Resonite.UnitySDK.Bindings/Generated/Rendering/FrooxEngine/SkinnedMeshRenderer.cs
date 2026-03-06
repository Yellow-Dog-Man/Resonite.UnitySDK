
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SkinnedMeshRenderer
// Generated on: pátek 6. března 2026 14:19:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SkinnedMeshRenderer")]
public partial class SkinnedMeshRenderer : global::FrooxEngine.MeshRenderer, global::FrooxEngine.ICustomMemberNameSource

{
    public global::FrooxEngine.SkinnedBounds BoundsComputeMethod { get => BoundsComputeMethod_Element.Data; set => BoundsComputeMethod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SkinnedBounds>, global::FrooxEngine.SkinnedBounds> BoundsComputeMethod_Element = new();
public global::FrooxEngine.SkinnedMeshRenderer ProxyBoundsSource { get => ProxyBoundsSource_Element.Data; set => ProxyBoundsSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> ProxyBoundsSource_Element = new();
public UnityEngine.Bounds ExplicitLocalBounds { get => ExplicitLocalBounds_Element.Data; set => ExplicitLocalBounds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> ExplicitLocalBounds_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> Bones = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.Single>, global::System.Single, Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single>> BlendShapeWeights = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoundsComputeMethod", BoundsComputeMethod_Element.ToLinkField(context));
members.Add("ProxyBoundsSource", ProxyBoundsSource_Element.ToLinkReference(context));
members.Add("ExplicitLocalBounds", ExplicitLocalBounds_Element.ToLinkField(context));
members.Add("Bones", Bones.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("BlendShapeWeights", BlendShapeWeights.ToLinkList(context, m => m.ToLinkField(context)));
}
public  async System.Threading.Tasks.Task<global::System.Boolean> SplitBlenshapeAlongAxis(global::System.Int32 blendshapeIndex, global::Elements.Axis3D axis, global::System.Single center, global::System.Single transition, global::System.String negativeSuffix, global::System.String positiveSuffix, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SplitBlenshapeAlongAxis";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("blendshapeIndex", blendshapeIndex.ToData());
__message.Arguments.Add("axis", axis.ToData());
__message.Arguments.Add("center", center.ToData());
__message.Arguments.Add("transition", transition.ToData());
__message.Arguments.Add("negativeSuffix", negativeSuffix.ToData());
__message.Arguments.Add("positiveSuffix", positiveSuffix.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> BakeBlendshape(global::System.Int32 blendshapeIndex, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "BakeBlendshape";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("blendshapeIndex", blendshapeIndex.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RemoveBlendshape(global::System.Int32 blendshapeIndex, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "RemoveBlendshape";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("blendshapeIndex", blendshapeIndex.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
