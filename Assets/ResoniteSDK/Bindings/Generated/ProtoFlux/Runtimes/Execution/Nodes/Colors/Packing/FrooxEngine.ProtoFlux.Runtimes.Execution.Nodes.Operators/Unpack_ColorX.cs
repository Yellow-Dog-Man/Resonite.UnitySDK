
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_ColorX
// Generated on: pátek 13. února 2026 5:51:46
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("V", new ResoniteLink.Reference() { });
members.Add("R", new ResoniteLink.EmptyElement());
members.Add("G", new ResoniteLink.EmptyElement());
members.Add("B", new ResoniteLink.EmptyElement());
members.Add("A", new ResoniteLink.EmptyElement());
members.Add("Profile", new ResoniteLink.EmptyElement());
}

}
}
