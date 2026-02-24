
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnFalse
// Generated on: úterý 24. února 2026 18:19:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnFalse")]
public partial class FireOnFalse : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnChange<global::System.Boolean,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueProxy<global::System.Boolean>>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Condition", Condition.ToResoniteReference(context));
}

}
}
