
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.Actions.RefProxy<>
// Generated on: čtvrtek 19. února 2026 7:59:51
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.Actions.RefProxy<>")]
public partial class RefProxy<T> : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy, global::ProtoFlux.Runtimes.Execution.Nodes.Actions.ILastValueProxy<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Last;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Last", Last.ToResoniteReference(context));
}

}
}
