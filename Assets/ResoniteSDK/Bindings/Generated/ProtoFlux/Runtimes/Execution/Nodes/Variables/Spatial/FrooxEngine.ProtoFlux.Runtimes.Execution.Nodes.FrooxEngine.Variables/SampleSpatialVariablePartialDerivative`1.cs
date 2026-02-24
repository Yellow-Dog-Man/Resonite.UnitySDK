
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleSpatialVariablePartialDerivative<>
// Generated on: úterý 24. února 2026 18:20:01
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleSpatialVariablePartialDerivative<>")]
public partial class SampleSpatialVariablePartialDerivative<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Orientation;
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ValueSpatialVariableMode> Mode;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> BaseValue;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> SamplingDistance;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> X;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Y;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Z;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point.ToResoniteReference(context));
members.Add("Orientation", Orientation.ToResoniteReference(context));
members.Add("Name", Name.ToResoniteReference(context));
members.Add("Mode", Mode.ToResoniteReference(context));
members.Add("BaseValue", BaseValue.ToResoniteReference(context));
members.Add("SamplingDistance", SamplingDistance.ToResoniteReference(context));
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Z", new ResoniteLink.EmptyElement());
}

}
}
