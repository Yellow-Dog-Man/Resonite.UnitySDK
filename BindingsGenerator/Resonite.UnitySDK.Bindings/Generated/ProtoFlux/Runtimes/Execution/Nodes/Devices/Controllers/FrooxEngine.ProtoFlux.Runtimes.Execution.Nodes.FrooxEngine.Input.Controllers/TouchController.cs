
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.TouchController
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.TouchController")]
public partial class TouchController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.TouchController,global::FrooxEngine.TouchControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.TouchControllerModel> Model = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Start = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB_Touch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA_Touch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ThumbRestTouch = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick = new();
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
members.Add("Model", Model.ToLinkEmpty(context));
members.Add("Start", Start.ToLinkEmpty(context));
members.Add("ButtonYB", ButtonYB.ToLinkEmpty(context));
members.Add("ButtonXA", ButtonXA.ToLinkEmpty(context));
members.Add("ButtonYB_Touch", ButtonYB_Touch.ToLinkEmpty(context));
members.Add("ButtonXA_Touch", ButtonXA_Touch.ToLinkEmpty(context));
members.Add("ThumbRestTouch", ThumbRestTouch.ToLinkEmpty(context));
members.Add("Grip", Grip.ToLinkEmpty(context));
members.Add("GripClick", GripClick.ToLinkEmpty(context));
members.Add("Joystick", Joystick.ToLinkEmpty(context));
members.Add("JoystickTouch", JoystickTouch.ToLinkEmpty(context));
members.Add("JoystickClick", JoystickClick.ToLinkEmpty(context));
members.Add("Trigger", Trigger.ToLinkEmpty(context));
members.Add("TriggerTouch", TriggerTouch.ToLinkEmpty(context));
members.Add("TriggerClick", TriggerClick.ToLinkEmpty(context));
}

}
}
