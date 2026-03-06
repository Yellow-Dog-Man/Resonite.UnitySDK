
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimpleAwayIndicator
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimpleAwayIndicator")]
public partial class SimpleAwayIndicator : global::FrooxEngine.Component, global::FrooxEngine.IMeshBakeEventReceiver, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> AwayMaterial { get => AwayMaterial_Element.Data; set => AwayMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> AwayMaterial_Element = new();
public global::FrooxEngine.MeshRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> Renderer_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>, Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> _oldMaterials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("AwayMaterial", AwayMaterial_Element.ToLinkReference(context));
members.Add("Renderer", Renderer_Element.ToLinkReference(context));
members.Add("_oldMaterials", _oldMaterials.ToLinkList(context, m => m.ToLinkReference(context)));
}
public  async System.Threading.Tasks.Task SetAway(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "SetAway";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}

public  async System.Threading.Tasks.Task Restore(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "Restore";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
