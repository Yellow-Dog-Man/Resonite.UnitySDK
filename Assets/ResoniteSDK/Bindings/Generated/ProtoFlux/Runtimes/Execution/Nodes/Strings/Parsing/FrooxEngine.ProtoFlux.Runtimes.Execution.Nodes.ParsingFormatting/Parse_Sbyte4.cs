
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.Parse_Sbyte4
// Generated on: pátek 13. února 2026 23:22:56
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ParsingFormatting.Parse_Sbyte4")]
public partial class Parse_Sbyte4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Str;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector4Sbyte> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsParsed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Str", new ResoniteLink.Reference() { });
members.Add("Value", new ResoniteLink.EmptyElement());
members.Add("IsParsed", new ResoniteLink.EmptyElement());
}

}
}
