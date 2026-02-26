
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseTriggerWithValue<>
// Generated on: čtvrtek 26. února 2026 12:27:34
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseTriggerWithValue<>")]
public partial class DynamicImpulseTriggerWithValue<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseTriggerBase
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
}

}
}
