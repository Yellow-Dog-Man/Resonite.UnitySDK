
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackRows_Double4x4
// Generated on: pátek 13. února 2026 23:22:50
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Double> Row3;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Row0", new ResoniteLink.Reference() { });
members.Add("Row1", new ResoniteLink.Reference() { });
members.Add("Row2", new ResoniteLink.Reference() { });
members.Add("Row3", new ResoniteLink.Reference() { });
}

}
}
