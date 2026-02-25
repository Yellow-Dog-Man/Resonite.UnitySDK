
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireWhileTrue
// Generated on: středa 25. února 2026 16:13:46
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireWhileTrue")]
public partial class FireWhileTrue : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.UserUpdateBase

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnUpdate;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnUpdate", OnUpdate.ToResoniteReference(context));
members.Add("Condition", Condition.ToResoniteReference(context));
}

}
}
