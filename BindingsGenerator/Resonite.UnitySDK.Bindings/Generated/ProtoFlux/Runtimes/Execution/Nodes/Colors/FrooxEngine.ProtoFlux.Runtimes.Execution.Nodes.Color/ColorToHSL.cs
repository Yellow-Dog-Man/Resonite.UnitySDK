
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHSL
// Generated on: středa 25. února 2026 16:13:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Color.ColorToHSL")]
public partial class ColorToHSL : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> C;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> H;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> S;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> L;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("C", C.ToResoniteReference(context));
members.Add("H", new ResoniteLink.EmptyElement());
members.Add("S", new ResoniteLink.EmptyElement());
members.Add("L", new ResoniteLink.EmptyElement());
}

}
}
