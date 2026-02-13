
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<,>
// Generated on: pátek 13. února 2026 5:51:52
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<,>")]
public abstract partial class ControllerNode<C,P> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where P : global::FrooxEngine.ControllerProxy<C>
	where C : class, global::FrooxEngine.IStandardController

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Node;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsActive;
public global::FrooxEngine.ProtoFlux.NodeObjectOutput<System.String> Type;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> BatteryLevel;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsBatteryCharging;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("IsActive", new ResoniteLink.EmptyElement());
members.Add("Type", new ResoniteLink.EmptyElement());
members.Add("BatteryLevel", new ResoniteLink.EmptyElement());
members.Add("IsBatteryCharging", new ResoniteLink.EmptyElement());
}

}
}
