
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.FromUnixMilliseconds
// Generated on: pátek 13. února 2026 23:22:56
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TimeAndDate.FromUnixMilliseconds")]
public partial class FromUnixMilliseconds : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.DateTime>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int64> UnixMiliseconds;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> IsLocal;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UnixMiliseconds", new ResoniteLink.Reference() { });
members.Add("IsLocal", new ResoniteLink.Reference() { });
}

}
}
