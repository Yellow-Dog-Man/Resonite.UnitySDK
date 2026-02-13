
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.GlobalReference<>
// Generated on: pátek 13. února 2026 5:51:16
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
}

}
}
