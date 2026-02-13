
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiSlerpWithMagnitude_Float3
// Generated on: pátek 13. února 2026 23:22:38
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiSlerpWithMagnitude_Float3")]
public partial class MultiSlerpWithMagnitude_Float3 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Operands;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Operands", new ResoniteLink.SyncList()
{
    Elements = Operands.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("Lerp", new ResoniteLink.Reference() { });
}

}
}
