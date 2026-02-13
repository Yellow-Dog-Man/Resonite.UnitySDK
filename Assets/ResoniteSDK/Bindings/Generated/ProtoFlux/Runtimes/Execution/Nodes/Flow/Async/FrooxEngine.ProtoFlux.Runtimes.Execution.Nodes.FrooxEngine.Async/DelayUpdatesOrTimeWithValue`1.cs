
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTimeWithValue<>
// Generated on: pátek 13. února 2026 5:51:54
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTimeWithValue<>")]
public abstract partial class DelayUpdatesOrTimeWithValue<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Async.DelayUpdatesOrTime
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Value;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> DelayedValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("DelayedValue", new ResoniteLink.EmptyElement());
}

}
}
