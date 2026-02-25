
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.IndexOfString
// Generated on: středa 25. února 2026 16:14:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.IndexOfString")]
public partial class IndexOfString : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Int32>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Part;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> StartIndex;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> SearchFromEnd;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.StringComparison> ComparisonMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Str", Str.ToResoniteReference(context));
members.Add("Part", Part.ToResoniteReference(context));
members.Add("StartIndex", StartIndex.ToResoniteReference(context));
members.Add("SearchFromEnd", SearchFromEnd.ToResoniteReference(context));
members.Add("ComparisonMode", ComparisonMode.ToResoniteReference(context));
}

}
}
