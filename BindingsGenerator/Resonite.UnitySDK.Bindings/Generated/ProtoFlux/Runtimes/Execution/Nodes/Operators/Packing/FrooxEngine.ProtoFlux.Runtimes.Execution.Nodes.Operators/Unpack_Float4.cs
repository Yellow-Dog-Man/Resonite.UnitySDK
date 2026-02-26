
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Float4
// Generated on: čtvrtek 26. února 2026 12:27:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Float4")]
public partial class Unpack_Float4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> V { get => V_Element.Data; set => V_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Z = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> W = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("X", X.ToLinkEmpty(context));
members.Add("Y", Y.ToLinkEmpty(context));
members.Add("Z", Z.ToLinkEmpty(context));
members.Add("W", W.ToLinkEmpty(context));
}

}
}
