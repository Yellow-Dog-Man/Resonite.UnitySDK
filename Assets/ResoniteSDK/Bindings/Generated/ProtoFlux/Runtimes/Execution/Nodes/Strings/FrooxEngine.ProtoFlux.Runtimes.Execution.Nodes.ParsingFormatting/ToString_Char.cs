
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.ToString_Char
// Generated on: pátek 13. února 2026 5:52:12
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.ToString_Char")]
public partial class ToString_Char : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char> V;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Format;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider> FormatProvider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("V", new ResoniteLink.Reference() { });
members.Add("Format", new ResoniteLink.Reference() { });
members.Add("FormatProvider", new ResoniteLink.Reference() { });
}

}
}
