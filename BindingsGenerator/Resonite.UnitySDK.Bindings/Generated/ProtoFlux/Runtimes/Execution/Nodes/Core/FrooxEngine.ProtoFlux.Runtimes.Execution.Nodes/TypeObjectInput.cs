
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TypeObjectInput
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TypeObjectInput")]
public partial class TypeObjectInput : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.ExternalObjectInput<global::FrooxEngine.ProtoFlux.FrooxEngineContext,System.String>, global::FrooxEngine.ProtoFlux.IInput<System.String>, global::FrooxEngine.ProtoFlux.IInput

{
    public System.String Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> Type_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type_Element.ToLinkField(context));
}

}
}
