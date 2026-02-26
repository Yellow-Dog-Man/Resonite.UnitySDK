
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte3
// Generated on: čtvrtek 26. února 2026 12:27:52
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte3")]
public partial class Unpack_Sbyte3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte> V { get => V_Element.Data; set => V_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte>> V_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.SByte> Z = new();

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
