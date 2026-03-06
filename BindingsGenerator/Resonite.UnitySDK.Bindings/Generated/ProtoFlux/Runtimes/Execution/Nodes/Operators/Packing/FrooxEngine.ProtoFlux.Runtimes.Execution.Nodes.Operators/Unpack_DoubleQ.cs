
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_DoubleQ
// Generated on: pátek 6. března 2026 14:18:55
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_DoubleQ")]
public partial class Unpack_DoubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> V { get => V_Element.Data; set => V_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> Z = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Double> W = new();

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
