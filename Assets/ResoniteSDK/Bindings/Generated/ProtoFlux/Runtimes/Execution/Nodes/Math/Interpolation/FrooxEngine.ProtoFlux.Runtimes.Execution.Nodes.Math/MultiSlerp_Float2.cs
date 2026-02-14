
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiSlerp_Float2
// Generated on: sobota 14. února 2026 8:58:07
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.MultiSlerp_Float2")]
public partial class MultiSlerp_Float2 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector2>

{
    public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector2>> Operands;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Lerp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Operands", new ResoniteLink.SyncList()
{
    Elements = Operands.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Lerp", Lerp.ToResoniteReference(context));
}

}
}
