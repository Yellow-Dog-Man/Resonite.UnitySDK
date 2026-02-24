
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.EquipTool
// Generated on: úterý 24. února 2026 18:19:55
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.EquipTool")]
public partial class EquipTool : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ITool> Tool;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Side;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> DequipExisting;
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipped;
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipFail;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool.ToResoniteReference(context));
members.Add("User", User.ToResoniteReference(context));
members.Add("Side", Side.ToResoniteReference(context));
members.Add("DequipExisting", DequipExisting.ToResoniteReference(context));
members.Add("OnEquipped", OnEquipped.ToResoniteReference(context));
members.Add("OnEquipFail", OnEquipFail.ToResoniteReference(context));
}

}
}
