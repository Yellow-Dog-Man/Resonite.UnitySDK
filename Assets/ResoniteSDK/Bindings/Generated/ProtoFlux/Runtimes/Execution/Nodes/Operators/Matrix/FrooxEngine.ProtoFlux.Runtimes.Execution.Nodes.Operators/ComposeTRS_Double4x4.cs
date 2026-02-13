
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.ComposeTRS_Double4x4
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.ComposeTRS_Double4x4")]
public partial class ComposeTRS_Double4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4Double>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double> Position;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.QuaternionDouble> Rotation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double> Scale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Rotation", new ResoniteLink.Reference() { });
members.Add("Scale", new ResoniteLink.Reference() { });
}

}
}
