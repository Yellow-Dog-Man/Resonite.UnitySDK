
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Ushort2
// Generated on: čtvrtek 26. února 2026 12:27:53
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Ushort2")]
public partial class Unpack_Ushort2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort> V { get => V_Element.Data; set => V_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2Ushort>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.UInt16> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.UInt16> Y = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("X", X.ToLinkEmpty(context));
members.Add("Y", Y.ToLinkEmpty(context));
}

}
}
