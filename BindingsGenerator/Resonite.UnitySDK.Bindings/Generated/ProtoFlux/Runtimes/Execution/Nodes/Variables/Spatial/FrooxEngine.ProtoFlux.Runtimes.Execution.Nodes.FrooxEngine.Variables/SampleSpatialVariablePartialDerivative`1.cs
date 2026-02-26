
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleSpatialVariablePartialDerivative<>
// Generated on: čtvrtek 26. února 2026 10:04:35
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>> Orientation_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Name_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ValueSpatialVariableMode> Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ValueSpatialVariableMode>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.ValueSpatialVariableMode>> Mode_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> BaseValue { get => BaseValue_Element.Data; set => BaseValue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> BaseValue_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> SamplingDistance { get => SamplingDistance_Element.Data; set => SamplingDistance_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> SamplingDistance_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> X = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Y = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> Z = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.Data.ToResoniteReference(context));
members.Add("Orientation", Orientation_Element.Data.ToResoniteReference(context));
members.Add("Name", Name_Element.Data.ToResoniteReference(context));
members.Add("Mode", Mode_Element.Data.ToResoniteReference(context));
members.Add("BaseValue", BaseValue_Element.Data.ToResoniteReference(context));
members.Add("SamplingDistance", SamplingDistance_Element.Data.ToResoniteReference(context));
members.Add("X", new ResoniteLink.EmptyElement());
members.Add("Y", new ResoniteLink.EmptyElement());
members.Add("Z", new ResoniteLink.EmptyElement());
}

}
}
