
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.DuplicateSlot
// Generated on: sobota 14. února 2026 8:58:23
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.DuplicateSlot")]
public partial class DuplicateSlot : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Template;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> OverrideParent;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.Slot> Duplicate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template.ToResoniteReference(context));
members.Add("OverrideParent", OverrideParent.ToResoniteReference(context));
members.Add("Duplicate", new ResoniteLink.EmptyElement());
}

}
}
