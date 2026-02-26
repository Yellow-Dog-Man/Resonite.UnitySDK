
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.BakeMeshes
// Generated on: čtvrtek 26. února 2026 12:27:25
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.BakeMeshes")]
public partial class BakeMeshes : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Root_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> SkinnedMeshMode { get => SkinnedMeshMode_Element.Data; set => SkinnedMeshMode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> SkinnedMeshMode_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeInactive { get => IncludeInactive_Element.Data; set => IncludeInactive_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> IncludeInactive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> DestroyOriginal { get => DestroyOriginal_Element.Data; set => DestroyOriginal_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> DestroyOriginal_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> AssetsSlot { get => AssetsSlot_Element.Data; set => AssetsSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> AssetsSlot_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling> GrabbableHandling { get => GrabbableHandling_Element.Data; set => GrabbableHandling_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling>> GrabbableHandling_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling> ColliderHandling { get => ColliderHandling_Element.Data; set => ColliderHandling_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling>> ColliderHandling_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Undoable { get => Undoable_Element.Data; set => Undoable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Undoable_Element = new();
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> BakedRoot = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeStarted { get => OnBakeStarted_Element.Data; set => OnBakeStarted_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBakeStarted_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnBaked { get => OnBaked_Element.Data; set => OnBaked_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnBaked_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("SkinnedMeshMode", SkinnedMeshMode_Element.ToLinkReference(context));
members.Add("IncludeInactive", IncludeInactive_Element.ToLinkReference(context));
members.Add("DestroyOriginal", DestroyOriginal_Element.ToLinkReference(context));
members.Add("AssetsSlot", AssetsSlot_Element.ToLinkReference(context));
members.Add("GrabbableHandling", GrabbableHandling_Element.ToLinkReference(context));
members.Add("ColliderHandling", ColliderHandling_Element.ToLinkReference(context));
members.Add("Undoable", Undoable_Element.ToLinkReference(context));
members.Add("BakedRoot", BakedRoot.ToLinkEmpty(context));
members.Add("OnBakeStarted", OnBakeStarted_Element.ToLinkReference(context));
members.Add("OnBaked", OnBaked_Element.ToLinkReference(context));
}

}
}
