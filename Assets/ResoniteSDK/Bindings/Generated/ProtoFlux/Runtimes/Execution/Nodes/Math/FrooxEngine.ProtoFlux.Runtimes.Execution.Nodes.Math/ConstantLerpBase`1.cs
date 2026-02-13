
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.ConstantLerpBase<>
// Generated on: pátek 13. února 2026 23:22:37
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.ConstantLerpBase<>")]
public abstract partial class ConstantLerpBase<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueFunctionUpdateBase<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Input;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Input", new ResoniteLink.Reference() { });
members.Add("Speed", new ResoniteLink.Reference() { });
}

}
}
