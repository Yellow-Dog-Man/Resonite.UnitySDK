
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.FocusWorld
// Generated on: čtvrtek 19. února 2026 8:00:16
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.FocusWorld")]
public partial class FocusWorld : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Worlds.WorldURLActionNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> CloseCurrent;
public global::FrooxEngine.ProtoFlux.INodeOperation OnNotFound;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFocused;
public global::FrooxEngine.ProtoFlux.INodeOperation OnFail;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CloseCurrent", CloseCurrent.ToResoniteReference(context));
members.Add("OnNotFound", OnNotFound.ToResoniteReference(context));
members.Add("OnFocused", OnFocused.ToResoniteReference(context));
members.Add("OnFail", OnFail.ToResoniteReference(context));
}

}
}
