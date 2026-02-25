
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.TryEnumToSbyte<>
// Generated on: středa 25. února 2026 16:13:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.TryEnumToSbyte<>")]
public partial class TryEnumToSbyte<E> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.SByte>
	where E : struct, System.Enum

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<E> Value;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.SByte> FailValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("FailValue", FailValue.ToResoniteReference(context));
}

}
}
