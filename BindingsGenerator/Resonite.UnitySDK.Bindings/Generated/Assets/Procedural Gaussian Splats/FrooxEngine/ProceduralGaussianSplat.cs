
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralGaussianSplat
// Generated on: pátek 6. března 2026 14:18:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralGaussianSplat")]
public abstract partial class ProceduralGaussianSplat : global::FrooxEngine.ProceduralAssetProvider<global::FrooxEngine.GaussianSplat>

{
    public global::System.Boolean OverrideBoundingBox { get => OverrideBoundingBox_Element.Data; set => OverrideBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OverrideBoundingBox_Element = new();
public UnityEngine.Bounds OverridenBoundingBox { get => OverridenBoundingBox_Element.Data; set => OverridenBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> OverridenBoundingBox_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideBoundingBox", OverrideBoundingBox_Element.ToLinkField(context));
members.Add("OverridenBoundingBox", OverridenBoundingBox_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task BakeGaussianSplat(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "BakeGaussianSplat";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
