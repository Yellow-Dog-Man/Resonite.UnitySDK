
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte3
// Generated on: pátek 6. března 2026 14:18:55
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Unpack_Sbyte3")]
public partial class Unpack_Sbyte3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte> V { get => V_Element.Data; set => V_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Sbyte>> V_Element = new();
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
