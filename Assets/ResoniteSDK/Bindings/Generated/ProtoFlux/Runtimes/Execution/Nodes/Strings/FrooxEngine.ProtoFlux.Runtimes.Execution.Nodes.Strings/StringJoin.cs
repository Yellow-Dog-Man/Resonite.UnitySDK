
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.StringJoin
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.StringJoin")]
public partial class StringJoin : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Inputs;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Separator;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Inputs", new ResoniteLink.SyncList()
{
    Elements = Inputs.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Separator", Separator.ToResoniteReference(context));
}

}
}
