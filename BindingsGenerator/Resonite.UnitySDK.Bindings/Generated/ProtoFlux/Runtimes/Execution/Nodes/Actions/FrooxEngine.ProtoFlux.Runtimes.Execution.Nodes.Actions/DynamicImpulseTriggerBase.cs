
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseTriggerBase
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.DynamicImpulseTriggerBase")]
public abstract partial class DynamicImpulseTriggerBase : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Tag { get => Tag_Element.Data; set => Tag_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Tag_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> TargetHierarchy { get => TargetHierarchy_Element.Data; set => TargetHierarchy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot>> TargetHierarchy_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ExcludeDisabled { get => ExcludeDisabled_Element.Data; set => ExcludeDisabled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> ExcludeDisabled_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> TriggeredCount = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag_Element.ToLinkReference(context));
members.Add("TargetHierarchy", TargetHierarchy_Element.ToLinkReference(context));
members.Add("ExcludeDisabled", ExcludeDisabled_Element.ToLinkReference(context));
members.Add("TriggeredCount", TriggeredCount.ToLinkEmpty(context));
}

}
}
