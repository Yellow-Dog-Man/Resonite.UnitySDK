
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleMinMaxSpatialVariable<>
// Generated on: pátek 13. února 2026 23:23:01
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleMinMaxSpatialVariable<>")]
public partial class SampleMinMaxSpatialVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Min;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Max;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> FoundAny;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point", new ResoniteLink.Reference() { });
members.Add("Name", new ResoniteLink.Reference() { });
members.Add("Min", new ResoniteLink.EmptyElement());
members.Add("Max", new ResoniteLink.EmptyElement());
members.Add("FoundAny", new ResoniteLink.EmptyElement());
}

}
}
