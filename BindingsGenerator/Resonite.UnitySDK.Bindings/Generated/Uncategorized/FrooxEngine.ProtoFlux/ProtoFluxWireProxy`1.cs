
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireProxy<>
// Generated on: pátek 6. března 2026 14:19:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.ProtoFluxWireManager Wire { get => Wire_Element.Data; set => Wire_Element.Data = value; }
public Reference<global::FrooxEngine.CleanupRef<global::FrooxEngine.ProtoFlux.ProtoFluxWireManager>, global::FrooxEngine.ProtoFlux.ProtoFluxWireManager> Wire_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Wire", Wire_Element.ToLinkReference(context));
}

}
}
