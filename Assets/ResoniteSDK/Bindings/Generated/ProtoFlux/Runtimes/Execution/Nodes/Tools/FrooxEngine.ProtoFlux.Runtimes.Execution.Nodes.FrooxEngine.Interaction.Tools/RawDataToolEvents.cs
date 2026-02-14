
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.RawDataToolEvents
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.RawDataToolEvents")]
public partial class RawDataToolEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.RawDataTool> Tool;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Equipped;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Dequipped;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation ToolUpdate;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryPressed;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryHeld;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation PrimaryReleased;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryPressed;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryHeld;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SecondaryReleased;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool.ToResoniteReference(context));
members.Add("Equipped", Equipped.ToResoniteReference(context));
members.Add("Dequipped", Dequipped.ToResoniteReference(context));
members.Add("ToolUpdate", ToolUpdate.ToResoniteReference(context));
members.Add("PrimaryPressed", PrimaryPressed.ToResoniteReference(context));
members.Add("PrimaryHeld", PrimaryHeld.ToResoniteReference(context));
members.Add("PrimaryReleased", PrimaryReleased.ToResoniteReference(context));
members.Add("SecondaryPressed", SecondaryPressed.ToResoniteReference(context));
members.Add("SecondaryHeld", SecondaryHeld.ToResoniteReference(context));
members.Add("SecondaryReleased", SecondaryReleased.ToResoniteReference(context));
}

}
}
