
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.GlobalScaleToLocal
// Generated on: čtvrtek 26. února 2026 12:27:58
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.GlobalScaleToLocal")]
public partial class GlobalScaleToLocal : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,UnityEngine.Vector3>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance { get => Instance_Element.Data; set => Instance_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Instance_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> GlobalScale { get => GlobalScale_Element.Data; set => GlobalScale_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> GlobalScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance_Element.ToLinkReference(context));
members.Add("GlobalScale", GlobalScale_Element.ToLinkReference(context));
}

}
}
