
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PingPong_Uint3_Uint
// Generated on: čtvrtek 26. února 2026 12:27:37
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PingPong_Uint3_Uint")]
public partial class PingPong_Uint3_Uint : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3Uint>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint> N { get => N_Element.Data; set => N_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>> N_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32> Length { get => Length_Element.Data; set => Length_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.UInt32>> Length_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("N", N_Element.ToLinkReference(context));
members.Add("Length", Length_Element.ToLinkReference(context));
}

}
}
