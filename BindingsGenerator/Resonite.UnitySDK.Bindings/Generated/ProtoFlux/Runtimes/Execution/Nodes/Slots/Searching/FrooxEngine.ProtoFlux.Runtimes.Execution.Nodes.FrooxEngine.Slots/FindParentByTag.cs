
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindParentByTag
// Generated on: středa 25. února 2026 16:14:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindParentByTag")]
public partial class FindParentByTag : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.Slot>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Tag;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> SearchDepth;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance.ToResoniteReference(context));
members.Add("Tag", Tag.ToResoniteReference(context));
members.Add("SearchDepth", SearchDepth.ToResoniteReference(context));
}

}
}
