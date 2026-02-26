
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.EquipTool
// Generated on: čtvrtek 26. února 2026 15:08:58
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ITool> Tool { get => Tool_Element.Data; set => Tool_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ITool>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.ITool>> Tool_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User> User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.User>> User_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality> Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.Chirality>> Side_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> DequipExisting { get => DequipExisting_Element.Data; set => DequipExisting_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> DequipExisting_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipped { get => OnEquipped_Element.Data; set => OnEquipped_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnEquipped_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnEquipFail { get => OnEquipFail_Element.Data; set => OnEquipFail_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnEquipFail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool_Element.ToLinkReference(context));
members.Add("User", User_Element.ToLinkReference(context));
members.Add("Side", Side_Element.ToLinkReference(context));
members.Add("DequipExisting", DequipExisting_Element.ToLinkReference(context));
members.Add("OnEquipped", OnEquipped_Element.ToLinkReference(context));
members.Add("OnEquipFail", OnEquipFail_Element.ToLinkReference(context));
}

}
}
