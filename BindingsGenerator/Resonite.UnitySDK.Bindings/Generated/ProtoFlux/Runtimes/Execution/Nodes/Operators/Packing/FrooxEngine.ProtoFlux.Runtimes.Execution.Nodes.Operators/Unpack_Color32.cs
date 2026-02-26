
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Color32
// Generated on: čtvrtek 26. února 2026 15:08:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Color32")]
public partial class Unpack_Color32 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color32> V { get => V_Element.Data; set => V_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color32>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Byte> R = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Byte> G = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Byte> B = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Byte> A = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("R", R.ToLinkEmpty(context));
members.Add("G", G.ToLinkEmpty(context));
members.Add("B", B.ToLinkEmpty(context));
members.Add("A", A.ToLinkEmpty(context));
}

}
}
