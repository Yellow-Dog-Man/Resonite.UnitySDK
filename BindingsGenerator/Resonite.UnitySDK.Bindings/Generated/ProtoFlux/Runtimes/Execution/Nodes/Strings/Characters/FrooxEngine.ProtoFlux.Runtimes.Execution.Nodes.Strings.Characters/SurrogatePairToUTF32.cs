
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.Characters.SurrogatePairToUTF32
// Generated on: čtvrtek 26. února 2026 15:08:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.Characters
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.Characters.SurrogatePairToUTF32")]
public partial class SurrogatePairToUTF32 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Int32>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char> HighSurrogate { get => HighSurrogate_Element.Data; set => HighSurrogate_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char>> HighSurrogate_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char> LowSurrogate { get => LowSurrogate_Element.Data; set => LowSurrogate_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char>> LowSurrogate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HighSurrogate", HighSurrogate_Element.ToLinkReference(context));
members.Add("LowSurrogate", LowSurrogate_Element.ToLinkReference(context));
}

}
}
