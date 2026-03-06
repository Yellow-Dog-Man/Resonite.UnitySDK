
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointColorX
// Generated on: pátek 6. března 2026 14:18:49
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointColorX")]
public partial class PackTangentPointColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Tangent { get => Tangent_Element.Data; set => Tangent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>> Tangent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("Tangent", Tangent_Element.ToLinkReference(context));
}

}
}
