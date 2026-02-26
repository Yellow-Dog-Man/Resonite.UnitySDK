
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableObjectInputWithEvents<>
// Generated on: čtvrtek 26. února 2026 12:28:00
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableObjectInputWithEvents<>")]
public partial class DynamicVariableObjectInputWithEvents<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInputWithEvents<T>
	

{
    public global::FrooxEngine.ProtoFlux.NodeObjectOutput<T> Value = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasValue = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToLinkEmpty(context));
members.Add("HasValue", HasValue.ToLinkEmpty(context));
}

}
}
