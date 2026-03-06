
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.Pow_doubleQ
// Generated on: pátek 6. března 2026 14:18:48
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.Pow_doubleQ")]
public partial class Pow_doubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.QuaternionDouble>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> Q { get => Q_Element.Data; set => Q_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble>> Q_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Pow { get => Pow_Element.Data; set => Pow_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Pow_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Q", Q_Element.ToLinkReference(context));
members.Add("Pow", Pow_Element.ToLinkReference(context));
}

}
}
