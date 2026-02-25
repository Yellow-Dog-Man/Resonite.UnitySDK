
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.Characters.SurrogatePairToUTF32
// Generated on: středa 25. února 2026 16:14:07
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char> HighSurrogate;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Char> LowSurrogate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HighSurrogate", HighSurrogate.ToResoniteReference(context));
members.Add("LowSurrogate", LowSurrogate.ToResoniteReference(context));
}

}
}
