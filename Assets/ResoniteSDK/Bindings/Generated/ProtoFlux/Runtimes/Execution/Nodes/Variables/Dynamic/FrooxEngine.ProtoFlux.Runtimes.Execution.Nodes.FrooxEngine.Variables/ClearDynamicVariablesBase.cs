
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.ClearDynamicVariablesBase
// Generated on: čtvrtek 19. února 2026 8:00:16
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.ClearDynamicVariablesBase")]
public abstract partial class ClearDynamicVariablesBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Target;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> SpaceName;
public global::FrooxEngine.ProtoFlux.INodeOperation OnNotFound;
public global::FrooxEngine.ProtoFlux.INodeOperation OnCleared;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> ClearedCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("SpaceName", SpaceName.ToResoniteReference(context));
members.Add("OnNotFound", OnNotFound.ToResoniteReference(context));
members.Add("OnCleared", OnCleared.ToResoniteReference(context));
members.Add("ClearedCount", new ResoniteLink.EmptyElement());
}

}
}
