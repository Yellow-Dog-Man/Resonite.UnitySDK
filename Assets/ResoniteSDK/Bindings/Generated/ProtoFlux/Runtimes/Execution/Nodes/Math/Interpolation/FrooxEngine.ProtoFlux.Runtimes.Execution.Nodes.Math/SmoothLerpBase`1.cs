
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SmoothLerpBase<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.SmoothLerpBase<>")]
public abstract partial class SmoothLerpBase<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueFunctionUpdateBase<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Input;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input.ToResoniteReference(context));
members.Add("Speed", Speed.ToResoniteReference(context));
}

}
}
