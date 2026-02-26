
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.CreateDynamicVariable<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.CreateDynamicVariable<>")]
public abstract partial class CreateDynamicVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableAction
	

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnCreated { get => OnCreated_Element.Data; set => OnCreated_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnCreated_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnAlreadyExists { get => OnAlreadyExists_Element.Data; set => OnAlreadyExists_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnAlreadyExists_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFailed { get => OnFailed_Element.Data; set => OnFailed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFailed_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CreateDirectlyOnTarget { get => CreateDirectlyOnTarget_Element.Data; set => CreateDirectlyOnTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> CreateDirectlyOnTarget_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CreateNonPersistent { get => CreateNonPersistent_Element.Data; set => CreateNonPersistent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> CreateNonPersistent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnCreated", OnCreated_Element.ToLinkReference(context));
members.Add("OnAlreadyExists", OnAlreadyExists_Element.ToLinkReference(context));
members.Add("OnFailed", OnFailed_Element.ToLinkReference(context));
members.Add("CreateDirectlyOnTarget", CreateDirectlyOnTarget_Element.ToLinkReference(context));
members.Add("CreateNonPersistent", CreateNonPersistent_Element.ToLinkReference(context));
}

}
}
