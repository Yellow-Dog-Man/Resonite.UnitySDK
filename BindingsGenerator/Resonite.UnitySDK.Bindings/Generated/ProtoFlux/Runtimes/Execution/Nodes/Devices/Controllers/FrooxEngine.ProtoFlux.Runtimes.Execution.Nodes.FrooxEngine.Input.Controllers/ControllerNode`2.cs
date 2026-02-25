
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<,>
// Generated on: středa 25. února 2026 16:13:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("Node", Node.ToResoniteReference(context));
members.Add("IsActive", new ResoniteLink.EmptyElement());
members.Add("Type", new ResoniteLink.EmptyElement());
members.Add("BatteryLevel", new ResoniteLink.EmptyElement());
members.Add("IsBatteryCharging", new ResoniteLink.EmptyElement());
}

}
}
