
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Strings.FormatTimespan
// Generated on: sobota 14. února 2026 8:58:24
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TimeSpan", TimeSpan.ToResoniteReference(context));
members.Add("ShowSeconds", ShowSeconds.ToResoniteReference(context));
members.Add("ShowMilliseconds", ShowMilliseconds.ToResoniteReference(context));
members.Add("FormatProvider", FormatProvider.ToResoniteReference(context));
}

}
}
