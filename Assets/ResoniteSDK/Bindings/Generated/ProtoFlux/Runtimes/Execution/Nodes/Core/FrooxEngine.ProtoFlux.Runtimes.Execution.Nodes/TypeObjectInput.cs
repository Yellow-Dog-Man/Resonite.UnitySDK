
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.TypeObjectInput
// Generated on: čtvrtek 19. února 2026 7:59:45
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public System.String Type;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type.ToResoniteLinkField());
}

}
}
