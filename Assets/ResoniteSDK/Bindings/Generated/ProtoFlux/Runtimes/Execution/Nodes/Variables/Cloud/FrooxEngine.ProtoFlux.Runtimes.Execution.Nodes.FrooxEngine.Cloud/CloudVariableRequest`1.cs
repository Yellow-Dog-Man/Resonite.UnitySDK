
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Cloud.CloudVariableRequest<>
// Generated on: úterý 24. února 2026 18:20:00
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Path;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> VariableOwnerId;
public global::FrooxEngine.ProtoFlux.INodeOperation OnRequest;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDone;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Path", Path.ToResoniteReference(context));
members.Add("VariableOwnerId", VariableOwnerId.ToResoniteReference(context));
members.Add("OnRequest", OnRequest.ToResoniteReference(context));
members.Add("OnDone", OnDone.ToResoniteReference(context));
members.Add("OnFail", OnFail.ToResoniteReference(context));
}

}
}
