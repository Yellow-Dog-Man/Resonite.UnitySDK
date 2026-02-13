
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand")]
public partial class NearestUserHand : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserNode<global::ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Avatar.NearestUserHand.Data>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetLeft;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> GetRight;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.Chirality> Chirality;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("GetLeft", new ResoniteLink.Reference() { });
members.Add("GetRight", new ResoniteLink.Reference() { });
members.Add("Chirality", new ResoniteLink.EmptyElement());
}

}
}
