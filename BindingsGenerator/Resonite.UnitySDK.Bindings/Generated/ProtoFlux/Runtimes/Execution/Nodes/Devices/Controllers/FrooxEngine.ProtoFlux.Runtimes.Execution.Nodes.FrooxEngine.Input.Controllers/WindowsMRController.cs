
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.WindowsMRController
// Generated on: čtvrtek 26. února 2026 12:27:33
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.WindowsMRController")]
public partial class WindowsMRController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.WindowsMRController,global::FrooxEngine.WindowsMRControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Grip = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> App = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerHair = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Touchpad = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadClick = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Grip", Grip.ToLinkEmpty(context));
members.Add("App", App.ToLinkEmpty(context));
members.Add("Joystick", Joystick.ToLinkEmpty(context));
members.Add("JoystickClick", JoystickClick.ToLinkEmpty(context));
members.Add("Trigger", Trigger.ToLinkEmpty(context));
members.Add("TriggerHair", TriggerHair.ToLinkEmpty(context));
members.Add("TriggerClick", TriggerClick.ToLinkEmpty(context));
members.Add("Touchpad", Touchpad.ToLinkEmpty(context));
members.Add("TouchpadTouch", TouchpadTouch.ToLinkEmpty(context));
members.Add("TouchpadClick", TouchpadClick.ToLinkEmpty(context));
}

}
}
