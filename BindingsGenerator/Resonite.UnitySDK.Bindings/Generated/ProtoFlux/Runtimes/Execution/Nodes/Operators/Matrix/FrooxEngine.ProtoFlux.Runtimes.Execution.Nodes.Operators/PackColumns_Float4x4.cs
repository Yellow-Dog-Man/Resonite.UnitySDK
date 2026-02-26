
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Float4x4
// Generated on: čtvrtek 26. února 2026 10:04:27
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Float4x4")]
public partial class PackColumns_Float4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Column0 { get => Column0_Element.Data; set => Column0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>> Column0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Column1 { get => Column1_Element.Data; set => Column1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>> Column1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Column2 { get => Column2_Element.Data; set => Column2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>> Column2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Column3 { get => Column3_Element.Data; set => Column3_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4>> Column3_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Column0", Column0_Element.Data.ToResoniteReference(context));
members.Add("Column1", Column1_Element.Data.ToResoniteReference(context));
members.Add("Column2", Column2_Element.Data.ToResoniteReference(context));
members.Add("Column3", Column3_Element.Data.ToResoniteReference(context));
}

}
}
