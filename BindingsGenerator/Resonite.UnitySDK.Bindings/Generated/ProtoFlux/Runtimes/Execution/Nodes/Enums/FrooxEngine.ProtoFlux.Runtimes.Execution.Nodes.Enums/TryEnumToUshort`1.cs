
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.TryEnumToUshort<>
// Generated on: čtvrtek 26. února 2026 12:27:33
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.TryEnumToUshort<>")]
public partial class TryEnumToUshort<E> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.UInt16>
	where E : struct, System.Enum

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<E> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<E>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<E>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt16> FailValue { get => FailValue_Element.Data; set => FailValue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt16>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt16>> FailValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("FailValue", FailValue_Element.ToLinkReference(context));
}

}
}
