
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Ushort3
// Generated on: čtvrtek 26. února 2026 15:08:54
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Ushort3")]
public partial class Unpack_Ushort3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Ushort> V { get => V_Element.Data; set => V_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Ushort>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Ushort>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.UInt16> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.UInt16> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.UInt16> Z = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("V", V_Element.ToLinkReference(context));
members.Add("X", X.ToLinkEmpty(context));
members.Add("Y", Y.ToLinkEmpty(context));
members.Add("Z", Z.ToLinkEmpty(context));
}

}
}
