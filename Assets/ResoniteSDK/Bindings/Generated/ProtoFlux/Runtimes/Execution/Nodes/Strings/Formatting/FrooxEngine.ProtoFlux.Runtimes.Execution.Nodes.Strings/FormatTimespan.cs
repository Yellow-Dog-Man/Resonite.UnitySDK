
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatTimespan
// Generated on: pátek 13. února 2026 5:52:13
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatTimespan")]
public partial class FormatTimespan : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.TimeSpan> TimeSpan;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShowSeconds;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> ShowMilliseconds;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.IFormatProvider> FormatProvider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TimeSpan", new ResoniteLink.Reference() { });
members.Add("ShowSeconds", new ResoniteLink.Reference() { });
members.Add("ShowMilliseconds", new ResoniteLink.Reference() { });
members.Add("FormatProvider", new ResoniteLink.Reference() { });
}

}
}
