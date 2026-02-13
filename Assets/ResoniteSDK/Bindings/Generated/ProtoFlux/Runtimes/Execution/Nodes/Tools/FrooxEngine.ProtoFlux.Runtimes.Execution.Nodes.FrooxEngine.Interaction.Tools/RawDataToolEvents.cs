
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.RawDataToolEvents
// Generated on: pátek 13. února 2026 5:52:15
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tool", new ResoniteLink.Reference() { });
members.Add("Equipped", new ResoniteLink.Reference() { });
members.Add("Dequipped", new ResoniteLink.Reference() { });
members.Add("ToolUpdate", new ResoniteLink.Reference() { });
members.Add("PrimaryPressed", new ResoniteLink.Reference() { });
members.Add("PrimaryHeld", new ResoniteLink.Reference() { });
members.Add("PrimaryReleased", new ResoniteLink.Reference() { });
members.Add("SecondaryPressed", new ResoniteLink.Reference() { });
members.Add("SecondaryHeld", new ResoniteLink.Reference() { });
members.Add("SecondaryReleased", new ResoniteLink.Reference() { });
}

}
}
