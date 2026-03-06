
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.EvaluateSH<,>
// Generated on: pátek 6. března 2026 14:18:49
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SphericalHarmonics.EvaluateSH<,>")]
public partial class EvaluateSH<S,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,T>
	where T : struct
	where S : struct, global::Elements.Core.ISphericalHarmonics<T>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<S> SH { get => SH_Element.Data; set => SH_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<S>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<S>> SH_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Direction_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SH", SH_Element.ToLinkReference(context));
members.Add("Direction", Direction_Element.ToLinkReference(context));
}

}
}
