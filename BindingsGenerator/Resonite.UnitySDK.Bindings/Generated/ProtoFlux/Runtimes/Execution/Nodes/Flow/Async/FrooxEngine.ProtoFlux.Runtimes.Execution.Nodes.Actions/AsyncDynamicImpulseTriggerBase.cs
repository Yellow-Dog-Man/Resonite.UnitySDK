
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseTriggerBase
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.AsyncDynamicImpulseTriggerBase")]
public abstract partial class AsyncDynamicImpulseTriggerBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Tag;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> TargetHierarchy;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExcludeDisabled;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TriggeredCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag.ToResoniteReference(context));
members.Add("TargetHierarchy", TargetHierarchy.ToResoniteReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled.ToResoniteReference(context));
members.Add("TriggeredCount", new ResoniteLink.EmptyElement());
}

}
}
