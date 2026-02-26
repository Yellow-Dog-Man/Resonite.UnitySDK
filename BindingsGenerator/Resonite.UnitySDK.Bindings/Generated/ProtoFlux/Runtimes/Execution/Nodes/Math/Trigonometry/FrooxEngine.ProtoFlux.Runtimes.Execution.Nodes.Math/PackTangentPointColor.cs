
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointColor
// Generated on: čtvrtek 26. února 2026 10:04:21
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.PackTangentPointColor")]
public partial class PackTangentPointColor : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::ProtoFlux.Runtimes.Execution.Nodes.Math.TangentPointColor>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>> Value_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color> Tangent { get => Tangent_Element.Data; set => Tangent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Color>> Tangent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.Data.ToResoniteReference(context));
members.Add("Tangent", Tangent_Element.Data.ToResoniteReference(context));
}

}
}
