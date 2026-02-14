
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.GlobalReference<>
// Generated on: sobota 14. února 2026 8:57:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.GlobalReference<>")]
public partial class GlobalReference<T> : global::FrooxEngine.Component, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<T>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
}

}
}
