
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.CosmosController
// Generated on: pátek 13. února 2026 23:22:28
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.CosmosController")]
public partial class CosmosController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.CosmosController,global::FrooxEngine.CosmosControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Menu;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonBY;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonAX;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bumper;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Menu", new ResoniteLink.EmptyElement());
members.Add("ButtonBY", new ResoniteLink.EmptyElement());
members.Add("ButtonAX", new ResoniteLink.EmptyElement());
members.Add("GripClick", new ResoniteLink.EmptyElement());
members.Add("Bumper", new ResoniteLink.EmptyElement());
members.Add("Joystick", new ResoniteLink.EmptyElement());
members.Add("JoystickTouch", new ResoniteLink.EmptyElement());
members.Add("JoystickClick", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("TriggerTouch", new ResoniteLink.EmptyElement());
members.Add("TriggerClick", new ResoniteLink.EmptyElement());
}

}
}
