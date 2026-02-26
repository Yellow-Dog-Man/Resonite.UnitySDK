
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.StandardController
// Generated on: čtvrtek 26. února 2026 10:04:13
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.StandardController")]
public partial class StandardController : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.ControllerNode<global::FrooxEngine.IStandardController,global::FrooxEngine.StandardControllerProxy>

{
    public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Primary = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Secondary = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Grab = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> Menu = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Strength = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector2> Axis = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Primary", new ResoniteLink.EmptyElement());
members.Add("Secondary", new ResoniteLink.EmptyElement());
members.Add("Grab", new ResoniteLink.EmptyElement());
members.Add("Menu", new ResoniteLink.EmptyElement());
members.Add("Strength", new ResoniteLink.EmptyElement());
members.Add("Axis", new ResoniteLink.EmptyElement());
}

}
}
