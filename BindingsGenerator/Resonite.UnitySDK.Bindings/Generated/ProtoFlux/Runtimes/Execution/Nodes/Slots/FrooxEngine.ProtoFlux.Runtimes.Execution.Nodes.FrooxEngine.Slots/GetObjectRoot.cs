
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.GetObjectRoot
// Generated on: čtvrtek 26. února 2026 12:27:54
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.GetObjectRoot")]
public partial class GetObjectRoot : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.Slot>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance { get => Instance_Element.Data; set => Instance_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> Instance_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> OnlyExplicit { get => OnlyExplicit_Element.Data; set => OnlyExplicit_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> OnlyExplicit_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance_Element.ToLinkReference(context));
members.Add("OnlyExplicit", OnlyExplicit_Element.ToLinkReference(context));
}

}
}
