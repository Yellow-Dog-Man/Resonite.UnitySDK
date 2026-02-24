
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.BakeMeshes
// Generated on: úterý 24. února 2026 18:18:56
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Root;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> SkinnedMeshMode;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IncludeInactive;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> DestroyOriginal;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> AssetsSlot;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling> GrabbableHandling;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ComponentHandling> ColliderHandling;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Undoable;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> BakedRoot;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBakeStarted;
public global::FrooxEngine.ProtoFlux.INodeOperation OnBaked;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("SkinnedMeshMode", SkinnedMeshMode.ToResoniteReference(context));
members.Add("IncludeInactive", IncludeInactive.ToResoniteReference(context));
members.Add("DestroyOriginal", DestroyOriginal.ToResoniteReference(context));
members.Add("AssetsSlot", AssetsSlot.ToResoniteReference(context));
members.Add("GrabbableHandling", GrabbableHandling.ToResoniteReference(context));
members.Add("ColliderHandling", ColliderHandling.ToResoniteReference(context));
members.Add("Undoable", Undoable.ToResoniteReference(context));
members.Add("BakedRoot", new ResoniteLink.EmptyElement());
members.Add("OnBakeStarted", OnBakeStarted.ToResoniteReference(context));
members.Add("OnBaked", OnBaked.ToResoniteReference(context));
}

}
}
