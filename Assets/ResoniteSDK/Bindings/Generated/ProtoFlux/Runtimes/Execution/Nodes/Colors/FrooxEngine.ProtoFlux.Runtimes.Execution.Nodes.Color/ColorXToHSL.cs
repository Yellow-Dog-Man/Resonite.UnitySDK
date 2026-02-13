
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHSL
// Generated on: pátek 13. února 2026 5:51:45
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorXToHSL")]
public partial class ColorXToHSL : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> C;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> H;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> S;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> L;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("C", new ResoniteLink.Reference() { });
members.Add("H", new ResoniteLink.EmptyElement());
members.Add("S", new ResoniteLink.EmptyElement());
members.Add("L", new ResoniteLink.EmptyElement());
}

}
}
