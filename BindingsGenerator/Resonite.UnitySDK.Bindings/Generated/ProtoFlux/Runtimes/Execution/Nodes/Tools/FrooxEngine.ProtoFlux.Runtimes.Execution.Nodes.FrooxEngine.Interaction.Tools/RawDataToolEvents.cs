
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.RawDataToolEvents
// Generated on: čtvrtek 26. února 2026 12:27:57
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.RawDataToolEvents")]
public partial class RawDataToolEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.RawDataTool> Tool { get => Tool_Element.Data; set => Tool_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.RawDataTool>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.RawDataTool>> Tool_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Equipped { get => Equipped_Element.Data; set => Equipped_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Equipped_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Dequipped { get => Dequipped_Element.Data; set => Dequipped_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> Dequipped_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation ToolUpdate { get => ToolUpdate_Element.Data; set => ToolUpdate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> ToolUpdate_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryPressed { get => PrimaryPressed_Element.Data; set => PrimaryPressed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> PrimaryPressed_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryHeld { get => PrimaryHeld_Element.Data; set => PrimaryHeld_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> PrimaryHeld_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryReleased { get => PrimaryReleased_Element.Data; set => PrimaryReleased_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> PrimaryReleased_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryPressed { get => SecondaryPressed_Element.Data; set => SecondaryPressed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> SecondaryPressed_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryHeld { get => SecondaryHeld_Element.Data; set => SecondaryHeld_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> SecondaryHeld_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryReleased { get => SecondaryReleased_Element.Data; set => SecondaryReleased_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> SecondaryReleased_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool_Element.ToLinkReference(context));
members.Add("Equipped", Equipped_Element.ToLinkReference(context));
members.Add("Dequipped", Dequipped_Element.ToLinkReference(context));
members.Add("ToolUpdate", ToolUpdate_Element.ToLinkReference(context));
members.Add("PrimaryPressed", PrimaryPressed_Element.ToLinkReference(context));
members.Add("PrimaryHeld", PrimaryHeld_Element.ToLinkReference(context));
members.Add("PrimaryReleased", PrimaryReleased_Element.ToLinkReference(context));
members.Add("SecondaryPressed", SecondaryPressed_Element.ToLinkReference(context));
members.Add("SecondaryHeld", SecondaryHeld_Element.ToLinkReference(context));
members.Add("SecondaryReleased", SecondaryReleased_Element.ToLinkReference(context));
}

}
}
