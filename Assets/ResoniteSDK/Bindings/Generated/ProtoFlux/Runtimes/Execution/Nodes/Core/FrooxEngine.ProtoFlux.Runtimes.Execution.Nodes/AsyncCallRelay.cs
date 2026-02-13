
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncCallRelay
// Generated on: pátek 13. února 2026 23:22:21
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncCallRelay")]
public partial class AsyncCallRelay : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeOperation OnTriggered;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnTriggered", new ResoniteLink.Reference() { });
}

}
}
