
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDisplay<>
// Generated on: čtvrtek 26. února 2026 12:27:28
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ValueDisplay<>")]
public partial class ValueDisplay<T> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalValueDisplay<global::FrooxEngine.ProtoFlux.FrooxEngineContext,T>, global::FrooxEngine.ProtoFlux.IProtoFluxNodePackUnpackListener
	where T : struct

{
    public global::FrooxEngine.IField<T> _value { get => _value_Element.Data; set => _value_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> _value_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_value", _value_Element.ToLinkReference(context));
}

}
}
