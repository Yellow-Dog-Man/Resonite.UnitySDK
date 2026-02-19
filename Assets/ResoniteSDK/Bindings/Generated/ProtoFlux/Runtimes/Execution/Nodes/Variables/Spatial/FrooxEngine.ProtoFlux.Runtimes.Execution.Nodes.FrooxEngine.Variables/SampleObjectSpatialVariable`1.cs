
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleObjectSpatialVariable<>
// Generated on: čtvrtek 19. února 2026 8:00:16
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleObjectSpatialVariable<>")]
public partial class SampleObjectSpatialVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>
	

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<T> DefaultValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point.ToResoniteReference(context));
members.Add("Name", Name.ToResoniteReference(context));
members.Add("DefaultValue", DefaultValue.ToResoniteReference(context));
}

}
}
