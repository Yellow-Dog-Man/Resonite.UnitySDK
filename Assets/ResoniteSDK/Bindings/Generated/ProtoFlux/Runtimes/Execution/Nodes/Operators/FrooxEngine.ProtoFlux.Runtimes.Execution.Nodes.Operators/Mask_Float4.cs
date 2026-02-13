
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Mask_Float4
// Generated on: pátek 13. února 2026 23:22:44
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.Mask_Float4")]
public partial class Mask_Float4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector4>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> OnTrue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> OnFalse;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4Bool> Mask;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OnTrue", new ResoniteLink.Reference() { });
members.Add("OnFalse", new ResoniteLink.Reference() { });
members.Add("Mask", new ResoniteLink.Reference() { });
}

}
}
