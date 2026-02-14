
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.DequipTool
// Generated on: sobota 14. února 2026 8:58:27
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.DequipTool")]
public partial class DequipTool : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Side;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> PopOff;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDequipped;
public global::FrooxEngine.ProtoFlux.INodeOperation OnDequipFail;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("Side", Side.ToResoniteReference(context));
members.Add("PopOff", PopOff.ToResoniteReference(context));
members.Add("OnDequipped", OnDequipped.ToResoniteReference(context));
members.Add("OnDequipFail", OnDequipFail.ToResoniteReference(context));
}

}
}
