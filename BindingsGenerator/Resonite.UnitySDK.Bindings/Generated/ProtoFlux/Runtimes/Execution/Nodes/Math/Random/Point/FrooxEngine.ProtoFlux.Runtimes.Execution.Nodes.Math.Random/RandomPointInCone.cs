
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Random.RandomPointInCone
// Generated on: čtvrtek 26. února 2026 12:27:41
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Random
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Random.RandomPointInCone")]
public partial class RandomPointInCone : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Vector3>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Height_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> BaseRadius { get => BaseRadius_Element.Data; set => BaseRadius_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> BaseRadius_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height_Element.ToLinkReference(context));
members.Add("BaseRadius", BaseRadius_Element.ToLinkReference(context));
}

}
}
