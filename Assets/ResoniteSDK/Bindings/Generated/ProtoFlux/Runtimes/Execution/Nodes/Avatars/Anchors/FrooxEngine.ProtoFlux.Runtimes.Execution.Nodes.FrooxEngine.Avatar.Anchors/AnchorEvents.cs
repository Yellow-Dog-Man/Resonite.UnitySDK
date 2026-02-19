
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.Anchors.AnchorEvents
// Generated on: čtvrtek 19. února 2026 7:59:43
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnAnchored", OnAnchored.ToResoniteReference(context));
members.Add("OnReleased", OnReleased.ToResoniteReference(context));
members.Add("User", new ResoniteLink.EmptyElement());
}

}
}
