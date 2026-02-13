
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorEvents
// Generated on: pátek 13. února 2026 23:22:19
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorEvents")]
public partial class AnchorEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorEventsBase

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnAnchored;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnReleased;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.User> User;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnAnchored", new ResoniteLink.Reference() { });
members.Add("OnReleased", new ResoniteLink.Reference() { });
members.Add("User", new ResoniteLink.EmptyElement());
}

}
}
