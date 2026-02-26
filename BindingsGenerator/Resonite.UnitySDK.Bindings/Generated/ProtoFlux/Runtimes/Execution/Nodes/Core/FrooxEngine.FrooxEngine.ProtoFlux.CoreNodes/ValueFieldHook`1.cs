
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ValueFieldHook<>
// Generated on: čtvrtek 26. února 2026 12:27:28
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ValueFieldHook<>")]
public partial class ValueFieldHook<T> : global::FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<T>
	where T : struct

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<T>> Source_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> HookedValue = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("HookedValue", HookedValue.ToLinkEmpty(context));
}

}
}
