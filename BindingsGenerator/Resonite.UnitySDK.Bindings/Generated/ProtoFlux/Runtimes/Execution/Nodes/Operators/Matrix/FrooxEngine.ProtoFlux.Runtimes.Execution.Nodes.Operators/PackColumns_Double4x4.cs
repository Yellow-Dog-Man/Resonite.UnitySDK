
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Double4x4
// Generated on: středa 25. února 2026 16:14:02
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Double4x4")]
public partial class PackColumns_Double4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Column0", Column0.ToResoniteReference(context));
members.Add("Column1", Column1.ToResoniteReference(context));
members.Add("Column2", Column2.ToResoniteReference(context));
members.Add("Column3", Column3.ToResoniteReference(context));
}

}
}
