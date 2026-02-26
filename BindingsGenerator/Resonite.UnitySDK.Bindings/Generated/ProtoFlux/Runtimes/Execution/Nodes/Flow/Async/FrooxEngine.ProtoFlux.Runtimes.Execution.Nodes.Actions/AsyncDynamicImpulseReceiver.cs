
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver
// Generated on: čtvrtek 26. února 2026 12:27:34
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver")]
public partial class AsyncDynamicImpulseReceiver : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseReceiver.Proxy>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String> Tag { get => Tag_Element.Data; set => Tag_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::System.String>> Tag_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered { get => OnTriggered_Element.Data; set => OnTriggered_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnTriggered_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag_Element.ToLinkReference(context));
members.Add("OnTriggered", OnTriggered_Element.ToLinkReference(context));
}

}
}
