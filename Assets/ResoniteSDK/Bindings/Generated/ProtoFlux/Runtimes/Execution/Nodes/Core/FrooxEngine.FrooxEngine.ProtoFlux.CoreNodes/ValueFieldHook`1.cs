
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.ValueFieldHook<>
// Generated on: čtvrtek 19. února 2026 7:59:45
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<T> Source;
public global::FrooxEngine.ProtoFlux.NodeValueOutput<T> HookedValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("HookedValue", new ResoniteLink.EmptyElement());
}

}
}
