
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleBooleanSpatialVariable
// Generated on: čtvrtek 26. února 2026 15:09:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.SampleBooleanSpatialVariable")]
public partial class SampleBooleanSpatialVariable : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Name { get => Name_Element.Data; set => Name_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Name_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.BooleanSpatialVariableMode> Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.BooleanSpatialVariableMode>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::FrooxEngine.BooleanSpatialVariableMode>> Mode_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> BaseValue { get => BaseValue_Element.Data; set => BaseValue_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> BaseValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.ToLinkReference(context));
members.Add("Name", Name_Element.ToLinkReference(context));
members.Add("Mode", Mode_Element.ToLinkReference(context));
members.Add("BaseValue", BaseValue_Element.ToLinkReference(context));
}

}
}
