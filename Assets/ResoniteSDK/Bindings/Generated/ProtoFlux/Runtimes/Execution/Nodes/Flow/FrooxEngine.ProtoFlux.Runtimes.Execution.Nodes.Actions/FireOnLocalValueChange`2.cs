
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnLocalValueChange<,>
// Generated on: pátek 13. února 2026 23:22:30
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnLocalValueChange<,>")]
public partial class FireOnLocalValueChange<C,T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>
	where T : struct
	where C : global::FrooxEngine.ProtoFlux.FrooxEngineContext

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnChange;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("OnChange", new ResoniteLink.Reference() { });
}

}
}
