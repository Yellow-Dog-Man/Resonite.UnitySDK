
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.CreateDynamicVariable<>
// Generated on: úterý 24. února 2026 18:20:00
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.CreateDynamicVariable<>")]
public abstract partial class CreateDynamicVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableAction
	

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnCreated;
public global::FrooxEngine.ProtoFlux.INodeOperation OnAlreadyExists;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFailed;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CreateDirectlyOnTarget;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CreateNonPersistent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnCreated", OnCreated.ToResoniteReference(context));
members.Add("OnAlreadyExists", OnAlreadyExists.ToResoniteReference(context));
members.Add("OnFailed", OnFailed.ToResoniteReference(context));
members.Add("CreateDirectlyOnTarget", CreateDirectlyOnTarget.ToResoniteReference(context));
members.Add("CreateNonPersistent", CreateNonPersistent.ToResoniteReference(context));
}

}
}
