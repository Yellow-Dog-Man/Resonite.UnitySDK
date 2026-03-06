
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_ColorX
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> V { get => V_Element.Data; set => V_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> R = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> G = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> B = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> A = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::Renderite.Shared.ColorProfile> Profile = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("R", R.ToLinkEmpty(context));
members.Add("G", G.ToLinkEmpty(context));
members.Add("B", B.ToLinkEmpty(context));
members.Add("A", A.ToLinkEmpty(context));
members.Add("Profile", Profile.ToLinkEmpty(context));
}

}
}
