
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SlerpWithMagnitude_Float2
// Generated on: čtvrtek 19. února 2026 7:59:58
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SlerpWithMagnitude_Float2")]
public partial class SlerpWithMagnitude_Float2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector2>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> From;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2> To;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("From", From.ToResoniteReference(context));
members.Add("To", To.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteReference(context));
}

}
}
