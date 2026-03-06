
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Link
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Link")]
public partial class Link : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.Core.INode A { get => A_Element.Data; set => A_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.Core.INode>, global::FrooxEngine.ProtoFlux.Core.INode> A_Element = new();
public global::FrooxEngine.ProtoFlux.Core.INode B { get => B_Element.Data; set => B_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.Core.INode>, global::FrooxEngine.ProtoFlux.Core.INode> B_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A_Element.ToLinkReference(context));
members.Add("B", B_Element.ToLinkReference(context));
}

}
}
