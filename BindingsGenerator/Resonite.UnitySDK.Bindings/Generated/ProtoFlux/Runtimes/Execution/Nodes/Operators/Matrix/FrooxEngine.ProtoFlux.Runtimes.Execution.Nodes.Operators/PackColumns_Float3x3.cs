
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Float3x3
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackColumns_Float3x3")]
public partial class PackColumns_Float3x3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix3x3>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Column0 { get => Column0_Element.Data; set => Column0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Column0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Column1 { get => Column1_Element.Data; set => Column1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Column1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Column2 { get => Column2_Element.Data; set => Column2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Column2_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Column0", Column0_Element.ToLinkReference(context));
members.Add("Column1", Column1_Element.ToLinkReference(context));
members.Add("Column2", Column2_Element.ToLinkReference(context));
}

}
}
