
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.MultiplyString
// Generated on: čtvrtek 26. února 2026 12:27:54
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.MultiplyString")]
public partial class MultiplyString : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> A { get => A_Element.Data; set => A_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> A_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> B { get => B_Element.Data; set => B_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> B_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.ToLinkReference(context));
members.Add("B", B_Element.ToLinkReference(context));
}

}
}
