
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindChildByName
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Slots.FindChildByName")]
public partial class FindChildByName : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.Slot>

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
