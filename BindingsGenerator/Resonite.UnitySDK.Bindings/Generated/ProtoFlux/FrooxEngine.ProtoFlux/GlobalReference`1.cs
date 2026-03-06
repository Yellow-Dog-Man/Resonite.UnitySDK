
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.GlobalReference<>
// Generated on: pátek 6. března 2026 14:18:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.GlobalReference<>")]
public partial class GlobalReference<T> : global::FrooxEngine.Component, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<T>, T> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
}

}
}
