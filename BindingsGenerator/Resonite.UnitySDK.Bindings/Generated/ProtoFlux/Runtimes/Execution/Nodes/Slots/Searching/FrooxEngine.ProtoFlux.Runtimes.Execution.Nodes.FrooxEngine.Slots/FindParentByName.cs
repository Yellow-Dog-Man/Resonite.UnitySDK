
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindParentByName
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindParentByName")]
public partial class FindParentByName : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.Slot>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Instance;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> MatchSubstring;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IgnoreCase;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> SearchDepth;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Instance", Instance.ToResoniteReference(context));
members.Add("Name", Name.ToResoniteReference(context));
members.Add("MatchSubstring", MatchSubstring.ToResoniteReference(context));
members.Add("IgnoreCase", IgnoreCase.ToResoniteReference(context));
members.Add("SearchDepth", SearchDepth.ToResoniteReference(context));
}

}
}
