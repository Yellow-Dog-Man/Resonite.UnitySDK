
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.GripEvents
// Generated on: pátek 13. února 2026 5:52:11
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Physics.GripEvents")]
public abstract partial class GripEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.LocomotionGrip> Grip;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnEvent;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<global::FrooxEngine.ILocomotionModule> Module;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.BodyNode> GrippingBodyNode;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Grip", new ResoniteLink.Reference() { });
members.Add("OnEvent", new ResoniteLink.Reference() { });
members.Add("Module", new ResoniteLink.EmptyElement());
members.Add("GrippingBodyNode", new ResoniteLink.EmptyElement());
}

}
}
