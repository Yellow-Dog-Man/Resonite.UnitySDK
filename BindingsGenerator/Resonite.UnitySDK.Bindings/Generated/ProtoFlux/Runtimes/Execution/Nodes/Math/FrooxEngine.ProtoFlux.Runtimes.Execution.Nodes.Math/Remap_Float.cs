
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float
// Generated on: čtvrtek 26. února 2026 12:27:38
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Remap_Float")]
public partial class Remap_Float : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::System.Single>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMin { get => InMin_Element.Data; set => InMin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> InMin_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InMax { get => InMax_Element.Data; set => InMax_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> InMax_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMin { get => OutMin_Element.Data; set => OutMin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> OutMin_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> OutMax { get => OutMax_Element.Data; set => OutMax_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> OutMax_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InMin", InMin_Element.ToLinkReference(context));
members.Add("InMax", InMax_Element.ToLinkReference(context));
members.Add("OutMin", OutMin_Element.ToLinkReference(context));
members.Add("OutMax", OutMax_Element.ToLinkReference(context));
members.Add("Value", Value_Element.ToLinkReference(context));
}

}
}
