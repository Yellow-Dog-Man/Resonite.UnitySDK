
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.ReplaceSubstring
// Generated on: úterý 24. února 2026 18:19:50
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.ReplaceSubstring")]
public partial class ReplaceSubstring : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> SearchFor;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> ReplaceWith;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.StringComparison> ComparisonMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Str", Str.ToResoniteReference(context));
members.Add("SearchFor", SearchFor.ToResoniteReference(context));
members.Add("ReplaceWith", ReplaceWith.ToResoniteReference(context));
members.Add("ComparisonMode", ComparisonMode.ToResoniteReference(context));
}

}
}
