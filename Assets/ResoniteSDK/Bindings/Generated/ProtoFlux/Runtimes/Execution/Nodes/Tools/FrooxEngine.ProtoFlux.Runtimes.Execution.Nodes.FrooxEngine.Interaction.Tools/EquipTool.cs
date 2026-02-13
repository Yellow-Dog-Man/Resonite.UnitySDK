
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.EquipTool
// Generated on: pátek 13. února 2026 23:22:57
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.EquipTool")]
public partial class EquipTool : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ActionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ITool> Tool;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Side;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> DequipExisting;
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipped;
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipFail;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tool", new ResoniteLink.Reference() { });
members.Add("User", new ResoniteLink.Reference() { });
members.Add("Side", new ResoniteLink.Reference() { });
members.Add("DequipExisting", new ResoniteLink.Reference() { });
members.Add("OnEquipped", new ResoniteLink.Reference() { });
members.Add("OnEquipFail", new ResoniteLink.Reference() { });
}

}
}
