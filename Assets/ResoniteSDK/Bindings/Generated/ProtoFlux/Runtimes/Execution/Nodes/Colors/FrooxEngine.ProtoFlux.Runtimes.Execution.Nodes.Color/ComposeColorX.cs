
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ComposeColorX
// Generated on: pátek 13. února 2026 23:22:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ComposeColorX")]
public partial class ComposeColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.ColorX>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> BaseColor;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::Renderite.Shared.ColorProfile> Profile;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BaseColor", new ResoniteLink.Reference() { });
members.Add("Profile", new ResoniteLink.Reference() { });
}

}
}
