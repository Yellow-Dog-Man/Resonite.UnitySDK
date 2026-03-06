
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralMesh")]
public abstract partial class ProceduralMesh : global::FrooxEngine.ProceduralAssetProvider<global::FrooxEngine.Mesh>

{
    public global::System.Boolean OverrideBoundingBox { get => OverrideBoundingBox_Element.Data; set => OverrideBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OverrideBoundingBox_Element = new();
public UnityEngine.Bounds OverridenBoundingBox { get => OverridenBoundingBox_Element.Data; set => OverridenBoundingBox_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> OverridenBoundingBox_Element = new();
public global::Renderite.Shared.ColorProfile Profile { get => Profile_Element.Data; set => Profile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> Profile_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideBoundingBox", OverrideBoundingBox_Element.ToLinkField(context));
members.Add("OverridenBoundingBox", OverridenBoundingBox_Element.ToLinkField(context));
members.Add("Profile", Profile_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task BakeMesh(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "BakeMesh";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
