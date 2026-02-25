
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_ColorX
// Generated on: středa 25. února 2026 16:13:39
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_ColorX")]
public partial class Unpack_ColorX : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> V;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> R;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> G;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> B;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> A;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.ColorProfile> Profile;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V.ToResoniteReference(context));
members.Add("R", new ResoniteLink.EmptyElement());
members.Add("G", new ResoniteLink.EmptyElement());
members.Add("B", new ResoniteLink.EmptyElement());
members.Add("A", new ResoniteLink.EmptyElement());
members.Add("Profile", new ResoniteLink.EmptyElement());
}

}
}
