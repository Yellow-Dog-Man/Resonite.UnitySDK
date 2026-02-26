
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteObjectToGlobal<,>
// Generated on: čtvrtek 26. února 2026 15:08:32
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.WriteObjectToGlobal<,>")]
public partial class WriteObjectToGlobal<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<C>, global::FrooxEngine.ProtoFlux.CoreNodes.IGlobalRefWrite
	
	where C : global::ProtoFlux.Runtimes.Execution.ExecutionContext

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T> Global { get => Global_Element.Data; set => Global_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>> Global_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<T>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnWritten { get => OnWritten_Element.Data; set => OnWritten_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnWritten_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail { get => OnFail_Element.Data; set => OnFail_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Global", Global_Element.ToLinkReference(context));
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("OnWritten", OnWritten_Element.ToLinkReference(context));
members.Add("OnFail", OnFail_Element.ToLinkReference(context));
}

}
}
