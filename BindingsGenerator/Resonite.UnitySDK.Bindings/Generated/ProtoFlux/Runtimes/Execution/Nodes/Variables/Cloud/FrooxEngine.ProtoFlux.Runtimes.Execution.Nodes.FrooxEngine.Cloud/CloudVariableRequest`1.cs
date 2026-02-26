
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.CloudVariableRequest<>
// Generated on: čtvrtek 26. února 2026 10:04:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.CloudVariableRequest<>")]
public abstract partial class CloudVariableRequest<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Path { get => Path_Element.Data; set => Path_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Path_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> VariableOwnerId { get => VariableOwnerId_Element.Data; set => VariableOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> VariableOwnerId_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnRequest { get => OnRequest_Element.Data; set => OnRequest_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnRequest_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnDone { get => OnDone_Element.Data; set => OnDone_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnDone_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail { get => OnFail_Element.Data; set => OnFail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Path", Path_Element.Data.ToResoniteReference(context));
members.Add("VariableOwnerId", VariableOwnerId_Element.Data.ToResoniteReference(context));
members.Add("OnRequest", OnRequest_Element.Data.ToResoniteReference(context));
members.Add("OnDone", OnDone_Element.Data.ToResoniteReference(context));
members.Add("OnFail", OnFail_Element.Data.ToResoniteReference(context));
}

}
}
