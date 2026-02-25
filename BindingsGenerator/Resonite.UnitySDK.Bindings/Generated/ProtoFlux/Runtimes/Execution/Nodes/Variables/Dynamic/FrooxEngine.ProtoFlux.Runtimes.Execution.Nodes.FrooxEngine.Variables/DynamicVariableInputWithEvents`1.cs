
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInputWithEvents<>
// Generated on: středa 25. února 2026 16:14:13
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInputWithEvents<>")]
public abstract partial class DynamicVariableInputWithEvents<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInput<T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> DetectingUser;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSpaceLinked;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSpaceUnlinked;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DetectingUser", DetectingUser.ToResoniteReference(context));
members.Add("OnSpaceLinked", OnSpaceLinked.ToResoniteReference(context));
members.Add("OnSpaceUnlinked", OnSpaceUnlinked.ToResoniteReference(context));
}

}
}
