
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.IndexOfString
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Str", new ResoniteLink.Reference() { });
members.Add("Part", new ResoniteLink.Reference() { });
members.Add("StartIndex", new ResoniteLink.Reference() { });
members.Add("SearchFromEnd", new ResoniteLink.Reference() { });
members.Add("ComparisonMode", new ResoniteLink.Reference() { });
}

}
}
