
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Double4x4
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Double4x4")]
public partial class PackColumns_Double4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column0 { get => Column0_Element.Data; set => Column0_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Column0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column1 { get => Column1_Element.Data; set => Column1_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Column1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column2 { get => Column2_Element.Data; set => Column2_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Column2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Column3 { get => Column3_Element.Data; set => Column3_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Column3_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Column0", Column0_Element.ToLinkReference(context));
members.Add("Column1", Column1_Element.ToLinkReference(context));
members.Add("Column2", Column2_Element.ToLinkReference(context));
members.Add("Column3", Column3_Element.ToLinkReference(context));
}

}
}
