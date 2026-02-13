
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.ToolEvents
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.Tools.ToolEvents")]
public partial class ToolEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.ITool> Tool;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Equipped;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation Dequipped;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tool", new ResoniteLink.Reference() { });
members.Add("Equipped", new ResoniteLink.Reference() { });
members.Add("Dequipped", new ResoniteLink.Reference() { });
}

}
}
