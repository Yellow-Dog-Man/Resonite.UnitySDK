
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.TouchController
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.TouchController")]
public partial class TouchController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.TouchController,global::FrooxEngine.TouchControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.TouchControllerModel> Model;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Start;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB_Touch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA_Touch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ThumbRestTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Model", new ResoniteLink.EmptyElement());
members.Add("Start", new ResoniteLink.EmptyElement());
members.Add("ButtonYB", new ResoniteLink.EmptyElement());
members.Add("ButtonXA", new ResoniteLink.EmptyElement());
members.Add("ButtonYB_Touch", new ResoniteLink.EmptyElement());
members.Add("ButtonXA_Touch", new ResoniteLink.EmptyElement());
members.Add("ThumbRestTouch", new ResoniteLink.EmptyElement());
members.Add("Grip", new ResoniteLink.EmptyElement());
members.Add("GripClick", new ResoniteLink.EmptyElement());
members.Add("Joystick", new ResoniteLink.EmptyElement());
members.Add("JoystickTouch", new ResoniteLink.EmptyElement());
members.Add("JoystickClick", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("TriggerTouch", new ResoniteLink.EmptyElement());
members.Add("TriggerClick", new ResoniteLink.EmptyElement());
}

}
}
