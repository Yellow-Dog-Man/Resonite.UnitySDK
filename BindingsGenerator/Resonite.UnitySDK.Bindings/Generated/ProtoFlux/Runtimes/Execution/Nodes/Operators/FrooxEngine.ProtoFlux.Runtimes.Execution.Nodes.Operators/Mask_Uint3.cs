
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Mask_Uint3
// Generated on: čtvrtek 26. února 2026 12:27:47
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Mask_Uint3")]
public partial class Mask_Uint3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3Uint>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint> OnTrue { get => OnTrue_Element.Data; set => OnTrue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>> OnTrue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint> OnFalse { get => OnFalse_Element.Data; set => OnFalse_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Uint>> OnFalse_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool> Mask { get => Mask_Element.Data; set => Mask_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Bool>> Mask_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnTrue", OnTrue_Element.ToLinkReference(context));
members.Add("OnFalse", OnFalse_Element.ToLinkReference(context));
members.Add("Mask", Mask_Element.ToLinkReference(context));
}

}
}
