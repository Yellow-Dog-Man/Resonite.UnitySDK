
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CallbackRefArgument<>
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CallbackRefArgument<>")]
public partial class CallbackRefArgument<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IWorldElement

{
    public A Reference;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
}

}
}
