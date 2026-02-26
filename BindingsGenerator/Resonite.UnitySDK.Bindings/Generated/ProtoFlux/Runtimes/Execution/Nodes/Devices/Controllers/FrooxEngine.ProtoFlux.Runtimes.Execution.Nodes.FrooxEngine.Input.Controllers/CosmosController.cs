
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.CosmosController
// Generated on: čtvrtek 26. února 2026 15:08:36
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Menu = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonBY = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonAX = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Bumper = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Menu", Menu.ToLinkEmpty(context));
members.Add("ButtonBY", ButtonBY.ToLinkEmpty(context));
members.Add("ButtonAX", ButtonAX.ToLinkEmpty(context));
members.Add("GripClick", GripClick.ToLinkEmpty(context));
members.Add("Bumper", Bumper.ToLinkEmpty(context));
members.Add("Joystick", Joystick.ToLinkEmpty(context));
members.Add("JoystickTouch", JoystickTouch.ToLinkEmpty(context));
members.Add("JoystickClick", JoystickClick.ToLinkEmpty(context));
members.Add("Trigger", Trigger.ToLinkEmpty(context));
members.Add("TriggerTouch", TriggerTouch.ToLinkEmpty(context));
members.Add("TriggerClick", TriggerClick.ToLinkEmpty(context));
}

}
}
