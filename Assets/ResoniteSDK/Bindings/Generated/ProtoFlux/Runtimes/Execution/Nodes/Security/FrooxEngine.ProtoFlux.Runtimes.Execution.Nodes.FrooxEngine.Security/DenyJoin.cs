
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.DenyJoin
// Generated on: pátek 13. února 2026 23:22:53
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.DenyJoin")]
public partial class DenyJoin : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionBreakableFlowNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Security.JoinRequestHandle> Handle;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> DenyReason;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Handle", new ResoniteLink.Reference() { });
members.Add("DenyReason", new ResoniteLink.Reference() { });
}

}
}
