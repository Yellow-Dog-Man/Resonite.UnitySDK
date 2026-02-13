
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncSequence
// Generated on: pátek 13. února 2026 5:51:53
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.AsyncSequence")]
public partial class AsyncSequence : global::FrooxEngine.ProtoFlux.Runtimes.Execution.AsyncActionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeOperation> Calls;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Calls", new ResoniteLink.SyncList()
{
    Elements = Calls.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
