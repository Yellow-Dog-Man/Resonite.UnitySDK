
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.IndexController
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.IndexController")]
public partial class IndexController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.IndexController,global::FrooxEngine.IndexControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonA = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonB = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonA_Touch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonB_Touch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Touchpad = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadPress = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> TouchpadForce = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ButtonA", ButtonA.ToLinkEmpty(context));
members.Add("ButtonB", ButtonB.ToLinkEmpty(context));
members.Add("ButtonA_Touch", ButtonA_Touch.ToLinkEmpty(context));
members.Add("ButtonB_Touch", ButtonB_Touch.ToLinkEmpty(context));
members.Add("Grip", Grip.ToLinkEmpty(context));
members.Add("GripTouch", GripTouch.ToLinkEmpty(context));
members.Add("GripClick", GripClick.ToLinkEmpty(context));
members.Add("Joystick", Joystick.ToLinkEmpty(context));
members.Add("JoystickTouch", JoystickTouch.ToLinkEmpty(context));
members.Add("JoystickClick", JoystickClick.ToLinkEmpty(context));
members.Add("Trigger", Trigger.ToLinkEmpty(context));
members.Add("TriggerTouch", TriggerTouch.ToLinkEmpty(context));
members.Add("TriggerClick", TriggerClick.ToLinkEmpty(context));
members.Add("Touchpad", Touchpad.ToLinkEmpty(context));
members.Add("TouchpadTouch", TouchpadTouch.ToLinkEmpty(context));
members.Add("TouchpadPress", TouchpadPress.ToLinkEmpty(context));
members.Add("TouchpadForce", TouchpadForce.ToLinkEmpty(context));
}

}
}
