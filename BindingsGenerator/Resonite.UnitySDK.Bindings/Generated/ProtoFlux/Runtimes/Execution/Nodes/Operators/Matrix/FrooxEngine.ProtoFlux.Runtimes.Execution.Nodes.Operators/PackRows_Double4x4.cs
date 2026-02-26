
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackRows_Double4x4
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackRows_Double4x4")]
public partial class PackRows_Double4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row0 { get => Row0_Element.Data; set => Row0_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Row0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row1 { get => Row1_Element.Data; set => Row1_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Row1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row2 { get => Row2_Element.Data; set => Row2_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Row2_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row3 { get => Row3_Element.Data; set => Row3_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double>> Row3_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Row0", Row0_Element.ToLinkReference(context));
members.Add("Row1", Row1_Element.ToLinkReference(context));
members.Add("Row2", Row2_Element.ToLinkReference(context));
members.Add("Row3", Row3_Element.ToLinkReference(context));
}

}
}
