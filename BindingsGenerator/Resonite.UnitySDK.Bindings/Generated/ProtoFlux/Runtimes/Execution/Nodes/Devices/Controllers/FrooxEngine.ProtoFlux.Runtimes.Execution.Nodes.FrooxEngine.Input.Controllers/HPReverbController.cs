
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.HPReverbController
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.HPReverbController")]
public partial class HPReverbController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.HPReverbController,global::FrooxEngine.HPReverbControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> AppMenu = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AppMenu", AppMenu.ToLinkEmpty(context));
members.Add("ButtonYB", ButtonYB.ToLinkEmpty(context));
members.Add("ButtonXA", ButtonXA.ToLinkEmpty(context));
members.Add("Grip", Grip.ToLinkEmpty(context));
members.Add("GripTouch", GripTouch.ToLinkEmpty(context));
members.Add("GripClick", GripClick.ToLinkEmpty(context));
members.Add("Joystick", Joystick.ToLinkEmpty(context));
members.Add("JoystickClick", JoystickClick.ToLinkEmpty(context));
members.Add("Trigger", Trigger.ToLinkEmpty(context));
members.Add("TriggerClick", TriggerClick.ToLinkEmpty(context));
}

}
}
