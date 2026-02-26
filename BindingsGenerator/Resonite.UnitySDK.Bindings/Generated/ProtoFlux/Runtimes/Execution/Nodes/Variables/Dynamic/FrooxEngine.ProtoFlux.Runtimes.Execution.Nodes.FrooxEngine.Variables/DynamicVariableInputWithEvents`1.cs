
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInputWithEvents<>
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInputWithEvents<>")]
public abstract partial class DynamicVariableInputWithEvents<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DynamicVariableInput<T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> DetectingUser { get => DetectingUser_Element.Data; set => DetectingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> DetectingUser_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSpaceLinked { get => OnSpaceLinked_Element.Data; set => OnSpaceLinked_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnSpaceLinked_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnSpaceUnlinked { get => OnSpaceUnlinked_Element.Data; set => OnSpaceUnlinked_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnSpaceUnlinked_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DetectingUser", DetectingUser_Element.ToLinkReference(context));
members.Add("OnSpaceLinked", OnSpaceLinked_Element.ToLinkReference(context));
members.Add("OnSpaceUnlinked", OnSpaceUnlinked_Element.ToLinkReference(context));
}

}
}
