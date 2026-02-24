
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.IndexController
// Generated on: úterý 24. února 2026 18:19:11
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonA;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonB;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonA_Touch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonB_Touch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Touchpad;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadPress;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> TouchpadForce;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ButtonA", new ResoniteLink.EmptyElement());
members.Add("ButtonB", new ResoniteLink.EmptyElement());
members.Add("ButtonA_Touch", new ResoniteLink.EmptyElement());
members.Add("ButtonB_Touch", new ResoniteLink.EmptyElement());
members.Add("Grip", new ResoniteLink.EmptyElement());
members.Add("GripTouch", new ResoniteLink.EmptyElement());
members.Add("GripClick", new ResoniteLink.EmptyElement());
members.Add("Joystick", new ResoniteLink.EmptyElement());
members.Add("JoystickTouch", new ResoniteLink.EmptyElement());
members.Add("JoystickClick", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("TriggerTouch", new ResoniteLink.EmptyElement());
members.Add("TriggerClick", new ResoniteLink.EmptyElement());
members.Add("Touchpad", new ResoniteLink.EmptyElement());
members.Add("TouchpadTouch", new ResoniteLink.EmptyElement());
members.Add("TouchpadPress", new ResoniteLink.EmptyElement());
members.Add("TouchpadForce", new ResoniteLink.EmptyElement());
}

}
}
