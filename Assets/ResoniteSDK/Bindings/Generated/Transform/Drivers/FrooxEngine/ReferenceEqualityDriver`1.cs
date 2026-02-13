
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceEqualityDriver<>
// Generated on: pátek 13. února 2026 23:23:09
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceEqualityDriver<>")]
public partial class ReferenceEqualityDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> TargetReference;
public T Reference;
public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::System.Boolean Invert;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetReference", new ResoniteLink.Reference() { });
members.Add("Reference", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Invert", Invert.ToResoniteLinkField());
}

}
}
