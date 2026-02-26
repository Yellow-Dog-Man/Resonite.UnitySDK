
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Input.Controllers.StandardController
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
members.Add("Primary", Primary.ToLinkEmpty(context));
members.Add("Secondary", Secondary.ToLinkEmpty(context));
members.Add("Grab", Grab.ToLinkEmpty(context));
members.Add("Menu", Menu.ToLinkEmpty(context));
members.Add("Strength", Strength.ToLinkEmpty(context));
members.Add("Axis", Axis.ToLinkEmpty(context));
}

}
}
