
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.ReadDynamicVariable<>
// Generated on: pátek 13. února 2026 23:23:00
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.ReadDynamicVariable<>")]
public abstract partial class ReadDynamicVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>, global::FrooxEngine.FrooxEngine.ProtoFlux.IMappableNode, global::FrooxEngine.ProtoFlux.IProtoFluxNode<global::FrooxEngine.ProtoFlux.IMappableNode>
	

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.Slot> Source;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Path;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> FoundValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Path", new ResoniteLink.Reference() { });
members.Add("FoundValue", new ResoniteLink.EmptyElement());
}

}
}
