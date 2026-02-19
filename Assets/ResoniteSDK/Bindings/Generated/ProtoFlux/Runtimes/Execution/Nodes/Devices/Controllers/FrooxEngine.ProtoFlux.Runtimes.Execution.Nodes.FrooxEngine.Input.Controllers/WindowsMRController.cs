
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.WindowsMRController
// Generated on: čtvrtek 19. února 2026 7:59:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Grip;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> App;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerHair;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Touchpad;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TouchpadClick;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Grip", new ResoniteLink.EmptyElement());
members.Add("App", new ResoniteLink.EmptyElement());
members.Add("Joystick", new ResoniteLink.EmptyElement());
members.Add("JoystickClick", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("TriggerHair", new ResoniteLink.EmptyElement());
members.Add("TriggerClick", new ResoniteLink.EmptyElement());
members.Add("Touchpad", new ResoniteLink.EmptyElement());
members.Add("TouchpadTouch", new ResoniteLink.EmptyElement());
members.Add("TouchpadClick", new ResoniteLink.EmptyElement());
}

}
}
