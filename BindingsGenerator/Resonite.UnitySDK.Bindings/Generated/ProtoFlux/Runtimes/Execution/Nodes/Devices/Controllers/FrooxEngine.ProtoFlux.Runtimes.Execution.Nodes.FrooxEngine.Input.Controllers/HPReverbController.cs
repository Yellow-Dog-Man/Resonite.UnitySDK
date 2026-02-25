
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.HPReverbController
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.HPReverbController")]
public partial class HPReverbController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.HPReverbController,global::FrooxEngine.HPReverbControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> AppMenu;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonYB;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> ButtonXA;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Grip;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripTouch;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> GripClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Joystick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> JoystickClick;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Trigger;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> TriggerClick;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AppMenu", new ResoniteLink.EmptyElement());
members.Add("ButtonYB", new ResoniteLink.EmptyElement());
members.Add("ButtonXA", new ResoniteLink.EmptyElement());
members.Add("Grip", new ResoniteLink.EmptyElement());
members.Add("GripTouch", new ResoniteLink.EmptyElement());
members.Add("GripClick", new ResoniteLink.EmptyElement());
members.Add("Joystick", new ResoniteLink.EmptyElement());
members.Add("JoystickClick", new ResoniteLink.EmptyElement());
members.Add("Trigger", new ResoniteLink.EmptyElement());
members.Add("TriggerClick", new ResoniteLink.EmptyElement());
}

}
}
