
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireProxy<>
// Generated on: sobota 14. února 2026 8:58:47
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireProxy<>")]
public abstract partial class ProtoFluxWireProxy<TTarget> : global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy
	where TTarget : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxWireManager Wire;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Wire", Wire.ToResoniteReference(context));
}

}
}
