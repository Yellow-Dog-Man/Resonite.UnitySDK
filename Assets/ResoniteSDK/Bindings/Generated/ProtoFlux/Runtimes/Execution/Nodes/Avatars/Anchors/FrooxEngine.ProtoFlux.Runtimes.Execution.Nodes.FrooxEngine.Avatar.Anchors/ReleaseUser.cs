
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.ReleaseUser
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.ReleaseUser")]
public partial class ReleaseUser : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.IAvatarAnchor> Anchor;
public global::FrooxEngine.ProtoFlux.INodeOperation OnReleased;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFailure;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Anchor", new ResoniteLink.Reference() { });
members.Add("OnReleased", new ResoniteLink.Reference() { });
members.Add("OnFailure", new ResoniteLink.Reference() { });
}

}
}
