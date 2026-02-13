
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableObjectInputWithEvents<>
// Generated on: pátek 13. února 2026 23:23:00
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.NodeObjectOutput<T> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> HasValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("HasValue", new ResoniteLink.EmptyElement());
}

}
}
