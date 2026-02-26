
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.IndexOfString
// Generated on: čtvrtek 26. února 2026 12:27:54
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str { get => Str_Element.Data; set => Str_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Str_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Part { get => Part_Element.Data; set => Part_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Part_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> StartIndex { get => StartIndex_Element.Data; set => StartIndex_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32>> StartIndex_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> SearchFromEnd { get => SearchFromEnd_Element.Data; set => SearchFromEnd_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> SearchFromEnd_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.StringComparison> ComparisonMode { get => ComparisonMode_Element.Data; set => ComparisonMode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.StringComparison>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.StringComparison>> ComparisonMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Str", Str_Element.ToLinkReference(context));
members.Add("Part", Part_Element.ToLinkReference(context));
members.Add("StartIndex", StartIndex_Element.ToLinkReference(context));
members.Add("SearchFromEnd", SearchFromEnd_Element.ToLinkReference(context));
members.Add("ComparisonMode", ComparisonMode_Element.ToLinkReference(context));
}

}
}
