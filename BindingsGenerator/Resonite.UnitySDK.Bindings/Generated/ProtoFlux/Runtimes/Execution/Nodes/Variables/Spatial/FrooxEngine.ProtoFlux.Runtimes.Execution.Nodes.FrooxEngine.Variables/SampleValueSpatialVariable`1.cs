
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleValueSpatialVariable<>
// Generated on: čtvrtek 26. února 2026 12:28:00
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleValueSpatialVariable<>")]
public partial class SampleValueSpatialVariable<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Name_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> DefaultValue { get => DefaultValue_Element.Data; set => DefaultValue_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> DefaultValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.ToLinkReference(context));
members.Add("Name", Name_Element.ToLinkReference(context));
members.Add("DefaultValue", DefaultValue_Element.ToLinkReference(context));
}

}
}
